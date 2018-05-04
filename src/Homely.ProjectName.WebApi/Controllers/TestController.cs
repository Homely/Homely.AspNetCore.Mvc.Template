using Homely.ProjectName.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homely.ProjectName.WebApi.Controllers
{
    [Route("test")]
    public class TestController : Controller
    {
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var model = new TestModel
            {
                Id = id,
                Name = $"Test #{id}"
            };

            return Ok(model);
        }

        [HttpPost]
        public IActionResult Post([FromBody] AddOrUpdateTestCommand command)
        {
            // This is where you would call a repository (or raise an event) to save this command.

            return CreatedAtAction("Get", new {id = 1}, command);
        }

        [HttpPut]
        public IActionResult Put([FromBody] AddOrUpdateTestCommand command)
        {
            // This is where you would call a repository (or raise an event) to save this command.

            return Ok(command);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            // This is where you would call a repository (or raise an event) to save this command.

            return NoContent();
        }
    }
}