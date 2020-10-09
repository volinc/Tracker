namespace Tracker.Web.Application.Token.Commands
{
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;

    public class SignOutHandler : IRequestHandler<SignOutCommand>
    {
        public Task<Unit> Handle(SignOutCommand command, CancellationToken cancellationToken)
        {
            return Task.FromResult(Unit.Value);
        }
    }
}
