using AutoMapper;
using Monhealth.Application.Features.Report.Commands.CreateReport;
using Monhealth.Application.Features.Report.Commands.UpdateReport;
using Monhealth.Application.Features.Report.Queries.GetAllReports;
using Monhealth.Application.Features.Report.Queries.GetReportByBookingId;
using Monhealth.Application.Features.Report.Queries.GetReportByConsultantId;
using Monhealth.Application.Features.Report.Queries.GetReportById;
using Monhealth.Application.Features.Report.Queries.GetReportByUserId;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class ReportProfile : Profile
    {
        public ReportProfile()
        {
            CreateMap<Report, GetAllReportsDTO>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.Booking.User.Id))
                .ForMember(dest => dest.ConsultantId, opt => opt.MapFrom(src => src.Booking.Consultant.ConsultantId))
                .ForPath(dest => dest.Booking.Day, opt => opt.MapFrom(src => src.Booking.Day))
                .ForPath(dest => dest.Booking.StartTime, opt => opt.MapFrom(src => src.Booking.StartTime))
                .ForPath(dest => dest.Booking.EndTime, opt => opt.MapFrom(src => src.Booking.EndTime))
                .ForPath(dest => dest.Member.FullName, opt => opt.MapFrom(src => src.Booking.User.FullName))
                .ForPath(dest => dest.Member.Email, opt => opt.MapFrom(src => src.Booking.User.Email))
                .ForPath(dest => dest.Member.PhoneNumber, opt => opt.MapFrom(src => src.Booking.User.PhoneNumber))
                .ForPath(dest => dest.Member.Avatar, opt => opt.MapFrom(src => src.Booking.User.Avatar))
                .ForPath(dest => dest.Consultant.FullName, opt => opt.MapFrom(src => src.Booking.Consultant.AppUser.FullName))
                .ForPath(dest => dest.Consultant.Email, opt => opt.MapFrom(src => src.Booking.Consultant.AppUser.Email))
                .ForPath(dest => dest.Consultant.PhoneNumber, opt => opt.MapFrom(src => src.Booking.Consultant.AppUser.PhoneNumber))
                .ForPath(dest => dest.Consultant.Avatar, opt => opt.MapFrom(src => src.Booking.Consultant.AppUser.Avatar));

            CreateMap<Report, GetReportByIdDTO>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.Booking.User.Id))
                .ForMember(dest => dest.ConsultantId, opt => opt.MapFrom(src => src.Booking.Consultant.ConsultantId))
                .ForPath(dest => dest.Booking.Day, opt => opt.MapFrom(src => src.Booking.Day))
                .ForPath(dest => dest.Booking.StartTime, opt => opt.MapFrom(src => src.Booking.StartTime))
                .ForPath(dest => dest.Booking.EndTime, opt => opt.MapFrom(src => src.Booking.EndTime))
                .ForPath(dest => dest.Member.FullName, opt => opt.MapFrom(src => src.Booking.User.FullName))
                .ForPath(dest => dest.Member.Email, opt => opt.MapFrom(src => src.Booking.User.Email))
                .ForPath(dest => dest.Member.PhoneNumber, opt => opt.MapFrom(src => src.Booking.User.PhoneNumber))
                .ForPath(dest => dest.Member.Avatar, opt => opt.MapFrom(src => src.Booking.User.Avatar))
                .ForPath(dest => dest.Consultant.FullName, opt => opt.MapFrom(src => src.Booking.Consultant.AppUser.FullName))
                .ForPath(dest => dest.Consultant.Email, opt => opt.MapFrom(src => src.Booking.Consultant.AppUser.Email))
                .ForPath(dest => dest.Consultant.PhoneNumber, opt => opt.MapFrom(src => src.Booking.Consultant.AppUser.PhoneNumber))
                .ForPath(dest => dest.Consultant.Avatar, opt => opt.MapFrom(src => src.Booking.Consultant.AppUser.Avatar));

            CreateMap<Report, GetReportByBookingIdDTO>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.Booking.User.Id))
                .ForMember(dest => dest.ConsultantId, opt => opt.MapFrom(src => src.Booking.Consultant.ConsultantId))
                .ForPath(dest => dest.Booking.Day, opt => opt.MapFrom(src => src.Booking.Day))
                .ForPath(dest => dest.Booking.StartTime, opt => opt.MapFrom(src => src.Booking.StartTime))
                .ForPath(dest => dest.Booking.EndTime, opt => opt.MapFrom(src => src.Booking.EndTime))
                .ForPath(dest => dest.Member.FullName, opt => opt.MapFrom(src => src.Booking.User.FullName))
                .ForPath(dest => dest.Member.Email, opt => opt.MapFrom(src => src.Booking.User.Email))
                .ForPath(dest => dest.Member.PhoneNumber, opt => opt.MapFrom(src => src.Booking.User.PhoneNumber))
                .ForPath(dest => dest.Member.Avatar, opt => opt.MapFrom(src => src.Booking.User.Avatar))
                .ForPath(dest => dest.Consultant.FullName, opt => opt.MapFrom(src => src.Booking.Consultant.AppUser.FullName))
                .ForPath(dest => dest.Consultant.Email, opt => opt.MapFrom(src => src.Booking.Consultant.AppUser.Email))
                .ForPath(dest => dest.Consultant.PhoneNumber, opt => opt.MapFrom(src => src.Booking.Consultant.AppUser.PhoneNumber))
                .ForPath(dest => dest.Consultant.Avatar, opt => opt.MapFrom(src => src.Booking.Consultant.AppUser.Avatar));

            CreateMap<Report, GetReportByConsultantIdDTO>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.Booking.User.Id))
                .ForMember(dest => dest.ConsultantId, opt => opt.MapFrom(src => src.Booking.Consultant.ConsultantId))
                .ForPath(dest => dest.Booking.Day, opt => opt.MapFrom(src => src.Booking.Day))
                .ForPath(dest => dest.Booking.StartTime, opt => opt.MapFrom(src => src.Booking.StartTime))
                .ForPath(dest => dest.Booking.EndTime, opt => opt.MapFrom(src => src.Booking.EndTime))
                .ForPath(dest => dest.Member.FullName, opt => opt.MapFrom(src => src.Booking.User.FullName))
                .ForPath(dest => dest.Member.Email, opt => opt.MapFrom(src => src.Booking.User.Email))
                .ForPath(dest => dest.Member.PhoneNumber, opt => opt.MapFrom(src => src.Booking.User.PhoneNumber))
                .ForPath(dest => dest.Member.Avatar, opt => opt.MapFrom(src => src.Booking.User.Avatar))
                .ForPath(dest => dest.Consultant.FullName, opt => opt.MapFrom(src => src.Booking.Consultant.AppUser.FullName))
                .ForPath(dest => dest.Consultant.Email, opt => opt.MapFrom(src => src.Booking.Consultant.AppUser.Email))
                .ForPath(dest => dest.Consultant.PhoneNumber, opt => opt.MapFrom(src => src.Booking.Consultant.AppUser.PhoneNumber))
                .ForPath(dest => dest.Consultant.Avatar, opt => opt.MapFrom(src => src.Booking.Consultant.AppUser.Avatar));
            CreateMap<Report, GetReportByUserIdDTO>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.Booking.User.Id))
                .ForMember(dest => dest.ConsultantId, opt => opt.MapFrom(src => src.Booking.Consultant.ConsultantId))
                .ForPath(dest => dest.Booking.Day, opt => opt.MapFrom(src => src.Booking.Day))
                .ForPath(dest => dest.Booking.StartTime, opt => opt.MapFrom(src => src.Booking.StartTime))
                .ForPath(dest => dest.Booking.EndTime, opt => opt.MapFrom(src => src.Booking.EndTime))
                .ForPath(dest => dest.Member.FullName, opt => opt.MapFrom(src => src.Booking.User.FullName))
                .ForPath(dest => dest.Member.Email, opt => opt.MapFrom(src => src.Booking.User.Email))
                .ForPath(dest => dest.Member.PhoneNumber, opt => opt.MapFrom(src => src.Booking.User.PhoneNumber))
                .ForPath(dest => dest.Member.Avatar, opt => opt.MapFrom(src => src.Booking.User.Avatar))
                .ForPath(dest => dest.Consultant.FullName, opt => opt.MapFrom(src => src.Booking.Consultant.AppUser.FullName))
                .ForPath(dest => dest.Consultant.Email, opt => opt.MapFrom(src => src.Booking.Consultant.AppUser.Email))
                .ForPath(dest => dest.Consultant.PhoneNumber, opt => opt.MapFrom(src => src.Booking.Consultant.AppUser.PhoneNumber))
                .ForPath(dest => dest.Consultant.Avatar, opt => opt.MapFrom(src => src.Booking.Consultant.AppUser.Avatar));

            CreateMap<Report, CreateReportDTO>().ReverseMap();
            CreateMap<Report, UpdateReportDTO>().ReverseMap();
        }
    }
}
