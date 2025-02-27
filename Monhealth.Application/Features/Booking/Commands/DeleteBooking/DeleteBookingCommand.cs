using MediatR;

namespace Monhealth.Application.Features.Booking.Commands.DeleteBooking
{
    public class DeleteBookingCommand : IRequest<Unit>
    {
        public Guid BookingId { get; set; }
    }
}
