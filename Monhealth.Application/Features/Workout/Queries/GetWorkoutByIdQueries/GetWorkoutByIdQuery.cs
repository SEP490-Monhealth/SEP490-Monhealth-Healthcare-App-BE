using MediatR;
using Monhealth.Application.Features.Workout.Queries.GetAllWorkoutQueries;

namespace Monhealth.Application.Features.Workout.Queries.GetWorkoutByIdQueries
{
    public class GetWorkoutByIdQuery : IRequest<WorkoutDto>
    {
        public Guid WorkoutId { get; set; }
        public GetWorkoutByIdQuery(Guid workoutId)
        {
            WorkoutId = workoutId;
        }
    }
}
