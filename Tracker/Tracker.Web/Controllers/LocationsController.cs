namespace Tracker.Web.Controllers
{
    using System.Threading.Tasks;
    using Application.Location.Commands;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using Taxys.Rest.Authentication;

    [Route("locations")]
    [ApiController]
    public class LocationsController : ApiControllerBase
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task CreateAsync(LocationCreateView view)
        {
            var userId = User.Identity.GetId();
            var command = new CreateLocationCommand(userId, view.Latitude, view.Longitude, view.Heading, view.Speed, view.Timestamp);

            await Mediator.Send(command);
        }
    }
}
