namespace Tracker.Web.Application.Location.Commands
{
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;

    public class LocationCreateHandler : IRequestHandler<LocationCreateCommand, Unit>
    {
        public Task<Unit> Handle(LocationCreateCommand command, CancellationToken cancellationToken)
        {
            return Task.FromResult(Unit.Value);
        }
    }
}
