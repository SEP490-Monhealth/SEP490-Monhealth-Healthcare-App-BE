using MediatR;

namespace Monhealth.Application.Features.Booking.Commands.UpdateBookingCancel
{
    public class UpdateBookingCancelCommand : IRequest<bool>
    {
        public Guid BookingId { get; set; }
        public string? CancellationReason { get; set; }
        public UpdateBookingCancelCommand(Guid bookingId ,UpdateBookingCancelDTO request)
        {
            BookingId = bookingId;
            CancellationReason = request.CancellationReason ;
        }
    }
}
