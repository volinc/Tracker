namespace Tracker.Web.Application.Token.Commands
{
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;
    using Taxys.Rest.Authentication.Abstractions;

    public class SignInHandler : IRequestHandler<SignInCommand, AccessTokenResponse>
    {
        public Task<AccessTokenResponse> Handle(SignInCommand command, CancellationToken cancellationToken)
        {
            return Task.FromResult(new AccessTokenResponse());
        }
    }
}
