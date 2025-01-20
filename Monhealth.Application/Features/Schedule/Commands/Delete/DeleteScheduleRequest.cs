using MediatR;

namespace Monhealth.Application.Features.Schedule.Commands.Delete
{
    public class DeleteScheduleRequest : IRequest<bool>
    {
        public Guid ScheduleId { get; set; }
        public DeleteScheduleRequest(Guid scheduleId)
        {
            ScheduleId = scheduleId;
        }

    }
}