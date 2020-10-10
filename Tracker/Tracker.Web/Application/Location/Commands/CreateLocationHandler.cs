namespace Tracker.Web.Application.Location.Commands
{
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;

    public class CreateLocationHandler : IRequestHandler<CreateLocationCommand, Unit>
    {
        public CreateLocationHandler()
        {

        }

        public Task<Unit> Handle(CreateLocationCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Unit.Value);
        }
    }
}
