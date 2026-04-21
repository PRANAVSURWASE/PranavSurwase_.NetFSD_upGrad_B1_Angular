using FlightService.DTOs;
using FlightService.Model;
using FlightService.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {

        private readonly IFlightService _service;

        public FlightsController(IFlightService service)
        {
            _service = service;
            
        }
        [HttpGet]
        public async Task<IActionResult> GetFlights()
        {
            var result = await _service.GetFlightsAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFlight(int id)
        {
            var result = await _service.GetFlightByIdAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> AddFlight(FlightDTO flightDto)
        {
            var result = await _service.AddFlightAsync(flightDto);
            return Ok(result);
          

        }
    
        
    }
}
