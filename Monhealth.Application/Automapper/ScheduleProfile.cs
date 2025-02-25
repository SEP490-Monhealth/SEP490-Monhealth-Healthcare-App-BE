using AutoMapper;
using Monhealth.Application.Features.Schedule.Commands.Create;
using Monhealth.Application.Features.Schedule.Queries.GetAll;
using Monhealth.Application.Features.Schedule.Queries.GetByUser;
using Monhealth.Application.Features.Subscription.Queries.GetById;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class ScheduleProfile : Profile
    {
        public ScheduleProfile()
        {
            CreateMap<ScheduleDTO, Schedule>().ReverseMap();
            CreateMap<ScheduleDetailDTO, Schedule>()
              .ReverseMap();

            CreateMap<GetScheduleByUserDTO, Schedule>().ReverseMap();
            CreateMap<ScheduleRequest, Schedule>();
        }


    }
}