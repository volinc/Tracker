namespace Tracker.Web.Controllers
{
    using System.Threading.Tasks;
    using Application.Location.Commands;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Models;

    [Route("[Controller]")]
    [ApiController]
    public class LocationsController : ApiControllerBase
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task CreateAsync(LocationCreateView view)
        {
            await Mediator.Send(new LocationCreateCommand(view.Latitude, view.Longitude));
        }
    }
}
