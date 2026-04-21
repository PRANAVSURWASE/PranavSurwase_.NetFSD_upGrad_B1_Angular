using BookingService.DTOs;
using BookingService.Model;
using AutoMapper;


namespace BookingService.Profiles
{
    public class BookingProfile:Profile
    {
        public BookingProfile()
        {
            CreateMap<Booking, BookingDTO>().ReverseMap();
        }
    }
}
