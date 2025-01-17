using MediatR;

namespace Monhealth.Application.Features.Goals.Queries.GetExerciseByGoalId
{
    public class GetExerciseByGoalIdQuery : IRequest<GetExerciseByGoalIdDTO>
    {
        public Guid UserId { get; set; }
    }
}
