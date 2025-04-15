namespace Monhealth.Application.Features.ScheduleException.Commands.UpdateScheduleException
{
    public class UpdateScheduleExceptionDto
    {
        public DateOnly Date { get; set; }
        public string? Reason { get; set; }
    }
}
