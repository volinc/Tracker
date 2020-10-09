namespace Tracker.Web.Application.Token.Commands
{
    using MediatR;
    using Taxys.Rest.Authentication.Abstractions;

    public class SignInCommand : IRequest<AccessTokenResponse>
    {
        public SignInCommand(string grantType, string username, string password, string code, string refreshToken)
        {
            GrantType = grantType;
            Username = username;
            Password = password;
            Code = code;
            RefreshToken = refreshToken;
        }

        public string GrantType { get; }

        public string Username { get; }

        public string Password { get; }

        public string Code { get; }

        public string RefreshToken { get; }
    }
}
