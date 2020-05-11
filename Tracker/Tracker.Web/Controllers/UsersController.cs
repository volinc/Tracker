namespace Tracker.Web.Controllers
{
    using MediatR;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using Tracker.Web.Application;

    [Route("[Controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator mediator;

        public UsersController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IEnumerable<UserViewModel>> ReadAllAsync()
        {
            return await mediator.Send(new UsersQuery());
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<UserViewModel> CreateAsync(UserCreateCommand command)
        {
            return await mediator.Send(command);
        }

        [HttpGet("{userId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<UserViewModel> ReadAsync(long userId)
        {
            return await mediator.Send(new UsersQuery());
        }

        //[HttpPut]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //public ActionResult Edit([FromBody] Item item)
        //{
        //    try
        //    {
        //        itemRepository.Update(item);
        //    }
        //    catch (Exception)
        //    {
        //        return BadRequest("Error while editing item");
        //    }
        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public ActionResult Delete(string id)
        //{
        //    var item = itemRepository.Remove(id);

        //    if (item == null)
        //        return NotFound();

        //    return Ok();
        //}
    }
}
