using MediatR;

namespace Monhealth.Application.Features.ScheduleException.Commands.UpdateApprovedStatus
{
    public class UpdateApprovedStatusCommand : IRequest<bool>
    {
        public Guid ScheduleExceptionId { get; set; }
    }
}
