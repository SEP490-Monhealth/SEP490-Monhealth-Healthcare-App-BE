using MediatR;

namespace Monhealth.Application.Features.Goals.Commands.DeleteCommand
{
    public class DeleteGoalCommand : IRequest<bool>
    {
        public Guid GoalId { get; set; }
    }
}
