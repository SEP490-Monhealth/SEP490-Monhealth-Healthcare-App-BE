using MediatR;

namespace Monhealth.Application.Features.Schedule.Commands.Create
{
    public class ScheduleRequest : IRequest<bool>
    {
        public Guid ConsultantId { get; set; } // FK 
        public DateOnly? Date { get; set; }
        public string StartTime { get; set; } = string.Empty;
        public string EndTime { get; set; } = string.Empty;
        public int MaxBookings { get; set; }
        public int BookedSlots { get; set; }
        public string Status { get; set; } = string.Empty;

    }
}