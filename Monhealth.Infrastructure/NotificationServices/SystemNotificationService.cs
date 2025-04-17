using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Notification;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;

namespace Monhealth.Infrastructure.NotificationServices
{
    public class SystemNotificationService(INotificationService notificationService,
        ILogger<SystemNotificationService> logger,
        IConsultantRepository consultantRepository,
        IUserRepository userRepository
        ) : ISystemNotificationService
    {
        public async Task NotifyBookingUpdateAsync(Booking booking, CancellationToken cancellationToken)
        {
            // Thông báo cho consultant
            var consultant = await consultantRepository.GetConsultantByConsultantId((Guid)booking.ConsultantId);
            DateOnly scheduledDate = booking.Day;
            TimeOnly scheduledTime = booking.StartTime;
            DateTime scheduledDateTime = scheduledDate.ToDateTime(scheduledTime);
            string consultantTitle = "Lịch hẹn đã được hủy";
            string consultantContent = $"Lịch hẹn với {booking.User.FullName} vào lúc " +
                $"{scheduledDateTime.ToString("HH:mm dd/MM/yyyy")}" +
                $" đã bị hủy với lí do: {booking?.CancellationReason ?? string.Empty}";
            //string consultantActionUrl = $"/consultant/bookings/{booking.BookingId}";

            await notificationService.SendUserNotificationAsync(
                (Guid)consultant.UserId,
                consultantTitle,
                consultantContent,
                cancellationToken
            );

            // Thông báo cho member
            string memberTitle = "Bạn đã hủy lịch hẹn thành công";
            string memberContent = $"Lịch hẹn của bạn với consultant {consultant.AppUser.FullName}" +
                $" vào lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")} " +
                $"đã bị hủy với lí do: {booking?.CancellationReason ?? string.Empty}";
            string memberActionUrl = $"/member/bookings/{booking.BookingId}";

            await notificationService.SendUserNotificationAsync(
                (Guid)booking.UserId,
                memberTitle,
                memberContent,
                cancellationToken
            );

            logger.LogInformation($"Sent booking update notifications for booking: {booking.BookingId}");
        }


        public async Task NotifyNewBookingAsync(Booking booking, CancellationToken cancellationToken)
        {
            try
            {
                var consultant = await consultantRepository.GetConsultantByConsultantId((Guid)booking.ConsultantId);

                var member = await userRepository.GetUserByIdAsync((Guid)booking.UserId);

                if (consultant != null && member != null)
                {
                    // Thông báo cho consultant
                    DateOnly scheduledDate = booking.Day;
                    TimeOnly scheduledTime = booking.StartTime;
                    DateTime scheduledDateTime = scheduledDate.ToDateTime(scheduledTime);
                    string consultantTitle = "Bạn có một lịch hẹn mới";
                    string consultantContent = $"Bạn có một lịch hẹn mới từ {member.FullName} vào lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")}";
                    //string consultantActionUrl = $"/consultant/bookings/{booking.BookingId}";

                    await notificationService.SendUserNotificationAsync(
                        (Guid)consultant.UserId,
                        consultantTitle,
                        consultantContent,
                        cancellationToken
                    );

                    // Thông báo cho member
                    string memberTitle = "Đặt lịch hẹn thành công";
                    string memberContent = $"Bạn đã đặt lịch hẹn thành công với tư vấn viên {consultant.AppUser.FullName} vào lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")}";
                    // string memberActionUrl = $"/member/bookings/{booking.BookingId}";

                    await notificationService.SendUserNotificationAsync(
                        (Guid)booking.UserId,
                        memberTitle,
                        memberContent,
                        cancellationToken
                    );

                    logger.LogInformation($"Sent booking notifications for booking: {booking.BookingId}");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send notifications for new booking: {booking.BookingId}");
            }
        }

        public async Task NotifyNewConsultantRegistrationAsync(Consultant consultant, CancellationToken cancellationToken)
        {
            try
            {
                string title = "Chào mừng";
                string content = $"Chào {consultant.AppUser.FullName}, tài khoản của bạn đã được tạo thành công.";

                await notificationService.SendUserNotificationAsync(
                    (Guid)consultant.UserId,
                    title,
                    content,
                    cancellationToken
                );

                logger.LogInformation($"Sent welcome notification to new consultant: {consultant.ConsultantId}");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send notification to new consultant: {consultant.ConsultantId}");
            }
        }

        public Task NotifySubscriptionPurchaseAsync(Transaction transaction, Subscription subscription)
        {
            throw new NotImplementedException();
        }
    }
}
