using MediatR;

namespace Monhealth.Application.Features.Booking.Commands.CreateBooking
{
    public class CreateBookingCommand : IRequest<Unit>
    {
        public Guid? UserId { get; set; }
        public Guid? ConsultantId { get; set; }
        public DateTime Day { get; set; }
        public string? Notes { get; set; } = string.Empty;
        public string? CancellationReason { get; set; }
    }
}
