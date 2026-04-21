using FlightService.Model;

namespace FlightService.Repository
{
    public interface IFlightRepository
    {
        Task<List<Flight>> GetAllAsync();
        Task<Flight> GetByIdAsync(int id);
        Task AddAsync(Flight flight);
        Task saveAsync();
    }
}
