namespace Tracker
{
    using System.Threading.Tasks;
    using Microsoft.Extensions.DependencyInjection;
    using Shiny;
    using Shiny.Infrastructure;
    using Shiny.Locations;

    public class YourStartup : ShinyStartup
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            // register your shiny services here
            services.UseGps<GpsDelegate>();
        }
    }

    public class GpsDelegate : IGpsDelegate
    {
        //private readonly CoreDelegateServices services;
        //public GpsDelegate(CoreDelegateServices services) => this.services = services;

        public Task OnReading(IGpsReading reading) => Task.CompletedTask;
            //=> this.services.Connection.InsertAsync(new GpsEvent
            //{
            //    Latitude = reading.Position.Latitude,
            //    Longitude = reading.Position.Longitude,
            //    Altitude = reading.Altitude,
            //    PositionAccuracy = reading.PositionAccuracy,
            //    Heading = reading.Heading,
            //    HeadingAccuracy = reading.HeadingAccuracy,
            //    Speed = reading.Speed,
            //    Date = reading.Timestamp.ToLocalTime()
            //});
    }
}
