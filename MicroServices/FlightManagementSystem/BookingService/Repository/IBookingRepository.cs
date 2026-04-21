using BookingService.Model;

namespace BookingService.Repository
{
    public interface IBookingRepository
    {
        Task<List<Booking>> GetAllAsync();
        Task AddAsync(Booking booking);
        Task SaveAsync();
    }
}
