using FlightService.DTOs;

namespace FlightService.Service
{
    public interface IFlightService
    {
        Task<List<FlightDTO>> GetFlightsAsync();
        Task<FlightDTO> GetFlightByIdAsync(int id);
        Task <FlightDTO> AddFlightAsync(FlightDTO flightDTO);


    }
}
