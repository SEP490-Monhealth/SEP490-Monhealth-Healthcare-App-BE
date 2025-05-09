using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application
{
    public class GetActivityByIdQueryHandler(IActivityRepository activityRepository) : IRequestHandler<GetActivityByIdQuery, GetActivityByDTO>
    {

        public async Task<GetActivityByDTO> Handle(GetActivityByIdQuery request, CancellationToken cancellationToken)
        {
            var query = await activityRepository.GetActivitiesById(request.ActivityId);
            return new GetActivityByDTO
            {
                ActivityId = query.ActivityId,
                UserId = query.UserId,
                WorkoutId = query.WorkoutId,
                CaloriesBurned = query.Workout.CaloriesBurned,
                DurationMinutes = query.Workout.DurationMinutes,
                IsCompleted = query.IsCompleted,
                CreatedAt = query.CreatedAt,
                UpdatedAt = query.UpdatedAt,
            };
        }
    }
}