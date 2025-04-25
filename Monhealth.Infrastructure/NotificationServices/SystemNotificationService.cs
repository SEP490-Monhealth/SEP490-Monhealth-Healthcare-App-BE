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
                    string consultantTitle = "Hoàn thành cuộc hẹn tư vấn";
                    string consultantContent = $"Bạn đã hoàn thành tư vấn cho khách hàng {member.FullName} vào lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")}";

                    await notificationService.SendUserNotificationAsync(
                        (Guid)consultant.UserId,
                        consultantTitle,
                        consultantContent,
                        cancellationToken
                    );

                    // Thông báo cho member
                    string memberTitle = "Hoàn thành cuộc hẹn tư vấn";
                    string memberContent = $"Bạn đã hoàn thành cuộc hẹn tư vấn với chuyên viên {consultant.AppUser.FullName} vào lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")}";

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
                string consultantTitle = "Thông báo hủy lịch hẹn";
                string consultantContent = $"Lịch hẹn với khách hàng {booking.User.FullName} vào lúc " +
                    $"{scheduledDateTime.ToString("HH:mm dd/MM/yyyy")}" +
                    $" đã bị hủy với lý do: {booking?.CancellationReason ?? "Không có lý do"}";

                await notificationService.SendUserNotificationAsync(
                    (Guid)consultant.UserId,
                    consultantTitle,
                    consultantContent,
                    cancellationToken
                );

                // Thông báo cho member
                string memberTitle = "Thông báo hủy lịch hẹn";
                string memberContent = $"Lịch hẹn của bạn với chuyên viên {consultant.AppUser.FullName} vào lúc " +
                    $"{scheduledDateTime.ToString("HH:mm dd/MM/yyyy")}" +
                    $" đã bị hủy với lý do: {booking?.CancellationReason ?? "Không có lý do"}";

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
                string title = "Nhận xét mới từ khách hàng";

                // Create notification content
                string content = $"Khách hàng {user.FullName} đã đánh giá buổi tư vấn của bạn vào {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")}.\n" +
                                 $"Đánh giá: {ratingStars} ({review.Rating}/5)\n";

                logger.LogInformation($"Sent welcome notification to consultant for new reviews {consultant.UserId}");
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
                    string title = "Chào mừng đến với Monhealth";
                    string content = $"Chào {user.FullName}, chúc mừng bạn đã tạo tài khoản thành công!";

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
                    string consultantTitle = "Thông báo lịch hẹn mới";
                    string consultantContent = $"Bạn có một lịch hẹn mới từ khách hàng {member.FullName} vào lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")}";

                    await notificationService.SendUserNotificationAsync(
                        (Guid)consultant.UserId,
                        consultantTitle,
                        consultantContent,
                        cancellationToken
                    );

                    // Thông báo cho member
                    string memberTitle = "Thông báo đặt lịch thành công";
                    string memberContent = $"Bạn đã đặt lịch hẹn thành công với chuyên viên {consultant.AppUser.FullName} vào lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")}";

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
                string title = "Chào mừng đến với Monhealth";
                string content = $"Chào {user?.FullName}, tài khoản chuyên viên tư vấn của bạn đã được tạo thành công!";

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
                string title = "Chào mừng quay trở lại";
                string content = $"Chào {user.FullName}, hôm nay bạn thế nào? Chúng tôi rất vui khi thấy bạn quay lại với Monhealth.";

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
                string title = "Mua lượt đặt lịch thành công";
                string content = $"Chúc mừng {transaction?.UserSubscription?.User?.FullName}! Bạn đã mua thành công một lượt đặt lịch tư vấn.";

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
                string title = "Nâng cấp gói thành công";
                string content = $"Chúc mừng {user?.FullName}! Bạn đã nâng cấp thành công lên gói {userSubscription?.Subscription?.SubscriptionName}.";

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
                    string consultantTitle = "Sắp đến lịch hẹn tư vấn";
                    string consultantContent = $"Nhắc nhở: Bạn có một lịch hẹn tư vấn với khách hàng {member.FullName}" +
                        $" vào lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")} (trong 30 phút nữa)";

                    await notificationService.SendUserNotificationAsync(
                        (Guid)consultant.UserId,
                        consultantTitle,
                        consultantContent,
                        cancellationToken
                    );

                    // Notification for member/user
                    string memberTitle = "Sắp đến lịch hẹn tư vấn";
                    string memberContent = $"Nhắc nhở: Bạn có một lịch hẹn tư vấn với chuyên viên {consultant.AppUser.FullName} vào lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")} (trong 30 phút nữa)";

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

                string title = "Báo cáo chuyên viên đã được phê duyệt";
                string content = $"Báo cáo của bạn về chuyên viên {consultant.AppUser.FullName} đã được xem xét và phê duyệt. " +
                                 $"Chúng tôi đã thực hiện các biện pháp cần thiết đối với chuyên viên. ";

                await notificationService.SendUserNotificationAsync(
                    user.Id,
                    title,
                    content,
                    cancellation
                );

                //notify consultant 
                string consultantTitle = "Thông báo về báo cáo từ khách hàng";
                string consultantContent = $"Chúng tôi đã nhận được báo cáo từ khách hàng về dịch vụ tư vấn của bạn. " +
                                 $"Sau khi xem xét, chúng tôi xác nhận rằng báo cáo này là có cơ sở. ";


                consultantContent += "Vui lòng liên hệ với quản trị viên để biết thêm chi tiết và các bước tiếp theo.";

                await notificationService.SendUserNotificationAsync(
                    (Guid)consultant.UserId,
                    title,
                    content,
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

                string title = "Kết quả báo cáo chuyên viên";
                string content = $"Báo cáo của bạn về chuyên viên {consultant.AppUser.FullName} đã được xem xét. " +
                                 $"Sau khi kiểm tra kỹ lưỡng, chúng tôi không tìm thấy đủ bằng chứng để xác minh các cáo buộc. ";

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

        public async Task SendBookingCancellationNotificationAsync(Booking booking, CancellationToken cancellationToken)
        {
            try
            {
                var consultant = await consultantRepository.GetConsultantByConsultantId((Guid)booking.ConsultantId);
                var member = await userRepository.GetUserByIdAsync((Guid)booking.UserId);
                DateOnly scheduledDate = booking.Day;
                TimeOnly scheduledTime = booking.StartTime;
                DateTime scheduledDateTime = scheduledDate.ToDateTime(scheduledTime);
                string cancellationReason = "Do một sự cố bất ngờ, lịch hẹn của bạn với chuyên viên không thể tiếp tục như dự định." +
                    " Chúng tôi xin lỗi về sự bất tiện này và sẽ sắp xếp lại lịch mới.";
                if (consultant != null && member != null)
                {
                    // Thông báo cho consultant
                    string consultantTitle = "Thông báo hủy lịch hẹn";
                    string consultantContent = $"Lịch hẹn của bạn với khách hàng {member.FullName} vào lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")} đã bị hủy. Lý do: {cancellationReason}.";

                    await notificationService.SendUserNotificationAsync(
                        (Guid)consultant.UserId,
                        consultantTitle,
                        consultantContent,
                        cancellationToken
                    );

                    // Thông báo cho member
                    string memberTitle = "Thông báo lịch hẹn bị hủy";
                    string memberContent = $"Lịch hẹn của bạn với chuyên viên {consultant.AppUser.FullName} vào lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")} đã bị hủy. Lý do: {cancellationReason}.";

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
                    string consultantTitle = "Thông báo về yêu cầu nghỉ phép";
                    string consultantContent = $"Yêu cầu nghỉ phép của bạn đã bị từ chối. " +
                        "Chúng tôi rất tiếc phải thông báo rằng bạn không thể nghỉ vào thời điểm này vì lịch làm việc cần có bạn. ";


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