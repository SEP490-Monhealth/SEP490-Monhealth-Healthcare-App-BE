using MediatR;

namespace Monhealth.Application.Features.Goals.Commands.ChangeStatusCommand
{
    public class ChangeStatusAbandonedGoalCommand : IRequest<bool>
    {
        public Guid GoalId { get; set; }
    }
}
