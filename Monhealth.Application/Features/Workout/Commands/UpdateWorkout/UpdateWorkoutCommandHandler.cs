using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application
{
    public class UpdateWorkoutCommandHandler : IRequestHandler<UpdateWorkoutHandler, Unit>
    {
        private readonly IWorkoutRepository _workoutRepository;

        public UpdateWorkoutCommandHandler(IWorkoutRepository workoutRepository)
        {
            _workoutRepository = workoutRepository;
        }

        public async Task<Unit> Handle(UpdateWorkoutHandler request, CancellationToken cancellationToken)
        {
            var workout = await _workoutRepository.GetByIdAsync(request.WorkoutId);
            if (workout != null)
            {
                workout.CategoryId = request.Request.CategoryId;
                workout.WorkoutName = request.Request.WorkoutName;
                workout.WorkoutDescription = request.Request.WorkoutDescription;
                workout.DifficultyLevel = request.Request.DifficultyLevel;
                _workoutRepository.Update(workout);
                await _workoutRepository.SaveChangeAsync(cancellationToken);
            }
            return Unit.Value;
        }
    }
}