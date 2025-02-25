using MediatR;

namespace Monhealth.Application.Features.Schedule.Commands.UpdateScheduleStatus
{
    public class UpdateScheduleStatusCommand : IRequest<bool>
    {
        public Guid ScheduleId { get; set; }

    }
}
