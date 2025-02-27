using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.Booking.Commands.DeleteBooking
{
    public class DeleteBookingCommandHandler(IBookingRepository bookingRepository) : IRequestHandler<DeleteBookingCommand>
    {
        public async Task<Unit> Handle(DeleteBookingCommand request, CancellationToken cancellationToken)
        {
            var booking = await bookingRepository.GetByIdAsync(request.BookingId);
            if (booking == null) throw new BadRequestException("Không tìm thấy lịch hẹn");
            bookingRepository.Remove(booking);
            await bookingRepository.SaveChangeAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
