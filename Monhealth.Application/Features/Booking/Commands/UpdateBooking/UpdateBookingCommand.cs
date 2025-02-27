using MediatR;

namespace Monhealth.Application.Features.Booking.Commands.UpdateBooking
{
    public class UpdateBookingCommand : IRequest<Unit>
    {
        public Guid BookingId { get; set; }
        public UpdateBookingDto UpdateBookingDto { get; set; }

        public UpdateBookingCommand(Guid bookingId, UpdateBookingDto updateBookingDto)
        {
            BookingId = bookingId;
            UpdateBookingDto = updateBookingDto;
        }
    }
}
