namespace Tracker.Web.Application.Token.Commands
{
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;
    using Taxys.Rest.Authentication;

    public class SignOutHandler : IRequestHandler<SignOutCommand>
    {
        private readonly JwtBearerAuthenticationService authenticationService;

        public SignOutHandler(JwtBearerAuthenticationService authenticationService)
        {
            this.authenticationService = authenticationService;
        }

        public async Task<Unit> Handle(SignOutCommand request, CancellationToken cancellationToken)
        {
            await authenticationService.RemoveTokensAsync(Audience.Runner, request.UserId);

            return Unit.Value;
        }
    }
}
