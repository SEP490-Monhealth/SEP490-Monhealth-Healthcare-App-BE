﻿using AutoMapper;
using Monhealth.Application.Features.Goals.Commands.CreateCommand;
using Monhealth.Application.Features.Goals.Commands.UpdateCommand;
using Monhealth.Application.Features.Goals.Queries.GetAllGoalQuery;
using Monhealth.Application.Features.Goals.Queries.GetExerciseByGoalId;
using Monhealth.Application.Features.Goals.Queries.GetGoalById;
using Monhealth.Application.Features.Goals.Queries.GetGoalByUserId;
using Monhealth.Application.Features.Goals.Queries.GetNutritionByGoalId;
using Monhealth.Application.Features.Goals.Queries.GetWaterByGoalId;
using Monhealth.Application.Features.Goals.Queries.GetWeightByGoalId;
using Monhealth.Application.Features.Metric.Commands.CreateMetric;
using Monhealth.Application.Features.Metric.Commands.UpdateMetric;
using Monhealth.Domain;

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
            CreateMap<Goal, CreateMetricDTO>().ReverseMap();
            CreateMap<Goal, UpdateMetricDTO>().ReverseMap();
            CreateMap<Goal, GetWeightByGoalIdDTO>().ReverseMap();
            CreateMap<Goal, GetWaterByGoalIdDTO>().ReverseMap();
            CreateMap<Goal, GetNutritionByGoalIdDTO>().ReverseMap();
            CreateMap<Goal, GetExerciseByGoalIdDTO>().ReverseMap();

        }
    }
}
