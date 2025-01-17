using MediatR;

namespace Monhealth.Application.Features.Goals.Queries.GetWeightByGoalId
{
    public class GetWeightByGoalIdQuery : IRequest<GetWeightByGoalIdDTO>
    {
        public Guid UserId { get; set; }
    }
}
