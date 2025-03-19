using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Workout.Commands.ChangeStatusWorkout
{
    public class ChangeStatusWorkoutCommandHandler(IWorkoutRepository workoutRepository, IMapper mapper) : IRequestHandler<ChangeStatusWorkoutCommand, bool>
    {
        public async Task<bool> Handle(ChangeStatusWorkoutCommand request, CancellationToken cancellationToken)
        {
            var workout = await workoutRepository.GetByIdAsync(request.WorkoutId);
            if (workout == null)
            {
                return false;
            }
            workout.Status = !workout.Status;
            workoutRepository.Update(workout);
            await workoutRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
