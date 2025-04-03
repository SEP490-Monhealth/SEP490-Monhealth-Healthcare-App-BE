using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Activity.Commands.ChangeIsCompletedActivity
{
    public class ChangeIsCompletedActivityCommandHandler(IActivityRepository activityRepository) : IRequestHandler<ChangeIsCompletedActivityCommand, bool>
    {
        public async Task<bool> Handle(ChangeIsCompletedActivityCommand request, CancellationToken cancellationToken)
        {
            var activity = await activityRepository.GetByIdAsync(request.ActivityId);
            if (activity == null)
            {
                return false;
            }
            activity.IsCompleted = true;
            activityRepository.Update(activity);
            await activityRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
