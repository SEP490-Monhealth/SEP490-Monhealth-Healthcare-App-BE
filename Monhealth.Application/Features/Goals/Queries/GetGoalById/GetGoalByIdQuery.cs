using MediatR;

namespace Monhealth.Application.Features.Goals.Queries.GetGoalById
{
    public class GetGoalByIdQuery : IRequest<GetGoalByIdDTO>
    {
        public Guid GoalId { get; set; }
    }
}
