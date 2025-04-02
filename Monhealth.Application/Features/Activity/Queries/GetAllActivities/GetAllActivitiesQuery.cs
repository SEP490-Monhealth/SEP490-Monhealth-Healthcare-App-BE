using MediatR;

namespace Monhealth.Application.Features.Activity.Queries.GetAllActivities
{
    public class GetAllActivitiesQuery : IRequest<List<GetAllActivitiesDTO>>
    {
    }
}
