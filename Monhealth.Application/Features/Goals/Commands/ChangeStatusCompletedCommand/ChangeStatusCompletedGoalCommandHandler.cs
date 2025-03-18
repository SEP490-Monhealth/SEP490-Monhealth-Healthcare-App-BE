using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Goals.Commands.ChangeStatusCompletedCommand
{
    public class ChangeStatusCompletedGoalCommandHandler : IRequestHandler<ChangeStatusCompletedGoalCommand, bool>
    {
        private readonly IGoalRepository _goalRepository;
        public ChangeStatusCompletedGoalCommandHandler(IGoalRepository goalRepository)
        {
            _goalRepository = goalRepository;
        }
        public async Task<bool> Handle(ChangeStatusCompletedGoalCommand request, CancellationToken cancellationToken)
        {
            var goal = await _goalRepository.GetByIdAsync(request.GoalId);
            if (goal == null)
            {
                return false;
            }
            goal.Status = GoalStatus.Completed;
            _goalRepository.Update(goal);
            await _goalRepository.SaveChangeAsync();
            return true;
        }
    }
}
