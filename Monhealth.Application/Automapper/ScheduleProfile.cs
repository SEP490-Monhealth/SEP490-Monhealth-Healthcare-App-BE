using AutoMapper;
using Monhealth.Application.Features.Schedule.Queries.GetAll;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class ScheduleProfile : Profile
    {
        public ScheduleProfile()
        {
            CreateMap<ScheduleDTO, Schedule>().ReverseMap();
        }


    }
}