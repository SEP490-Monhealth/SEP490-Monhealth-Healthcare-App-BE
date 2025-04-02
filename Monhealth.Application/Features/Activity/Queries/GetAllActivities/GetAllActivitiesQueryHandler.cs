using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Activity.Queries.GetAllActivities
{
    public class GetAllActivitiesQueryHandler(IActivityRepository activityRepository, IMapper mapper) : IRequestHandler<GetAllActivitiesQuery, List<GetAllActivitiesDTO>>
    {
        public async Task<List<GetAllActivitiesDTO>> Handle(GetAllActivitiesQuery request, CancellationToken cancellationToken)
        {
            var listActivities = await activityRepository.GetAllActivities();
            return mapper.Map<List<GetAllActivitiesDTO>>(listActivities);
        }
    }
}
