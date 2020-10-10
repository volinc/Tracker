namespace Tracker.Web.Application.Location.Commands
{
    using System;
    using MediatR;

    public class CreateLocationCommand : IRequest<Unit>
    {
        public CreateLocationCommand(long userId, double latitude, double longitude, double heading, double speed, DateTimeOffset timestamp)
        {
            UserId = userId;
            Latitude = latitude;
            Longitude = longitude;
            Heading = heading;
            Speed = speed;
            Timestamp = timestamp;
        }

        public long UserId { get; }

        public double Latitude { get; }

        public double Longitude { get; }

        public double Heading { get; }

        public double Speed { get; }

        public DateTimeOffset Timestamp { get; }
    }
}
