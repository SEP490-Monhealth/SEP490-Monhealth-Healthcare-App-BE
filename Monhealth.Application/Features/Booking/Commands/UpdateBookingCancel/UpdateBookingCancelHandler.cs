using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Booking.Commands.UpdateBookingCancel
{
    public class UpdateBookingCancelHandler(IBookingRepository bookingRepository) : IRequestHandler<UpdateBookingCancelCommand, bool>
    {
        public async Task<bool> Handle(UpdateBookingCancelCommand request, CancellationToken cancellationToken)
        {
            var booking = await bookingRepository.GetByIdAsync(request.BookingId);
            if (booking == null) throw new BadRequestException("Không tìm thấy lịch hẹn");
            if (booking.Status == BookingStatus.Cancelled) throw new BadRequestException("Không thể hủy lịch hẹn đã bị hủy");
            booking.Status = BookingStatus.Cancelled;
            await bookingRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
