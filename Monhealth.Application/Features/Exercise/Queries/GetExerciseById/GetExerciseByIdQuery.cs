using MediatR;

namespace Monhealth.Application.Features.Exercise.Queries.GetExerciseById
{
    public class GetExerciseByIdQuery : IRequest<GetExerciseByIdDTO>
    {
        public Guid ExerciseId { get; set; }
    }
}
