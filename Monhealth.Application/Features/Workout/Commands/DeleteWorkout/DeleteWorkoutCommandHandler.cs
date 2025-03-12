using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Workout.Commands.DeleteWorkout
{
    public class DeleteWorkoutCommandHandler(IWorkoutRepository workoutRepository, IMapper mapper) : IRequestHandler<DeleteWorkoutCommand, bool>
    {
        public async Task<bool> Handle(DeleteWorkoutCommand request, CancellationToken cancellationToken)
        {
            var workout = await workoutRepository.GetByIdAsync(request.WorkoutId);
            if (workout == null)
            {
                return false;
            }
            workoutRepository.Remove(workout);
            await workoutRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
