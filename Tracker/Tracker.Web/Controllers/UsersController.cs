namespace Tracker.Web.Controllers
{
    using System.Threading.Tasks;
    using Application.User;
    using Application.User.Queries;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("users")]
    [ApiController]
    public class UsersController : ApiControllerBase
    {
        [HttpGet("current")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<UserViewModel> ReadAsync()
        {
            return await Mediator.Send(new UserQuery());
        }
    }
}
