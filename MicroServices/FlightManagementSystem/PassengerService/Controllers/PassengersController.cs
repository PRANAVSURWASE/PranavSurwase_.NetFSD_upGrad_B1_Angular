using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PassengerService.Model;

namespace PassengerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengersController : ControllerBase
    {
        private static List<Passenger> passengers = new()
        {
            new Passenger{PassengerId=1,Name="Vaibhav",Age=25},
            new Passenger{PassengerId=2,Name="Shriraj",Age=23},

        };
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(passengers);
        }

        [HttpPost]
        public IActionResult Create(Passenger passenger)
        {
            passengers.Add(passenger);
            return Ok(passengers);
        }

    }
}
