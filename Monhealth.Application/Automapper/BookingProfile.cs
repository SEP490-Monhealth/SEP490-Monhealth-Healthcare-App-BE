using AutoMapper;
using Monhealth.Application.Features.Booking.Commands.CreateBooking;
using Monhealth.Application.Features.Booking.Commands.UpdateBooking;
using Monhealth.Application.Features.Booking.Queries.GetAllBookings;
using Monhealth.Application.Features.Booking.Queries.GetBookingByConsultantId;
using Monhealth.Application.Features.Booking.Queries.GetBookingByUserId;
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
                .ForMember(dest => dest.ConsultantName, opt => opt.MapFrom(opt => opt.Consultant.AppUser.FullName))
                .ForMember(dest => dest.ConsultantAvatar, opt => opt.MapFrom(opt => opt.Consultant.AppUser.Avatar))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(opt => opt.Consultant.AppUser.Email))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(opt => opt.Consultant.AppUser.PhoneNumber))
                .ForMember(dest => dest.MemberName, opt => opt.MapFrom(opt => opt.User.FullName))
                .ForMember(dest => dest.MemberAvatar, opt => opt.MapFrom(opt => opt.User.Avatar))

                ;
            CreateMap<Booking, GetBookingByUserIdDto>()
                .ForMember(dest => dest.ConsultantName, opt => opt.MapFrom(opt => opt.Consultant.AppUser.FullName))
                .ForMember(dest => dest.ConsultantAvatar, opt => opt.MapFrom(opt => opt.Consultant.AppUser.Avatar))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(opt => opt.Consultant.AppUser.Email))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(opt => opt.Consultant.AppUser.PhoneNumber))
                .ForMember(dest => dest.MemberName, opt => opt.MapFrom(opt => opt.User.FullName))
                .ForMember(dest => dest.MemberAvatar, opt => opt.MapFrom(opt => opt.User.Avatar))
                ;
            CreateMap<Booking, GetByConsultantIdDto>()
                .ForMember(dest => dest.ConsultantName, opt => opt.MapFrom(opt => opt.Consultant.AppUser.FullName))
                .ForMember(dest => dest.ConsultantAvatar, opt => opt.MapFrom(opt => opt.Consultant.AppUser.Avatar))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(opt => opt.Consultant.AppUser.Email))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(opt => opt.Consultant.AppUser.PhoneNumber))
                .ForMember(dest => dest.MemberName, opt => opt.MapFrom(opt => opt.User.FullName))
                .ForMember(dest => dest.MemberAvatar, opt => opt.MapFrom(opt => opt.User.Avatar))
                ;
            CreateMap<UpdateBookingDto, Booking>()
            .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
