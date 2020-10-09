namespace Tracker.Web.Controllers
{
    using System.Threading.Tasks;
    using Application.Location.Commands;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Models;

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
            await Mediator.Send(new CreateLocationCommand(view.Latitude, view.Longitude));
        }
    }
}
