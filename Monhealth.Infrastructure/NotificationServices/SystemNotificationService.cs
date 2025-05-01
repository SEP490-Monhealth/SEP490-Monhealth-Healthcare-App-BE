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
        IUserRepository userRepository,
        IBookingRepository bookingRepository
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
                    string consultantTitle = "Thông báo";
                    string consultantContent = $"Đã hoàn thành buổi tư vấn với {member.FullName} vào lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")}";

                    await notificationService.SendUserNotificationAsync(
                        (Guid)consultant.UserId,
                        consultantTitle,
                        consultantContent,
                        cancellationToken
                    );

                    // Thông báo cho member
                    string memberTitle = "Thông báo";
                    string memberContent = $"Đã hoàn thành buổi tư vấn với {consultant.AppUser.FullName} vào lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")}";

                    await notificationService.SendUserNotificationAsync(
                        (Guid)booking.UserId,
                        memberTitle,
                        memberContent,
                        cancellationToken
                    );

                    logger.LogInformation($"Sent booking completion notifications for booking: {booking.BookingId}");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send completion notifications for booking: {booking.BookingId}");
            }
        }

        public async Task NotifyBookingUpdateAsync(Booking booking, CancellationToken cancellationToken)
        {
            try
            {
                // Thông báo cho consultant
                var consultant = await consultantRepository.GetConsultantByConsultantId((Guid)booking.ConsultantId);
                DateOnly scheduledDate = booking.Day;
                TimeOnly scheduledTime = booking.StartTime;
                DateTime scheduledDateTime = scheduledDate.ToDateTime(scheduledTime);
                string consultantTitle = "Thông báo";
                string consultantContent = $"Lịch hẹn với khách hàng {booking.User.FullName} vào lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")} đã bị hủy";

                await notificationService.SendUserNotificationAsync(
                    (Guid)consultant.UserId,
                    consultantTitle,
                    consultantContent,
                    cancellationToken
                );

                // Thông báo cho member
                string memberTitle = "Thông báo";
                string memberContent = $"Lịch hẹn với chuyên viên {consultant.AppUser.FullName} vào lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")} đã bị hủy";

                await notificationService.SendUserNotificationAsync(
                    (Guid)booking.UserId,
                    memberTitle,
                    memberContent,
                    cancellationToken
                );

                logger.LogInformation($"Sent booking cancellation notifications for booking: {booking.BookingId}");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send cancellation notifications for booking: {booking.BookingId}");
            }
        }

        public async Task NotifyConsultantAboutNewReviewAsync(Review review, Booking booking, CancellationToken cancellationToken)
        {
            try
            {
                var consultant = await consultantRepository.GetConsultantByConsultantId((Guid)booking.ConsultantId);
                var user = await userRepository.GetUserByIdAsync((Guid)booking.UserId);

                DateOnly scheduledDate = booking.Day;
                TimeOnly scheduledTime = booking.StartTime;
                DateTime scheduledDateTime = scheduledDate.ToDateTime(scheduledTime);

                string ratingStars = new string('★', review.Rating) + new string('☆', 5 - review.Rating);
                string title = "Thông báo";
                string content = $"{user.FullName} đã đánh giá buổi tư vấn vào {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")} - {review.Rating}/5 sao";

                await notificationService.SendUserNotificationAsync(
                    (Guid)consultant.UserId,
                    title,
                    content,
                    cancellationToken
                );

                logger.LogInformation($"Sent notification to consultant for new reviews {consultant.UserId}");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send review notification for booking: {booking?.BookingId}");
            }
        }

        public async Task NotifyCreateMetricSuccessfully(Guid userId, CancellationToken cancellationToken)
        {
            try
            {
                var user = await userRepository.GetUserByIdAsync(userId);
                if (user != null)
                {
                    string title = "Chào mừng";
                    string content = $"Chào {user.FullName}, tài khoản của bạn đã được tạo thành công!";

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
                logger.LogError(ex, $"Failed to send welcome notification to new user: {userId}");
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
                    string consultantContent = $"Bạn có một lịch hẹn mới từ khách hàng {member.FullName} vào lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")}";

                    await notificationService.SendUserNotificationAsync(
                        (Guid)consultant.UserId,
                        consultantTitle,
                        consultantContent,
                        cancellationToken
                    );

                    // Thông báo cho member
                    string memberTitle = "Thông báo";
                    string memberContent = $"Đã đặt lịch hẹn thành công với chuyên viên {consultant.AppUser.FullName} vào lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")}";

                    await notificationService.SendUserNotificationAsync(
                        (Guid)booking.UserId,
                        memberTitle,
                        memberContent,
                        cancellationToken
                    );

                    logger.LogInformation($"Sent new booking notifications for booking: {booking.BookingId}");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send notifications for new booking: {booking.BookingId}");
            }

        }

        public async Task NotifyNewConsultantRegistrationAsync(Guid userId, CancellationToken cancellationToken)
        {
            try
            {
                var user = await userRepository.GetByIdAsync(userId);
                string title = "Chào mừng";
                string content = $"Chào {user?.FullName}, tài khoản chuyên viên của bạn đã được tạo thành công!";

                await notificationService.SendUserNotificationAsync(
                    userId,
                    title,
                    content,
                    cancellationToken
                );

                logger.LogInformation($"Sent welcome notification to new consultant: {user.FullName}");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send welcome notification to new consultant: {userId}");
            }
        }

        public async Task NotifyNewUserSessionAsync(AppUser user)
        {
            try
            {
                string title = "Chào mừng";
                string content = $"Chào {user.FullName}, rất vui khi thấy bạn quay lại với Monhealth!";

                await notificationService.SendUserNotificationWithoutSaveAsync(
                    user.Id,
                    title,
                    content
                );

                logger.LogInformation($"Sent welcome back notification to user: {user.Id}");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send welcome back notification to user: {user.Id}");
            }
        }

        public async Task NotifySubscriptionBuySingleBooking(Transaction transaction, CancellationToken cancellationToken)
        {
            try
            {
                string title = "Thông báo";
                string content = $"Bạn đã mua thành công một lượt đặt lịch tư vấn";

                await notificationService.SendUserNotificationAsync(
                    (Guid)transaction.UserId,
                    title,
                    content,
                    cancellationToken
                );

                logger.LogInformation($"Sent single booking purchase notification to user: {transaction.UserId}");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send single booking purchase notification to user: {transaction.UserId}");
            }
        }

        public async Task NotifySubscriptionPurchaseAsync(Transaction transaction, UserSubscription userSubscription, CancellationToken cancellationToken)
        {
            try
            {
                var user = await userRepository.GetUserByIdAsync((Guid)transaction.UserId);
                string title = "Thông báo";
                string content = $"Đã nâng cấp thành công lên gói {userSubscription?.Subscription?.SubscriptionName}";

                await notificationService.SendUserNotificationAsync(
                    (Guid)transaction.UserId,
                    title,
                    content,
                    cancellationToken
                );

                logger.LogInformation($"Sent subscription upgrade notification to user: {transaction.UserId}");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send subscription upgrade notification to user: {transaction.UserId}");
            }
        }

        public async Task NotifyUpComingBookingReminderAsync(Booking booking, CancellationToken cancellationToken)
        {
            try
            {
                var consultant = await consultantRepository.GetConsultantByConsultantId((Guid)booking.ConsultantId);
                var member = await userRepository.GetUserByIdAsync((Guid)booking.UserId);

                if (consultant != null && member != null)
                {
                    // Get the scheduled date and time
                    DateOnly scheduledDate = booking.Day;
                    TimeOnly scheduledTime = booking.StartTime;
                    DateTime scheduledDateTime = scheduledDate.ToDateTime(scheduledTime);

                    // Notification for consultant
                    string consultantTitle = "Nhắc nhở";
                    string consultantContent = $"Sắp đến lịch hẹn với khách hàng {member.FullName} vào lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")} (trong 30 phút nữa)";

                    await notificationService.SendUserNotificationAsync(
                        (Guid)consultant.UserId,
                        consultantTitle,
                        consultantContent,
                        cancellationToken
                    );

                    // Notification for member/user
                    string memberTitle = "Nhắc nhở";
                    string memberContent = $"Sắp đến lịch hẹn với chuyên viên {consultant.AppUser.FullName} vào lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")} (trong 30 phút nữa)";

                    await notificationService.SendUserNotificationAsync(
                        (Guid)booking.UserId,
                        memberTitle,
                        memberContent,
                        cancellationToken
                    );

                    logger.LogInformation($"Sent 30-minute reminder notifications for booking: {booking.BookingId}");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send 30-minute reminder notifications for booking: {booking.BookingId}");
            }
        }

        public async Task NotifyUserReportApprovedAsync(Report report, CancellationToken cancellation)
        {
            try
            {
                var booking = await bookingRepository.GetBookingByBookingIdAsync(report.BookingId);
                var user = await userRepository.GetUserByIdAsync((Guid)booking.UserId);
                var consultant = await consultantRepository.GetConsultantByConsultantId((Guid)booking.ConsultantId);

                if (user == null || consultant == null)
                {
                    logger.LogWarning($"Cannot send report approval notification: User or Consultant not found");
                    return;
                }

                string title = "Thông báo";
                string content = $"Báo cáo của bạn về chuyên viên {consultant.AppUser.FullName} đã được phê duyệt và xử lý";

                await notificationService.SendUserNotificationAsync(
                    user.Id,
                    title,
                    content,
                    cancellation
                );

                //notify consultant 
                string consultantTitle = "Cảnh báo";
                string consultantContent = $"Chúng tôi đã nhận được báo cáo từ khách hàng về dịch vụ tư vấn của bạn";

                await notificationService.SendUserNotificationAsync(
                    (Guid)consultant.UserId,
                    consultantTitle,
                    consultantContent,
                    cancellation
                );
                logger.LogInformation($"Sent report approval notification to report for booking {report.BookingId}");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send report approval notification to report for booking {report.BookingId}");
            }
        }

        public async Task NotifyUserReportRejectedAsync(Report report, CancellationToken cancellation)
        {
            try
            {
                var booking = await bookingRepository.GetBookingByBookingIdAsync(report.BookingId);
                var user = await userRepository.GetUserByIdAsync((Guid)booking.UserId);
                var consultant = await consultantRepository.GetConsultantByConsultantId((Guid)booking.ConsultantId);

                if (user == null || consultant == null)
                {
                    logger.LogWarning($"Cannot send report rejection notification: User or Consultant not found");
                    return;
                }

                string title = "Thông báo";
                string content = $"Báo cáo của bạn về chuyên viên {consultant.AppUser.FullName} đã được xem xét và không đủ cơ sở để xác minh";

                await notificationService.SendUserNotificationAsync(
                    user.Id,
                    title,
                    content,
                    cancellation
                );

                logger.LogInformation($"Sent report rejection notification to user for reportId {report.ReportId}");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send report rejection notification to user reportId{report.ReportId}");
            }
        }

        public async Task NotifyWaterReminderNotificationAsync(WaterReminder waterReminder, CancellationToken cancellationToken)
        {
            try
            {
                if (waterReminder.UserId != null)
                {
                    string title = "Nhắc nhở";
                    string content = $"Đã đến giờ uống nước! Hãy uống {waterReminder.Volume}ml nước ngay bây giờ";

                    await notificationService.SendUserNotificationAsync(
                        waterReminder.UserId.Value,
                        title,
                        content,
                        cancellationToken
                    );

                    logger.LogInformation($"Sent water reminder notification to user: {waterReminder.UserId}");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send water reminder notification to user: {waterReminder.UserId}");
            }
        }

        public async Task SendBookingCancellationNotificationAsync(Booking booking, CancellationToken cancellationToken)
        {
            try
            {
                var consultant = await consultantRepository.GetConsultantByConsultantId((Guid)booking.ConsultantId);
                var member = await userRepository.GetUserByIdAsync((Guid)booking.UserId);
                DateOnly scheduledDate = booking.Day;
                TimeOnly scheduledTime = booking.StartTime;
                DateTime scheduledDateTime = scheduledDate.ToDateTime(scheduledTime);

                if (consultant != null && member != null)
                {
                    // Thông báo cho consultant
                    string consultantTitle = "Thông báo";
                    string consultantContent = $"Lịch hẹn với khách hàng {member.FullName} vào lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")} đã bị hủy";

                    await notificationService.SendUserNotificationAsync(
                        (Guid)consultant.UserId,
                        consultantTitle,
                        consultantContent,
                        cancellationToken
                    );

                    // Thông báo cho member
                    string memberTitle = "Thông báo";
                    string memberContent = $"Lịch hẹn với chuyên viên {consultant.AppUser.FullName} vào lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")} đã bị hủy";

                    await notificationService.SendUserNotificationAsync(
                        (Guid)booking.UserId,
                        memberTitle,
                        memberContent,
                        cancellationToken
                    );

                    logger.LogInformation($"Sent cancellation notifications for report id: {booking.BookingId}");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send notifications for cancelled booking: {booking.BookingId}");
            }
        }

        public async Task SendRejectedScheduleExceptionForConsultant(Consultant consultant, CancellationToken cancellationToken)
        {
            try
            {
                if (consultant != null)
                {
                    // Thông báo cho consultant rằng yêu cầu nghỉ của họ bị từ chối
                    string consultantTitle = "Thông báo";
                    string consultantContent = $"Yêu cầu nghỉ phép của bạn đã bị từ chối do lịch làm việc hiện tại";

                    await notificationService.SendUserNotificationAsync(
                        (Guid)consultant.UserId,
                        consultantTitle,
                        consultantContent,
                        cancellationToken
                    );

                    logger.LogInformation($"Sent leave request denial notification for consultant: {consultant.ConsultantId}");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send leave request denial notification for consultant: {consultant.ConsultantId}");
            }
        }
    }
}