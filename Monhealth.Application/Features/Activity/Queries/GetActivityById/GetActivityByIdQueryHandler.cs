using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application
{
    public class GetActivityByIdQueryHandler(IActivityRepository activityRepository) : IRequestHandler<GetActivityByIdQuery, GetActivityByDTO>
    {

        public async Task<GetActivityByDTO> Handle(GetActivityByIdQuery request, CancellationToken cancellationToken)
        {
            var query = await activityRepository.GetByIdAsync(request.ActivityId);
            return new GetActivityByDTO
            {
             ActivityId = query.ActivityId,
             CreatedAt = query.CreatedAt,
             UpdatedAt = query.UpdatedAt,
             DailyActivityId = query.DailyActivityId,
             WorkoutId = query.WorkoutId
            };
        }
    }
}