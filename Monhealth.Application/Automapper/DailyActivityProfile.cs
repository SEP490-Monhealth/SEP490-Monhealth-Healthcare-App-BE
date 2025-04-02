using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Monhealth.Application.Features.DailyActivity.Queries.GetDailyActivityByUserId;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class DailyActivityProfile : Profile
    {
        public DailyActivityProfile()
        {
            CreateMap<DailyActivity, GetDailyActivityByUserIdDTO>()
                .ForMember(dest => dest.GoalType, opt => opt.MapFrom(src => src.Goal.GoalType));
        }
    }
}
