namespace Monhealth.Application.Features.Schedule.Commands.Create
{
    public class CreateScheduleDto
    {
        public DateOnly? Date { get; set; }
        public TimeOnly? Time { get; set; }
    }
}
