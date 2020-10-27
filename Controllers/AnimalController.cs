using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SearchAnimal.Controllers
{
    // Example Commit
    [ApiController]
    [Route("[controller]")]
    public class AnimalController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<AnimalController> _logger;

        public AnimalController(ILogger<AnimalController> logger)
        {
            _logger = logger;
        }

        [HttpGet("get/list")]
        public ActionResult<IList<Animal>> GetAnimalList(){

            return Ok(new Animal{Age=1,Name="Crazy",Type="Monkey"});
        }

    }
}
