using MediatR;

namespace Monhealth.Application
{
    public class GetActivityByIdQuery : IRequest<GetActivityByDTO>
    {
        public Guid ActivityId { get; set; }
        public GetActivityByIdQuery(Guid activityId)
        {
            ActivityId = activityId;
        }
    }
}