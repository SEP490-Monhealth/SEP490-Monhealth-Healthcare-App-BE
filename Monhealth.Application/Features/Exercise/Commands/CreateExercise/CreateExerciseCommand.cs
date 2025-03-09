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
