using MediatR;

namespace Monhealth.Application.Features.Goals.Queries.GetGoalByUserId
{
    public class GetGoalByUserIdQuery : IRequest<List<GetGoalByUserIdDTO>>
    {
        public Guid UserId { get; set; }
    }
}
