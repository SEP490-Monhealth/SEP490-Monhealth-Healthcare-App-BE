using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Activity.Queries.GetActivityByUserId
{
    public class GetActivityByUserIdQueryHandler(IActivityRepository activityRepository, IMapper mapper) : IRequestHandler<GetActivityByUserIdQuery, List<GetActivityByUserIdDTO>>
    {
        public async Task<List<GetActivityByUserIdDTO>> Handle(GetActivityByUserIdQuery request, CancellationToken cancellationToken)
        {
            var listActivities = await activityRepository.GetActivitiesByUserId(request.UserId);
            return mapper.Map<List<GetActivityByUserIdDTO>>(listActivities);
        }
    }
}
