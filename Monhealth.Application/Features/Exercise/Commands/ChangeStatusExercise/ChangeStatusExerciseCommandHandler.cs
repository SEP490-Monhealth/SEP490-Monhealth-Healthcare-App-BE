using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Exercise.Commands.ChangeStatusExercise
{
    public class ChangeStatusExerciseCommandHandler : IRequestHandler<ChangeStatusExerciseCommand, bool>
    {
        private readonly IExerciseRepository _exerciseRepository;
        public ChangeStatusExerciseCommandHandler(IExerciseRepository exerciseRepository)
        {
            _exerciseRepository = exerciseRepository;
        }
        public async Task<bool> Handle(ChangeStatusExerciseCommand request, CancellationToken cancellationToken)
        {
            var exercise = await _exerciseRepository.GetByIdAsync(request.ExerciseId);
            if (exercise == null)
            {
                return false;
            }
            if(exercise.Status == false)
            {
                exercise.Status = true;
            } else
            {
                exercise.Status = false;
            }
            _exerciseRepository.Update(exercise);
            await _exerciseRepository.SaveChangeAsync();
            return true;
        }
    }
}
