using BookingService.Data;
using BookingService.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace BookingService.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private readonly BookingDbContext _context;
        public BookingRepository(BookingDbContext context)
        {
            _context = context;

        }
        public async Task AddAsync(Booking booking)
        {
            await _context.AddAsync(booking);

        }

        public async Task<List<Booking>> GetAllAsync()
        {
            return await _context.bookings.ToListAsync();
        }

        public Task SaveAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
