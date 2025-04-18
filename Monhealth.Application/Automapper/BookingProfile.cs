﻿using AutoMapper;
using Monhealth.Application.Features.Booking.Commands.CreateBooking;
using Monhealth.Application.Features.Booking.Commands.UpdateBooking;
using Monhealth.Application.Features.Booking.Queries.GetAllBookings;
using Monhealth.Application.Features.Booking.Queries.GetBookingByConsultantIdMonthly;
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
                .ForMember(dest => dest.Status, opt => opt.MapFrom(_ => BookingStatus.Pending));

            CreateMap<Booking, BookingDto>()
                .ForPath(dest => dest.Consultant.FullName, opt => opt.MapFrom(opt => opt.Consultant.AppUser.FullName))
                .ForPath(dest => dest.Consultant.Email, opt => opt.MapFrom(opt => opt.Consultant.AppUser.Email))
                .ForPath(dest => dest.Consultant.PhoneNumber, opt => opt.MapFrom(opt => opt.Consultant.AppUser.PhoneNumber))
                .ForPath(dest => dest.Consultant.AvatarUrl, opt => opt.MapFrom(opt => opt.Consultant.AppUser.Avatar))
                .ForPath(dest => dest.Member.FullName, opt => opt.MapFrom(opt => opt.User.FullName))
                .ForPath(dest => dest.Member.Email, opt => opt.MapFrom(opt => opt.User.Email))
                .ForPath(dest => dest.Member.PhoneNumber, opt => opt.MapFrom(opt => opt.User.PhoneNumber))
                .ForPath(dest => dest.Member.AvatarUrl, opt => opt.MapFrom(opt => opt.User.Avatar));

            CreateMap<Booking, GetBookingByConsultantIdMonthlyDTO>()
                .ForPath(dest => dest.Consultant.FullName, opt => opt.MapFrom(opt => opt.Consultant.AppUser.FullName))
                .ForPath(dest => dest.Consultant.Email, opt => opt.MapFrom(opt => opt.Consultant.AppUser.Email))
                .ForPath(dest => dest.Consultant.PhoneNumber, opt => opt.MapFrom(opt => opt.Consultant.AppUser.PhoneNumber))
                .ForPath(dest => dest.Consultant.AvatarUrl, opt => opt.MapFrom(opt => opt.Consultant.AppUser.Avatar))
                .ForPath(dest => dest.Member.FullName, opt => opt.MapFrom(opt => opt.User.FullName))
                .ForPath(dest => dest.Member.Email, opt => opt.MapFrom(opt => opt.User.Email))
                .ForPath(dest => dest.Member.PhoneNumber, opt => opt.MapFrom(opt => opt.User.PhoneNumber))
                .ForPath(dest => dest.Member.AvatarUrl, opt => opt.MapFrom(opt => opt.User.Avatar));

            CreateMap<UpdateBookingDto, Booking>()
            .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
