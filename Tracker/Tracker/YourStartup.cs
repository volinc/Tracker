namespace Tracker
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.Extensions.DependencyInjection;
    using Shiny;
    using Shiny.Locations;

    public class YourStartup : ShinyStartup
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.UseGps<GpsDelegate>(new GpsRequest
            {
                ThrottledInterval = TimeSpan.FromSeconds(2),
                Interval = TimeSpan.FromSeconds(4),
                Priority = GpsPriority.Highest,
                UseBackground = true
            });
            services.UseGeofencing<GeofenceDelegate>();
        }
    }

    public class GeofenceDelegate : IGeofenceDelegate
    {
        public Task OnStatusChanged(GeofenceState newStatus, GeofenceRegion region)
        {
            return Task.CompletedTask;
        }
    }

    public class GpsDelegate : IGpsDelegate
    {
        public Task OnReading(IGpsReading reading)
        {
            return Task.CompletedTask;
        }
    }
}
