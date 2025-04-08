namespace Monhealth.Application.Features.Booking.Commands.UpdateBooking
{
    public class UpdateBookingDto
    {
        public DateOnly Date { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public string? Notes { get; set; } = string.Empty;
        public string? CancellationReason { get; set; }
    }
}
