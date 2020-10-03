namespace Tracker.Web.Application.Location.Commands
{
    using MediatR;

    public class LocationCreateCommand : IRequest<Unit>
    {
        public LocationCreateCommand(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public double Latitude { get; }

        public double Longitude { get; }
    }
}
