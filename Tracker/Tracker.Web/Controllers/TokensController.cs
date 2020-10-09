namespace Tracker.Web.Controllers
{
    using System.Threading.Tasks;
    using Application.Token.Commands;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Taxys.Rest.Authentication;
    using Taxys.Rest.Authentication.Abstractions;

    [Route("tokens")]
    [ApiController]
    public class TokensController : ApiControllerBase
    {
        [HttpPost]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<AccessTokenResponse> SignInAsync(AccessTokenRequest view)
        {
            var command = new SignInCommand(view.GrantType, view.Username, view.Password, view.Code, view.RefreshToken);

            return await Mediator.Send(command);
        }

        [HttpDelete("current")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task SignOutAsync()
        {
            var userId = User.Identity.GetId();
            var command = new SignOutCommand(userId);
            
            await Mediator.Send(command);
        }
    }
}
