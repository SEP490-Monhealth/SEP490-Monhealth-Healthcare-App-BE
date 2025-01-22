using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Exercise.Commands.DeleteExercise
{
    public class DeleteExerciseCommandHandler : IRequestHandler<DeleteExerciseCommand, bool>
    {
        private readonly IExerciseRepository _exerciseRepository;
        public DeleteExerciseCommandHandler(IExerciseRepository exerciseRepository)
        {
            _exerciseRepository = exerciseRepository;
        }
        public async Task<bool> Handle(DeleteExerciseCommand request, CancellationToken cancellationToken)
        {
            var deleteExercise = await _exerciseRepository.GetByIdAsync(request.ExerciseId);
            if (deleteExercise == null)
            {
                return false;
            }
            _exerciseRepository.Remove(deleteExercise);
            await _exerciseRepository.SaveChangeAsync();
            return true;
        }
    }
}
