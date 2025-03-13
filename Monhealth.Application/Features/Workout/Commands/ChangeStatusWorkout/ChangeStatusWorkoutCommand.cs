using MediatR;

namespace Monhealth.Application.Features.Workout.Commands.ChangeStatusWorkout
{
    public class ChangeStatusWorkoutCommand : IRequest<bool>
    {
        public Guid WorkoutId { get; set; }
    }
}
