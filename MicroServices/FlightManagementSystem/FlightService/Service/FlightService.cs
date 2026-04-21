using AutoMapper;
using FlightService.DTOs;
using FlightService.Model;
using FlightService.Repository;

namespace FlightService.Service
{
    public class FlightService : IFlightService
    {

        private readonly IFlightRepository _repo;
        private readonly IMapper _mapper;

        public FlightService(IFlightRepository repo,IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<FlightDTO> AddFlightAsync(FlightDTO flightDTO)
        {
            var flight = _mapper.Map<Flight>(flightDTO);

            await _repo.AddAsync(flight);
            await _repo.saveAsync();

            return _mapper.Map<FlightDTO>(flight);
        }

        public async Task<FlightDTO> GetFlightByIdAsync(int id)
        {
            var flight = await _repo.GetByIdAsync(id);
            return _mapper.Map<FlightDTO>(flight);
           
        }

        public async Task<List<FlightDTO>> GetFlightsAsync()
        {
            var flights = await _repo.GetAllAsync();
            return _mapper.Map<List<FlightDTO>>(flights);
        }
    }
}
