using AutoMapper;
using BookingService.DTOs;
using BookingService.Model;
using BookingService.Repository;

namespace BookingService.Service
{
    public class BookingService:IBookingService
    {
        private readonly IBookingRepository _repo;
        private readonly IMapper _mapper;
        private readonly HttpClient _httpClient;

        public BookingService(IBookingRepository repo,IMapper mapper,HttpClient httpClient )
        {
            _repo = repo;
            _mapper = mapper;
            _httpClient=httpClient;

            
        }

        public async Task<string> AddBookingAsync(BookingDTO dto)
        {
            var response = await _httpClient.GetAsync($"http://localhost:5024/api/Flights/{dto.FlightId}");


            if (!response.IsSuccessStatusCode)
            {
                return "Invalid Flight ID";
            }
            var booking = _mapper.Map<Booking>(dto);
            booking.BookingDate = DateTime.Now;

            await _repo.AddAsync(booking);
            await _repo.SaveAsync();

            return "Booking SuccessFul";

        }

        public async Task<List<BookingDTO>> GetBookingsAsync()
        {
           var bookings =  await _repo.GetAllAsync();
            return _mapper.Map<List<BookingDTO>>(bookings);

        }
    }
}
