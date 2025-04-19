using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Notification;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Models;

namespace Monhealth.Infrastructure.NotificationServices
{
    public class SystemNotificationService(INotificationService notificationService,
        ILogger<SystemNotificationService> logger,
        IConsultantRepository consultantRepository,
        IUserRepository userRepository
        ) : ISystemNotificationService
    {
        public async Task NotifyBookingCompleteForBoth(Booking booking, CancellationToken cancellationToken)
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
                    string consultantTitle = "Hoàn thành cuộc hẹn tư vấn";
                    string consultantContent = $"Bạn đã hoàn thành tư vấn cho {member.FullName}";
                    //string consultantActionUrl = $"/consultant/bookings/{booking.BookingId}";

                    await notificationService.SendUserNotificationAsync(
                        (Guid)consultant.UserId,
                        consultantTitle,
                        consultantContent,
                        cancellationToken
                    );

                    // Thông báo cho member
                    string memberTitle = "Hoàn thành cuộc hẹn tư vấn";
                    string memberContent = $"Bạn đã hoàn thành cuộc hẹn tư vấn với chuyên viên: {consultant.AppUser.FullName}";
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
                $" " +
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

        public async Task NotifyCreateMetricSuccessfully(Guid userId, CancellationToken cancellationToken)
        {
            try
            {
                var user = await userRepository.GetUserByIdAsync(userId);
                if (user != null)
                {
                    string title = "Chào mừng";
                    string content = $"Chào {user?.FullName} đã đến với hệ thống";

                    await notificationService.SendUserNotificationAsync(
                        user.Id,
                        title,
                        content,
                        cancellationToken
                    );
                }
                logger.LogInformation($"Sent welcome notification to new user: {userId}");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send notification to new user: {userId}");
            }
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
                    string consultantTitle = "Thông báo";
                    string consultantContent = $"Bạn có một lịch hẹn mới từ {member.FullName}";
                    //string consultantActionUrl = $"/consultant/bookings/{booking.BookingId}";

                    await notificationService.SendUserNotificationAsync(
                        (Guid)consultant.UserId,
                        consultantTitle,
                        consultantContent,
                        cancellationToken
                    );

                    // Thông báo cho member
                    string memberTitle = "Thông báo";
                    string memberContent = $"Bạn đã đặt lịch hẹn thành công với chuyên viên {consultant.AppUser.FullName}";
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
                string content = $"Chào {consultant?.AppUser?.FullName}, tài khoản của bạn đã được tạo thành công.";

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

        public async Task NotifyNewUserSessionAsync(AppUser user)
        {
            try
            {
                string title = "Chào mừng";
                string content = $"Chào {user.FullName}, hôm nay bạn thế nào? Chúng tôi rất vui khi bạn quay lại.";

                await notificationService.SendUserNotificationWithoutSaveAsync(
                    user.Id,
                    title,
                    content
                );

                logger.LogInformation($"Sent welcome notification to new user: {user.Id}");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send notification to new user: {user.Id}");
            }
        }

        public async Task NotifySubscriptionBuySingleBooking(Transaction transaction, CancellationToken cancellationToken)
        {
            try
            {
                string title = "Chào mừng mua lượt đặt lịch thành công";
                string content = $"Chúc mừng: {transaction?.UserSubscription?.User?.FullName}, " +
                    $"Bạn đã mua một lượt đặt lịch thành công";
                await notificationService.SendUserNotificationAsync(
                    (Guid)transaction.UserId,
                    title,
                    content,
                    cancellationToken
                    );
                logger.LogInformation($"Sent welcome notification to new user: {transaction.UserId}");

            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send notification to new user: {transaction.UserId}");

            }
        }

        public async Task NotifySubscriptionPurchaseAsync(Transaction transaction, UserSubscription userSubscription, CancellationToken cancellationToken)
        {
            try
            {
                var user = await userRepository.GetUserByIdAsync((Guid)transaction.UserId);
                string title = "Chào mừng nâng cấp gói thành công";
                string content = $"Chúc mừng: {user?.FullName}, " +
                    $"Bạn đã nâng cấp gói thành công gói: {userSubscription?.Subscription?.SubscriptionName}";

                await notificationService.SendUserNotificationAsync(
                    (Guid)transaction.UserId,
                    title,
                    content,
                    cancellationToken
                    );
                logger.LogInformation($"Sent welcome notification to new user: {transaction.UserId}");

            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send notification to new user: {transaction.UserId}");

            }
        }


    }
}
