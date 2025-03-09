using MediatR;

namespace Monhealth.Application.Features.Exercise.Commands.DeleteExercise
{
    public class DeleteExerciseCommand : IRequest<bool>
    {
        public Guid ExerciseId { get; set; }
    }
}
