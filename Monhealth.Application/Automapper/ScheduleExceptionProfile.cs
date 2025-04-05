using AutoMapper;
using Monhealth.Application.Features.Schedule.Queries.GetByUser;
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

            CreateMap<ScheduleException, ScheduleExceptionDto>();
            CreateMap<ScheduleException, GetScheduleExceptionByConsultantIdDTO>().ReverseMap();
        }
    }
}
