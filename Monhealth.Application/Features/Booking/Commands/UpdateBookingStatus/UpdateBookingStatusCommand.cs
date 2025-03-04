using MediatR;

namespace Monhealth.Application.Features.Booking.Commands.UpdateBookingStatus
{
    public class UpdateBookingStatusCommand : IRequest<bool>
    {
        public Guid BookingId { get; set; }

    }
}
