using AutoMapper;
using Monhealth.Application.Features.Activity.Commands.CreateActivity;
using Monhealth.Application.Features.Activity.Queries.GetActivityByUserId;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class ActivityProfile : Profile
    {
        public ActivityProfile()
        {
            CreateMap<Activity, GetActivityByUserIdDTO>().ReverseMap();
            CreateMap<Activity, CreateActivityDTO>().ReverseMap();
            CreateMap<DailyActivity, CreateActivityDTO>().ReverseMap();
        }
    }
}
