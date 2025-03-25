using AutoMapper;
using Monhealth.Application.Features.Booking.Commands.CreateBooking;
using Monhealth.Application.Features.Booking.Commands.UpdateBooking;
using Monhealth.Application.Features.Booking.Queries.GetAllBookings;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Automapper
{
    public class BookingProfile : Profile
    {
        public BookingProfile()
        {
            CreateMap<CreateBookingCommand, Booking>()
                .ForMember(dest => dest.BookingId, opt => opt.MapFrom(_ => Guid.NewGuid()))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(_ => BookingStatus.Pending))
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(_ => _.UserId));

            CreateMap<Booking, BookingDto>()
                .ForPath(dest => dest.consultant.ConsultantName, opt => opt.MapFrom(opt => opt.Consultant.AppUser.FullName))
                .ForPath(dest => dest.consultant.ConsultantAvatar, opt => opt.MapFrom(opt => opt.Consultant.AppUser.Avatar))
                .ForPath(dest => dest.consultant.Email, opt => opt.MapFrom(opt => opt.Consultant.AppUser.Email))
                .ForPath(dest => dest.consultant.PhoneNumber, opt => opt.MapFrom(opt => opt.Consultant.AppUser.PhoneNumber))
                .ForPath(dest => dest.member.MemberName, opt => opt.MapFrom(opt => opt.User.FullName))
                .ForPath(dest => dest.member.MemberAvatar, opt => opt.MapFrom(opt => opt.User.Avatar))
                .ForPath(dest => dest.member.Email, opt => opt.MapFrom(opt => opt.User.Email))
                .ForPath(dest => dest.member.PhoneNumber, opt => opt.MapFrom(opt => opt.User.PhoneNumber))
                ;

            CreateMap<UpdateBookingDto, Booking>()
            .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
