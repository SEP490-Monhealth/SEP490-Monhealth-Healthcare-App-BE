using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Activity.Commands.ChangeIsCompletedActivity
{
    public class ChangeIsCompletedActivityCommandHandler(IActivityRepository activityRepository,
    IDailyActivityRepository dailyActivityRepository) : IRequestHandler<ChangeIsCompletedActivityCommand, bool>
    {
        public async Task<bool> Handle(ChangeIsCompletedActivityCommand request, CancellationToken cancellationToken)
        {
            var today = DateTime.Today;
            var activity = await activityRepository.GetActivitiesById(request.ActivityId);
            if (activity == null)
            {
                return false;
            }
            activity.IsCompleted = !activity.IsCompleted;
            activityRepository.Update(activity);
            var userOfActivity = activity.UserId;
           
            var dailyActivity = await dailyActivityRepository.GetDailyActivityByUserIdAndCreateAt((Guid)userOfActivity, today);
            if (activity.IsCompleted == true)
            {
                dailyActivity.TotalCaloriesBurned += activity.Workout?.CaloriesBurned ?? 0;
                dailyActivity.TotalDurationMinutes += activity.Workout?.DurationMinutes ?? 0;
            }
            else
            {
                dailyActivity.TotalCaloriesBurned -= activity.Workout?.CaloriesBurned ?? 0;
                dailyActivity.TotalDurationMinutes -= activity.Workout?.DurationMinutes ?? 0;
            }
            dailyActivity.UpdatedAt = DateTime.UtcNow;
            dailyActivityRepository.Update(dailyActivity);
            await activityRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
