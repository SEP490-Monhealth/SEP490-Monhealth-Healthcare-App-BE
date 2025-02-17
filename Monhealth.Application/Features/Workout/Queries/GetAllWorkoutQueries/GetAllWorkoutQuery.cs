using MediatR;
using Monhealth.Application.Models;
using Monhealth.Core.Enum;

namespace Monhealth.Application.Features.Workout.Queries.GetAllWorkoutQueries
{
    public class GetAllWorkoutQuery : IRequest<PageResult<WorkoutDto>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public string CategoryName { get; set; }
        public string Search { get; set; }
        public DifficultyLevel? difficulty { get; set; }
        public bool? Popular { get; set; }
        public bool? Status { get; set; }

        public GetAllWorkoutQuery(int page, int limit, string categoryName, string search, DifficultyLevel? difficulty, bool? popular, bool? status)
        {
            Page = page;
            Limit = limit;
            CategoryName = categoryName;
            Search = search;
            this.difficulty = difficulty;
            Popular = popular;
            Status = status;
        }
    }
}
