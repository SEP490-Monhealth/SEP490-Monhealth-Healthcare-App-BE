using MediatR;
using Monhealth.Application.Features.Schedule.Queries.GetAll;

namespace Monhealth.Application.Features.Subscription.Queries.GetById
{
    public class GetDetailScheduleQuery : IRequest<ScheduleDTO>
    {
        public Guid ScheduleId { get; set; }
    }
}