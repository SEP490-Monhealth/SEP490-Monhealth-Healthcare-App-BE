using AutoMapper;
using Monhealth.Application.Features.ScheduleException.Commands.CreateScheduleException;
using Monhealth.Application.Features.ScheduleException.Queries.GetAllScheduleException;
using Monhealth.Application.Features.ScheduleException.Queries.GetScheduleExceptionByConsultantId;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class ScheduleExceptionProfile : Profile
    {
        public ScheduleExceptionProfile()
        {
            CreateMap<CreateScheduleExceptionCommand, ScheduleException>()
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => DateTime.Now));


            CreateMap<Consultant, ConsultantForGetAllScheduleExceptionDTO>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(opt => opt.AppUser.FullName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(opt => opt.AppUser.Email))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(opt => opt.AppUser.PhoneNumber))
                .ForMember(dest => dest.Avatar, opt => opt.MapFrom(opt => opt.AppUser.Avatar));
            CreateMap<ScheduleException, ScheduleExceptionDto>()
                .ForMember(dest => dest.ScheduleExceptionId, opt => opt.MapFrom(opt => opt.ScheduleExceptionId))
                .ForMember(dest => dest.ConsultantId, opt => opt.MapFrom(opt => opt.ConsultantId))
                .ForMember(dest => dest.Date, opt => opt.MapFrom(opt => opt.Date))
                .ForMember(dest => dest.Reason, opt => opt.MapFrom(opt => opt.Reason))
                .ForMember(dest => dest.Consultant, opt => opt.MapFrom(opt => opt.Consultant));
            CreateMap<ScheduleException, GetScheduleExceptionByConsultantIdDTO>().ReverseMap();
        }
    }
}
