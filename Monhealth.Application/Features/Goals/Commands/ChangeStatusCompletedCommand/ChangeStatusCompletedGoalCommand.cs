using MediatR;

namespace Monhealth.Application.Features.Goals.Commands.ChangeStatusCompletedCommand
{
    public class ChangeStatusCompletedGoalCommand : IRequest<bool>
    {
        public Guid GoalId { get; set; }
    }
}
