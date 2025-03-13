using MediatR;

namespace Monhealth.Application.Features.ScheduleException.Commands.CreateScheduleException
{
    public class CreateScheduleExceptionCommand : IRequest<Unit>
    {
        public Guid? ScheduleId { get; set; }
        public DateOnly Date { get; set; }
        public string? Reason { get; set; }

    }
}
