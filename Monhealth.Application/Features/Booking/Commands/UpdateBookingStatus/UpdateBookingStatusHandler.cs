using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Booking.Commands.UpdateBookingStatus
{
    public class UpdateBookingStatusHandler(IBookingRepository bookingRepository, IConsultantRepository consultantRepository) : IRequestHandler<UpdateBookingStatusCommand, bool>
    {
        public async Task<bool> Handle(UpdateBookingStatusCommand request, CancellationToken cancellationToken)
        {
            var booking = await bookingRepository.GetByIdAsync(request.BookingId);
            if (booking == null) throw new BadRequestException("Không tìm thấy lịch đã đặt");
            if (booking.Status == BookingStatus.Completed) throw new BadRequestException("Không thể cập nhập lịch đã hoàn thành");

            if (booking.Status == BookingStatus.Cancelled) throw new BadRequestException("Không thể cập nhập lịch đã hủy");

            if (booking.Status == BookingStatus.Pending)
            {
                booking.Status = BookingStatus.Confirmed;
            }
            else if (booking.Status == BookingStatus.Confirmed)
            {
                booking.Status = BookingStatus.Completed;
                var consultant = await consultantRepository.GetByIdAsync((Guid)booking.ConsultantId);
                if (consultant != null)
                {
                    consultant.BookingCount += 1;
                }
                booking.CompletedAt = DateTime.Now;
            }
            booking.UpdatedAt = DateTime.Now;
            await bookingRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
