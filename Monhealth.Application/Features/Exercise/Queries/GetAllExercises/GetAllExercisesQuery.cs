using MediatR;
using Monhealth.Application.Models;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Exercise.Queries.GetAllExercises
{
    public class GetAllExercisesQuery : IRequest<PageResult<GetAllExercisesDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public ExerciseType ExerciseType { get; set; }
        public string? Search { get; set; }
        public bool? Status { get; set; }
        public GetAllExercisesQuery(int page, int limit, ExerciseType exerciseType, string? search, bool? status)
        {
            Page = page;
            Limit = limit;
            ExerciseType = exerciseType;
            Search = search;
            Status = status;
        }
    }
}
