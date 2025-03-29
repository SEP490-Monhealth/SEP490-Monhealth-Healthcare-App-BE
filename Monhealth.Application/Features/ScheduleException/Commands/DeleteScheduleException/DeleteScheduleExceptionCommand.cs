using MediatR;

namespace Monhealth.Application.Features.ScheduleException.Commands.DeleteScheduleException
{
    public class DeleteScheduleExceptionCommand : IRequest<bool>
    {
        public Guid ScheduleExceptionId { get; set; }
    }
}
