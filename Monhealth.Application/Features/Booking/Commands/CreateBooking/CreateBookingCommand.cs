using MediatR;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Booking.Commands.CreateBooking
{
    public class CreateBookingCommand : IRequest<Unit>
    {
        public Guid? UserId { get; set; }
        public Guid? ConsultantId { get; set; }
        public DateTime Date { get; set; }
        public string? Notes { get; set; } = string.Empty;
        public BookingStatus? Status { get; set; } = BookingStatus.Pending;
    }
}
