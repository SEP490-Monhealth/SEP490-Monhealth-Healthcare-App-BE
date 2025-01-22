using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Exercise.Commands.UpdateExercise
{
    public class UpdateExerciseCommand : IRequest<bool>
    {
        public Guid ExerciseId { get; set; }
        public UpdateExerciseDTO UpdateExerciseDTO { get; set; }
        public UpdateExerciseCommand(Guid exerciseId, UpdateExerciseDTO updateExerciseDTO)
        {
            ExerciseId = exerciseId;
            UpdateExerciseDTO = updateExerciseDTO;
        }
    }
}
