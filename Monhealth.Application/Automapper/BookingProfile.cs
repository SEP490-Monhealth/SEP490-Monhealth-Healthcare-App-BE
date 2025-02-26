using AutoMapper;
using Monhealth.Application.Features.Booking.Commands.CreateBooking;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class BookingProfile : Profile
    {
        public BookingProfile()
        {
            CreateMap<CreateBookingCommand, Booking>()
                .ForMember(dest => dest.BookingId, opt => opt.MapFrom(_ => Guid.NewGuid()))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(_ => DateTime.Now));


        }
    }
}
