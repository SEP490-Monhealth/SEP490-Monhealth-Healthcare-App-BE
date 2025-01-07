using AutoMapper;
using Monhealth.Application.Features.Goals.Commands.CreateCommand;
using Monhealth.Application.Features.Goals.Commands.UpdateCommand;
using Monhealth.Application.Features.Goals.Queries.GetAllGoalQuery;
using Monhealth.Application.Features.Goals.Queries.GetGoalById;
using Monhealth.Application.Features.Goals.Queries.GetGoalByUserId;
using Monhealth.Application.Features.Metric.Commands.CreateMetric;
using Monhealth.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Automapper
{
    public class GoalProfile : Profile
    {
        public GoalProfile()
        {
            CreateMap<Goal, CreateGoalDTO>().ReverseMap();
            CreateMap<Goal, GetAllGoalsDTO>().ReverseMap();
            CreateMap<Goal, GetGoalByIdDTO>().ReverseMap();
            CreateMap<Goal, GetGoalByUserIdDTO>().ReverseMap();
            CreateMap<Goal, UpdateGoalDTO>().ReverseMap();
            CreateMap<Goal, CreateMetricDto>().ReverseMap();
        }
    }
}
