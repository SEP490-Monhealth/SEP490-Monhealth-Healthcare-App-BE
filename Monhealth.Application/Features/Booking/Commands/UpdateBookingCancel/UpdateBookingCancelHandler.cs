using MediatR;
using Monhealth.Application.Contracts.Notification;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Booking.Commands.UpdateBookingCancel
{
    public class UpdateBookingCancelHandler(IBookingRepository bookingRepository,
        IConsultantRepository consultantRepository,
        IUserSubscriptionRepository userSubscriptionRepository,
        ISystemNotificationService systemNotificationService
        ) : IRequestHandler<UpdateBookingCancelCommand, bool>
    {
        public async Task<bool> Handle(UpdateBookingCancelCommand request, CancellationToken cancellationToken)
        {
            var booking = await bookingRepository.GetBookingByBookingIdAsync(request.BookingId);
            if (booking == null) throw new BadRequestException("Không tìm thấy lịch hẹn");
            if (booking.Status == BookingStatus.Cancelled) throw new BadRequestException("Không thể hủy lịch hẹn đã bị hủy");
            if (booking.Status == BookingStatus.Completed) throw new BadRequestException("Không thể hủy lịch hẹn đã hoàn thành");

            booking.Status = BookingStatus.Cancelled;
            booking.CancellationReason = request.CancellationReason;
            booking.UpdatedAt = GetCurrentVietnamTime();
            bookingRepository.Update(booking);

            //subtract amout booking for consultant
            var consultant = await consultantRepository.GetByIdAsync((Guid)booking.ConsultantId);
            if (consultant != null)
            {
                consultant.BookingCount -= 1;
            }

            //plus amout remaining booking
            var userSubscription = await userSubscriptionRepository.GetUserSubscriptionActiveOfUser((Guid)booking.UserId);
            if (userSubscription == null) throw new Exception("Không tìm thấy gói người dùng đã đăng kí");

            userSubscription.RemainingBookings += 1;
            userSubscription.UpdatedAt = DateTime.Now;

            //Notify success update for user and consultant
            await systemNotificationService.NotifyBookingUpdateAsync(booking, cancellationToken);

            await bookingRepository.SaveChangeAsync(cancellationToken);
            return true;

        }
        private DateTime GetCurrentVietnamTime()
        {
            DateTime utcNow = DateTime.UtcNow;
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // Vietnam Time Zone
            return TimeZoneInfo.ConvertTimeFromUtc(utcNow, vietnamTimeZone);
        }
    }
}
