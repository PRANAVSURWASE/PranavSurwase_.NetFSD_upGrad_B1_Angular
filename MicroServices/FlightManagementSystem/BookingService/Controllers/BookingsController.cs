using BookingService.DTOs;
using BookingService.Model;
using BookingService.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _service;

        public BookingsController(IBookingService service)
        {
            _service = service;
            
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var booking = await _service.GetBookingsAsync();
            return Ok(booking);
        }

        [HttpPost]
        public async Task<IActionResult> Create(BookingDTO dto)
        {
            var res = await _service.AddBookingAsync(dto);
            return Ok(res);
        }
    }

}
