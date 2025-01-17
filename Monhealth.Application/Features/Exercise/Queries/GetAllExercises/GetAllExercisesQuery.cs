using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Exercise.Queries.GetAllExercises
{
    public class GetAllExercisesQuery : IRequest<PageResult<GetAllExercisesDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public string? ExerciseType { get; set; }
        public string? Search { get; set; }
        public bool? Popular { get; set; }
        public GetAllExercisesQuery(int page, int limit, string? exerciseType, string? search, bool? popular)
        {
            Page = page;
            Limit = limit;
            ExerciseType = exerciseType;
            Search = search;
            Popular = popular;
        }
    }
}
