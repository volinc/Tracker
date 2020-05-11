namespace Tracker.Web.Controllers
{
    using System;
    using System.Threading.Tasks;
    using Tracker.Web.Models;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

    [Route("[Controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IEnumerable<User>> ReadAllAsync()
        {
            await Task.CompletedTask;
            return Array.Empty<User>();
        }

        //[HttpGet("{id}")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public ActionResult<Item> GetItem(string id)
        //{
        //    var item = itemRepository.Get(id);

        //    if (item == null)
        //        return NotFound();

        //    return item;
        //}

        //[HttpPost]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //public ActionResult<Item> Create([FromBody]Item item)
        //{
        //    itemRepository.Add(item);
        //    return CreatedAtAction(nameof(GetItem), new { item.Id }, item);
        //}

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
