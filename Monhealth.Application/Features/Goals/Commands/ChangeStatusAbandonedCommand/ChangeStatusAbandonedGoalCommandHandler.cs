using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Goals.Commands.ChangeStatusCommand
{
    public class ChangeStatusAbandonedGoalCommandHandler : IRequestHandler<ChangeStatusAbandonedGoalCommand, bool>
    {
        private readonly IGoalRepository _goalRepository;
        public ChangeStatusAbandonedGoalCommandHandler(IGoalRepository goalRepository)
        {
            _goalRepository = goalRepository;
        }
        public async Task<bool> Handle(ChangeStatusAbandonedGoalCommand request, CancellationToken cancellationToken)
        {
            var goal = await _goalRepository.GetByIdAsync(request.GoalId);
            if(goal == null)
            {
                return false;
            }
            goal.Status = GoalStatus.Abandoned;
            _goalRepository.Update(goal);
            await _goalRepository.SaveChangeAsync();
            return true;
        }
    }
}
