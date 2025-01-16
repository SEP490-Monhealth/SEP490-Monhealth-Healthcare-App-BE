using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Monhealth.Application.Features.Exercise.Queries.GetAllExercises;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class ExerciseProfile : Profile
    {
        public ExerciseProfile()
        {
            CreateMap<Exercise, GetAllExercisesDTO>().ReverseMap();
        }
    }
}
