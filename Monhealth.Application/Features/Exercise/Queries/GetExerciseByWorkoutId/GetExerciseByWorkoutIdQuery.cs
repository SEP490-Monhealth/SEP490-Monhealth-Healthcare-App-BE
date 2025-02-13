using MediatR;

namespace Monhealth.Application.Features.Exercise.Queries.GetExerciseByWorkoutId
{
    public class GetExerciseByWorkoutIdQuery : IRequest<GetExerciseByWorkoutIdDto>
    {
        public Guid WorkoutId { get; set; }
    }
}
