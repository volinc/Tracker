namespace Tracker.Web.Models
{
    using System;

    public class LocationCreateView
    {
        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public double Heading { get; set; }

        public double Speed { get; set; }

        public DateTimeOffset Timestamp { get; set; }
    }
}
