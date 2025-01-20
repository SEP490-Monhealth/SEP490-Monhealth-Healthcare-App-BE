using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Exercise.Commands.CreateExercise
{
    public class CreateExerciseCommand : IRequest<Unit>
    {
        public CreateExerciseDTO CreateExerciseDTO { get; set; }
        public CreateExerciseCommand(CreateExerciseDTO createExerciseDTO)
        {
            CreateExerciseDTO = createExerciseDTO;
        }
    }
}
