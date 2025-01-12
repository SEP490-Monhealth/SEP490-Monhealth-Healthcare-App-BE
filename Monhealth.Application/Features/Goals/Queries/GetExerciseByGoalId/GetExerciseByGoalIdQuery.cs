using MediatR;

namespace Monhealth.Application.Features.Goals.Queries.GetExerciseByGoalId
{
    public class GetExerciseByGoalIdQuery : IRequest<GetExerciseByGoalIdDto>
    {
        public Guid UserId { get; set; }
    }
}
