using MediatR;

namespace Monhealth.Application.Features.Subscription.Queries.GetById
{
    public class GetDetailScheduleQuery : IRequest<ScheduleDetailDTO>
    {
        public Guid ScheduleId { get; set; }
    }
}