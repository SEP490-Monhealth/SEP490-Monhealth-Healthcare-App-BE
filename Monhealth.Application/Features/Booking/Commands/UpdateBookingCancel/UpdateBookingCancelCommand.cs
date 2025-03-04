using MediatR;

namespace Monhealth.Application.Features.Booking.Commands.UpdateBookingCancel
{
    public class UpdateBookingCancelCommand : IRequest<bool>
    {
        public Guid BookingId { get; set; }

    }
}
