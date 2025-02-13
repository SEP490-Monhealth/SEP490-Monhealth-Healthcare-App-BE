using MediatR;

namespace Monhealth.Application.Features.Schedule.Commands.Update
{
    public class UpdateScheduleRequest : IRequest<bool>
    {
        public DateOnly? Date { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public int MaxBookings { get; set; }
        public int BookedSlots { get; set; }

    }
}