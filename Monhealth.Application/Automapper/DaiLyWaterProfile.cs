using AutoMapper;
using Monhealth.Application.Features.DaiLyWater.Queries.GetAllDaiLyWater;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class DaiLyWaterProfile : Profile
    {
        public DaiLyWaterProfile()
        {
            CreateMap<DailyWaterIntake, DailyWaterDTO>()
                .ForMember(dest => dest.GoalType, opt => opt.MapFrom(src => src.Goal.GoalType));
        }
    }
}