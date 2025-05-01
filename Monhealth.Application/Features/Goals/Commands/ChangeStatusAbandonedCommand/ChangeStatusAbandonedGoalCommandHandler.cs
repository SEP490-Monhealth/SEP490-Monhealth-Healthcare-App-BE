using MediatR;
using Monhealth.Application.Contracts.Notification;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Goals.Commands.ChangeStatusCommand
{
    public class ChangeStatusAbandonedGoalCommandHandler : IRequestHandler<ChangeStatusAbandonedGoalCommand, bool>
    {
        private readonly IGoalRepository _goalRepository;
        private readonly ISystemNotificationService systemNotificationService;

        public ChangeStatusAbandonedGoalCommandHandler(IGoalRepository goalRepository,
            ISystemNotificationService systemNotificationService
            )
        {
            _goalRepository = goalRepository;
            this.systemNotificationService = systemNotificationService;
        }
        public async Task<bool> Handle(ChangeStatusAbandonedGoalCommand request, CancellationToken cancellationToken)
        {
            var goal = await _goalRepository.GetByIdAsync(request.GoalId);
            if (goal == null)
            {
                return false;
            }
            goal.Status = GoalStatus.Abandoned;
            _goalRepository.Update(goal);
            await _goalRepository.SaveChangeAsync();

            //Notify user
            await systemNotificationService.NotifyGoalAbandonedAsync(goal, cancellationToken);


            return true;

        }
    }
}
