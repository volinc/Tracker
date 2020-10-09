namespace Tracker.Web.Application.Location.Commands
{
    using MediatR;

    public class CreateLocationCommand : IRequest<Unit>
    {
        public CreateLocationCommand(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public double Latitude { get; }

        public double Longitude { get; }
    }
}
