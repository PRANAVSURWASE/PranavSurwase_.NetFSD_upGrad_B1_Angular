using FlightService.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private static List<Flight> flights = new List<Flight>
        {
            new Flight{Id =4332,FlightNumber = "AI101", Source = "Hyderabad", Destination = "Delhi"},
            new Flight{Id =4222,FlightNumber = "BI202", Source = "Pune", Destination = "NYC"}

        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(flights);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var flight = flights.FirstOrDefault(x => x.Id == id);
            return Ok(flight);
        }
        [HttpPost]
        public IActionResult Create([FromBody] Flight flight)
        {
            flights.Add(flight);
            return Ok(flight);

        }
    
        
    }
}
