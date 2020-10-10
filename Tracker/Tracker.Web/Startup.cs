namespace Tracker.Web
{
    using System.Reflection;
    using Data;
    using MediatR;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using FluentValidation;
    using Microsoft.EntityFrameworkCore;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using Taxys.Data;
    using Taxys.Rest;
    using Taxys.Rest.Authentication;
    using Tracker.Web.Application;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureApiBehaviorOptions();
            services.AddHealthChecks();

            services.AddCors();
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddTaxysJwtBearer();

            services.AddJwtBearerAuthenticationService(Configuration);
            services.AddAuthorization();

            services.AddSwagger("Tracker", addXmlComments: false);
                
            services.AddMediatR(typeof(Startup));
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            var connectionString = Configuration.GetConnectionString("LOGGER");
            services.AddDbContextPool<TrackerDbContext>(options => options.UseSqlServer(connectionString));

            services.AddSingleton<IBinarySerializer, Utf8JsonBinarySerializer>();
            services.AddDistributedMemoryCache();

            services.AddControllers()
                    // https://github.com/aspnet/AspNetCore/issues/13564
                    .AddNewtonsoftJson(options =>
                    {
                        options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                        options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                        options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                    });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseCors(builder =>
            {
                builder.AllowAnyHeader()
                    .AllowAnyMethod()
                    //https://stackoverflow.com/questions/53786977/signalr-core-2-2-cors-allowanyorigin-breaking-change
                    .SetIsOriginAllowed((host) => true)
                    .AllowCredentials();
            });

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers().RequireAuthorization();
                endpoints.MapHealthChecks("/health");
            });

            app.UseSwagger("Tracker");
        }
    }
}