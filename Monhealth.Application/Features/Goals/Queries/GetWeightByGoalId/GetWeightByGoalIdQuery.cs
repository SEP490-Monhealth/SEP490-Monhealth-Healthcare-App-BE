using MediatR;

namespace Monhealth.Application.Features.Goals.Queries.GetWeightByGoalId
{
    public class GetWeightByGoalIdQuery : IRequest<GetWeightByGoalIdDto>
    {
        public Guid GoalId { get; set; }
    }
}
