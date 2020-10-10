namespace Tracker.Web.Data
{
    using System;

    public class TrackPoint
    {
        public long Id { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public double Heading { get; set; }

        public double Speed { get; set; }

        public DateTimeOffset Timestamp { get; set; }
    }
}