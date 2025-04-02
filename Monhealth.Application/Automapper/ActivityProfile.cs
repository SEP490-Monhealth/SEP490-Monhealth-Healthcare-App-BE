using AutoMapper;
using Monhealth.Application.Features.Activity.Commands.CreateActivity;
using Monhealth.Application.Features.Activity.Queries.GetActivityByUserId;
using Monhealth.Application.Features.Activity.Queries.GetAllActivities;
using Monhealth.Application.Features.DailyActivity.Queries.GetDailyActivityByUserId;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class ActivityProfile : Profile
    {
        public ActivityProfile()
        {
            CreateMap<Activity, GetAllActivitiesDTO>()
                .ForMember(dest => dest.CaloriesBurned, opt => opt.MapFrom(src => src.Workout.CaloriesBurned))
                .ForMember(dest => dest.DurationMinutes, opt => opt.MapFrom(src => src.Workout.DurationMinutes));
            CreateMap<Activity, ActivityDTO>()
                .ForMember(dest => dest.CaloriesBurned, opt => opt.MapFrom(src => src.Workout.CaloriesBurned))
                .ForMember(dest => dest.DurationMinutes, opt => opt.MapFrom(src => src.Workout.DurationMinutes));

            CreateMap<Activity, GetActivityByUserIdDTO>()
                .ForMember(dest => dest.CaloriesBurned, opt => opt.MapFrom(src => src.Workout.CaloriesBurned))
                .ForMember(dest => dest.DurationMinutes, opt => opt.MapFrom(src => src.Workout.DurationMinutes));
            CreateMap<Activity, CreateActivityDTO>().ReverseMap();
            CreateMap<DailyActivity, CreateActivityDTO>().ReverseMap();
        }
    }
}
