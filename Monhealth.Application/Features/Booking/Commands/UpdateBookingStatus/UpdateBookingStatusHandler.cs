using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Booking.Commands.UpdateBookingStatus
{
    public class UpdateBookingStatusHandler(IBookingRepository bookingRepository,
        IConsultantRepository consultantRepository,
        IUserSubscriptionRepository userSubscriptionRepository
        )
        : IRequestHandler<UpdateBookingStatusCommand, bool>
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
                //plus amout booking for consultant
                var consultant = await consultantRepository.GetByIdAsync((Guid)booking.ConsultantId);
                if (consultant != null)
                {
                    consultant.BookingCount += 1;
                }

                //subtract amout remaining booking
                var userSubscription = await userSubscriptionRepository.GetUserSubscriptionActiveOfUser((Guid)booking.UserId);
                if (userSubscription == null) throw new Exception("Không tìm thấy gói người dùng đã đăng kí");

                userSubscription.RemainingBookings -= 1;
                userSubscription.UpdatedAt = DateTime.Now;


                booking.CompletedAt = DateTime.Now;
                booking.Status = BookingStatus.Completed;

            }
            booking.UpdatedAt = DateTime.Now;
            await bookingRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
