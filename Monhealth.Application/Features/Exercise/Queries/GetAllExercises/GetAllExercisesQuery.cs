using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Exercise.Queries.GetAllExercises
{
    public class GetAllExercisesQuery : IRequest<PageResult<GetAllExercisesDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public string? Search { get; set; }
        public bool? Popular { get; set; }
        public string? ExerciseType { get; set; }
        public GetAllExercisesQuery(int page, int limit, string? search, bool? popular, string? exerciseType)
        {
            Page = page; 
            Limit = limit; 
            Search = search; 
            Popular = popular; 
            ExerciseType = exerciseType;
        }
    }
}
