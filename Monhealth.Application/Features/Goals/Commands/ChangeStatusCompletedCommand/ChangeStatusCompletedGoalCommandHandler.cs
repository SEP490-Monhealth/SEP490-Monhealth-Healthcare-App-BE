using MediatR;
using Monhealth.Application.Contracts.Notification;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Goals.Commands.ChangeStatusCompletedCommand
{
    public class ChangeStatusCompletedGoalCommandHandler : IRequestHandler<ChangeStatusCompletedGoalCommand, bool>
    {
        private readonly IGoalRepository _goalRepository;
        private readonly ISystemNotificationService systemNotificationService;

        public ChangeStatusCompletedGoalCommandHandler(IGoalRepository goalRepository,
            ISystemNotificationService systemNotificationService
            )
        {
            _goalRepository = goalRepository;
            this.systemNotificationService = systemNotificationService;
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

            //Notify to user 
            await systemNotificationService.NotifyGoalCompletionAsync(goal, cancellationToken);
            return true;
        }
    }
}
