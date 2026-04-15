using BookingService.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private static List<Booking> bookings = new List<Booking>()
        {
            new Booking{BookingId=1001,FlightId=4332,PassengerId=1},
             new Booking{BookingId=1002,FlightId=4222,PassengerId=2}


        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(bookings);
        }

        [HttpPost]
        public IActionResult Create(Booking booking)
        {
            bookings.Add(booking);
            return Ok(bookings);
        }
    }

}
