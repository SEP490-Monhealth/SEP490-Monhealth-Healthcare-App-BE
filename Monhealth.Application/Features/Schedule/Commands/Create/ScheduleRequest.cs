using MediatR;

namespace Monhealth.Application.Features.Schedule.Commands.Create
{
    public class ScheduleRequest : IRequest<bool>
    {
        public Guid ConsultantId { get; set; } // FK 
        public DateOnly? Date { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int MaxBookings { get; set; }
        public int BookedSlots { get; set; }

    }
}