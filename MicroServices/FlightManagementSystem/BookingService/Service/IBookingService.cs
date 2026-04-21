using BookingService.DTOs;

namespace BookingService.Service
{
    public interface IBookingService
    {
        Task<List<BookingDTO>> GetBookingsAsync();
        Task<string> AddBookingAsync(BookingDTO dto);
    }
}
