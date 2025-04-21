using MediatR;

namespace Monhealth.Application.Features.ScheduleException.Commands.UpdateExceptionRejectedStatus
{
    public class UpdateExceptionRejectedStatusCommand : IRequest<bool>
    {
        public Guid ScheduleExceptionId { get; set; }

    }
}
