namespace Tracker.Web.Application.Location.Commands
{
    using System.Threading;
    using System.Threading.Tasks;
    using Data;
    using MediatR;

    public class CreateLocationHandler : IRequestHandler<CreateLocationCommand, Unit>
    {
        private readonly TrackerDbContext dbContext;

        public CreateLocationHandler(TrackerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Unit> Handle(CreateLocationCommand request, CancellationToken cancellationToken)
        {
            dbContext.TrackPoints.Add(new TrackPoint
            {
                UserId = request.UserId,
                Latitude = request.Latitude,
                Longitude = request.Longitude,
                Heading = request.Heading,
                Speed = request.Speed,
                Timestamp = request.Timestamp
            });

            await dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
