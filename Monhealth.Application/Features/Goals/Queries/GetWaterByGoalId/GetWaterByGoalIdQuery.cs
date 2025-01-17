using MediatR;

namespace Monhealth.Application.Features.Goals.Queries.GetWaterByGoalId
{
    public class GetWaterByGoalIdQuery : IRequest<GetWaterByGoalIdDTO>
    {
        public Guid UserId { get; set; }
    }
}
