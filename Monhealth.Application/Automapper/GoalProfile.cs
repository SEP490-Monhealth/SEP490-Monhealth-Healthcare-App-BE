using AutoMapper;
using Monhealth.Application.Features.Goals.Commands.CreateCommand;
using Monhealth.Application.Features.Goals.Queries.GetAllGoalQuery;
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
        }
    }
}
