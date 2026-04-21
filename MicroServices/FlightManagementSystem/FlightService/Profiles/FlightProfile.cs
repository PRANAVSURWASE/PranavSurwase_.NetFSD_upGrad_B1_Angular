using AutoMapper;
using FlightService.DTOs;
using FlightService.Model;

namespace FlightService.Profiles
{
    public class FlightProfile:Profile
    {
        public FlightProfile()
        {
            CreateMap<Flight, FlightDTO>().ReverseMap();
        }
    }
}
