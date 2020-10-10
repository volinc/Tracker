namespace Tracker.Web.Application.Token.Commands
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;
    using Taxys.Domain;
    using Taxys.Rest.Authentication;
    using Taxys.Rest.Authentication.Abstractions;

    public class SignInHandler : IRequestHandler<SignInCommand, AccessTokenResponse>
    {
        private readonly JwtBearerAuthenticationService authenticationService;

        public SignInHandler(JwtBearerAuthenticationService authenticationService)
        {
            this.authenticationService = authenticationService;
        }

        public async Task<AccessTokenResponse> Handle(SignInCommand request, CancellationToken cancellationToken)
        {
            Task<MiniUser> Validate(bool isPasswordless) => ValidateCredentialAsync(isPasswordless, request.Username, request.Password, request.Code);

            var accessTokenRequest = new AccessTokenRequest
            {
                Code = request.Code, 
                GrantType = request.GrantType,
                Password = request.Password,
                RefreshToken = request.RefreshToken,
                Username = request.Username
            };

            var miniUser = await authenticationService.AuthenticateAsync(accessTokenRequest, Audience.Runner, Validate);
            
            return await authenticationService.CreateTokensAsync(Audience.Runner, miniUser, Role.Runner);
        }

        private static Task<MiniUser> ValidateCredentialAsync(bool isPasswordless, string username, string password, string code)
        {
            if (isPasswordless)
                throw new NotSupportedException();

            return username switch
            {
                "123" when password == "321" => Task.FromResult(new MiniUser {Id = 1}),
                "qaz" when password == "zaq" => Task.FromResult(new MiniUser {Id = 2}),
                _ => throw new EntityNotFoundException(typeof(User), username)
            };
        }
    }

    public static class Audience
    {
        public const string Runner = "Runner";
    }

    public static class Role
    {
        public const string Runner = "Runner";
    }
}
