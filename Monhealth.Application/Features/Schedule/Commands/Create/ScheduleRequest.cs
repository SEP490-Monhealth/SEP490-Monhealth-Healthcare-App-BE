using MediatR;

namespace Monhealth.Application.Features.Schedule.Commands.Create
{
    public class ScheduleRequest : IRequest<bool>
    {
        public Guid ConsultantId { get; set; } // FK 
        public DateOnly? Date { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public int MaxBookings { get; set; }
        public int BookedSlots { get; set; }

    }
}