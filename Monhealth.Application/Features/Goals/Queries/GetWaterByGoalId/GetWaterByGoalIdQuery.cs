using MediatR;

namespace Monhealth.Application.Features.Goals.Queries.GetWaterByGoalId
{
    public class GetWaterByGoalIdQuery : IRequest<GetWaterByGoalIdDto>
    {
        public Guid GoalId { get; set; }
    }
}
