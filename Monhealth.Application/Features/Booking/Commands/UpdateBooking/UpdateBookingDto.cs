namespace Monhealth.Application.Features.Booking.Commands.UpdateBooking
{
    public class UpdateBookingDto
    {
        public DateTime Date { get; set; }
        public string? Notes { get; set; } = string.Empty;

    }
}
