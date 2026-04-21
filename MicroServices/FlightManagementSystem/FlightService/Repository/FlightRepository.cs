using FlightService.Data;
using FlightService.Model;
using Microsoft.EntityFrameworkCore;

namespace FlightService.Repository
{
    public class FlightRepository : IFlightRepository
    {
        private readonly FlightDbContext _context;

        public FlightRepository(FlightDbContext context)
        {
            _context = context;
            
        }
        public async Task AddAsync(Flight flight)
        {
            await _context.Flights.AddAsync(flight);
        }

        public async Task<Flight> GetByIdAsync(int id)
        {
            return await _context.Flights.FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<List<Flight>> GetAllAsync()
        {
            return await _context.Flights.ToListAsync();
        }

        public async Task saveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
