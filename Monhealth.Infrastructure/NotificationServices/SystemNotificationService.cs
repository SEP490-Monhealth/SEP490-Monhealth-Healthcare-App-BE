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
                    string consultantContent = $"Hoàn tất tư vấn với {member.FullName} lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")}";

                    await notificationService.SendUserNotificationAsync(
                        (Guid)consultant.UserId,
                        consultantTitle,
                        consultantContent,
                        cancellationToken
                    );

                    // Thông báo cho member
                    string memberTitle = "Thông báo";
                    string memberContent = $"Hoàn tất tư vấn với {consultant.AppUser.FullName} lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")}";

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
                string consultantContent = $"Đã hủy lịch hẹn với {booking.User.FullName} lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")}";

                await notificationService.SendUserNotificationAsync(
                    (Guid)consultant.UserId,
                    consultantTitle,
                    consultantContent,
                    cancellationToken
                );

                // Thông báo cho member
                string memberTitle = "Thông báo";
                string memberContent = $"Đã hủy lịch hẹn với {consultant.AppUser.FullName} lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")}";

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
                var consultant = await consultantRepository
                    .GetConsultantByConsultantId((Guid)booking.ConsultantId);
                var user = await userRepository
                    .GetUserByIdAsync((Guid)booking.UserId);

                var scheduledDateTime = booking.Day
                    .ToDateTime(booking.StartTime);

                var ratingStars = new string('★', review.Rating)
                                + new string('☆', 5 - review.Rating);

                // --- 1) Thông báo cho Consultant ---
                var consultantTitle = "Bạn có đánh giá mới";
                var consultantContent = string.Format(
                    "{0} đã đánh giá buổi tư vấn ngày {1} với {2} ({3}/5)",
                    user.FullName,
                    scheduledDateTime.ToString("HH:mm dd/MM/yyyy"),
                    ratingStars,
                    review.Rating
                );
                await notificationService.SendUserNotificationAsync(
                    (Guid)consultant.UserId,
                    consultantTitle,
                    consultantContent,
                    cancellationToken
                );

                // --- 2) Xác nhận cho Reviewer (user) ---
                var reviewerTitle = "Cảm ơn bạn đã đánh giá";
                var reviewerContent = string.Format(
                    "Cảm ơn {0} đã đánh giá buổi tư vấn với {1} ngày {2} với {3} ({4}/5)",
                    user.FullName,
                    consultant.AppUser.FullName,
                    scheduledDateTime.ToString("HH:mm dd/MM/yyyy"),
                    ratingStars,
                    review.Rating
                );
                await notificationService.SendUserNotificationAsync(
                    user.Id,
                    reviewerTitle,
                    reviewerContent,
                    cancellationToken
                );

                logger.LogInformation(
                    "Sent review notifications: consultant={ConsultantId}, reviewer={UserId}",
                    consultant.UserId, user.Id
                );
            }
            catch (Exception ex)
            {
                logger.LogError(
                    ex,
                    "Failed to send review notification for booking {BookingId}",
                    booking?.BookingId
                );
            }
        }

        public async Task NotifyConsultantOnExceptionCreatedAsync(Guid consultantId, ScheduleException scheduleException, CancellationToken cancellationToken)
        {
            try
            {
                var consultant = await consultantRepository
                    .GetConsultantByConsultantId(consultantId);

                string title = "Lịch bận đã được tạo";
                string content = $"Bạn đã tạo lịch bận cho ngày " +
                                 $"{scheduleException.Date:dd/MM/yyyy} thành công.";

                await notificationService.SendUserNotificationAsync(
                    (Guid)consultant.UserId,
                    title,
                    content,
                    cancellationToken
                );

                logger.LogInformation(
                    "Notified consultant {ConsultantId} of exception on {Date}",
                    consultantId, scheduleException.Date);
            }
            catch (Exception ex)
            {
                logger.LogError(
                    ex,
                    "Failed to notify consultant {ConsultantId} for exception on {Date}",
                    consultantId, scheduleException.Date);
            }
        }

        public async Task NotifyConsultantRejectionAsync(Consultant consultant, CancellationToken cancellationToken)
        {
            try
            {
                // Tạo nội dung thông báo
                string consultantTitle = "Thông báo";
                string consultantContent = $"Đơn đăng ký trở thành chuyên viên tư vấn của bạn đã bị từ chối";

                // Gửi thông báo trong hệ thống
                await notificationService.SendUserNotificationAsync(
                    (Guid)consultant.UserId,
                    consultantTitle,
                    consultantContent,
                    cancellationToken
                );
                logger.LogInformation($"Sent rejection notification to consultant applicant: {consultant.ConsultantId}");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send rejection notification to consultant applicant: {consultant.ConsultantId}");
            }
        }

        public async Task NotifyConsultantStatusUpdateAsync(Consultant consultant, CancellationToken cancellationToken)
        {
            try
            {
                // Thông báo cho consultant về việc trạng thái đã được cập nhật
                string consultantTitle = "Cập nhật";
                string consultantContent = $"Đã cập nhật trạng thái thành công";

                await notificationService.SendUserNotificationAsync(
                    (Guid)consultant.UserId,
                    consultantTitle,
                    consultantContent,
                    cancellationToken
                );

                // Thông báo cho admin nếu cần
                // await NotifyAdminAboutConsultantStatusChangeAsync(consultant, oldStatus, newStatus, cancellationToken);

                logger.LogInformation($"Sent status update notification to consultant");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send status update notification to consultant: {consultant.ConsultantId}");
            }
        }

        public async Task NotifyConsultantVerificationAsync(Consultant consultant, CancellationToken cancellationToken)
        {
            try
            {
                string consultantTitle = "Thông báo";
                string consultantContent = $"Đơn đăng ký trở thành chuyên viên tư vấn của bạn đã được phê duyệt";

                // Gửi thông báo cho consultant
                await notificationService.SendUserNotificationAsync(
                    (Guid)consultant.UserId,
                    consultantTitle,
                    consultantContent,
                    cancellationToken
                );

                logger.LogInformation($"Sent verification notification to consultant: {consultant.ConsultantId}");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send verification notification to consultant: {consultant.ConsultantId}");
            }
        }

        public async Task NotifyCreateMetricSuccessfully(Guid userId, CancellationToken cancellationToken)
        {
            try
            {
                var user = await userRepository.GetUserByIdAsync(userId);
                if (user != null)
                {
                    string title = "Thông báo";
                    string content = $"Chào {user.FullName}, rất vui khi được đồng hành cùng bạn tại Monhealth";

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

        public async Task NotifyGoalAbandonedAsync(Goal goal, CancellationToken cancellationToken)
        {
            try
            {

                // Tạo nội dung thông báo
                string title = "Thông báo";
                string content = $"Đã từ bỏ mục tiêu, có thể thiết lập mục tiêu mới bất kỳ lúc nào";

                // Gửi thông báo trong hệ thống
                await notificationService.SendUserNotificationAsync(
                    goal.UserId,
                    title,
                    content,
                    cancellationToken
                );

                logger.LogInformation($"Sent goal abandoned notification to user: {goal.UserId}");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send goal abandoned notification to user: {goal.UserId}");
            }
        }

        public async Task NotifyGoalCompletionAsync(Goal goal, CancellationToken cancellationToken)
        {
            try
            {

                // Tạo nội dung thông báo
                string title = "Thông báo";
                string content = $"Đã hoàn thành mục tiêu, hãy tiếp tục duy trì và đặt ra thử thách mới";

                // Gửi thông báo trong hệ thống
                await notificationService.SendUserNotificationAsync(
                    goal.UserId,
                    title,
                    content,
                    cancellationToken
                );

                logger.LogInformation($"Sent goal completion notification to user: {goal.UserId} for goal: {goal.GoalId}");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send goal completion notification to user: {goal.UserId} for goal: {goal.GoalId}");
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
                    string consultantContent = $"Có lịch hẹn mới từ {member.FullName} lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")}";

                    await notificationService.SendUserNotificationAsync(
                        (Guid)consultant.UserId,
                        consultantTitle,
                        consultantContent,
                        cancellationToken
                    );

                    // Thông báo cho member
                    string memberTitle = "Thông báo";
                    string memberContent = $"Đặt lịch hẹn thành công với {consultant.AppUser.FullName} lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")}";

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
                string title = "Thông báo";
                string content = $"Chào {user?.FullName}, tài khoản chuyên viên của bạn đã được tạo thành công";

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
                string title = "Thông báo";
                string content = $"Chào {user.FullName}, rất vui khi thấy bạn quay lại với Monhealth";

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
                string content = $"Đã mua thành công một lượt đặt lịch tư vấn";

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
                string content = $"Đã nâng cấp thành công {userSubscription?.Subscription?.SubscriptionName}";

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
                    string consultantContent = $"Sắp đến lịch hẹn với {member.FullName} lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")} (trong 30 phút nữa)";

                    await notificationService.SendUserNotificationAsync(
                        (Guid)consultant.UserId,
                        consultantTitle,
                        consultantContent,
                        cancellationToken
                    );

                    // Notification for member/user
                    string memberTitle = "Nhắc nhở";
                    string memberContent = $"Sắp đến lịch hẹn với {consultant.AppUser.FullName} lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")} (trong 30 phút nữa)";

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

        public async Task NotifyUpdateMetricSuccessfully(Guid userId, CancellationToken cancellationToken)
        {
            try
            {
                // Lấy thông tin user
                var user = await userRepository.GetUserByIdAsync(userId);
                if (user != null)
                {
                    // Tiêu đề & nội dung notification
                    string title = "Cập nhật";
                    string content = $"Đã cập nhật thành công chỉ số sức khỏe, tiếp tục theo dõi để cải thiện sức khỏe";

                    // Gửi notification
                    await notificationService.SendUserNotificationAsync(
                        user.Id,
                        title,
                        content,
                        cancellationToken
                    );
                }

                logger.LogInformation("Sent metric-update notification to user: {UserId}", userId);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Failed to send metric-update notification to user: {UserId}", userId);
            }
        }


        public async Task NotifyUserCreateReportSuccessfully(Report report, Guid userId, CancellationToken cancellationToken)
        {
            try
            {
                // Lấy thông tin user
                var user = await userRepository.GetUserByIdAsync(userId);
                if (user != null)
                {
                    // Tiêu đề & nội dung notification
                    string title = "Thông báo";
                    string content = $"Đã gửi thành công báo cáo. Hệ thống sẽ xử lý và phản hồi trong thời gian sớm nhất";

                    // Gửi notification
                    await notificationService.SendUserNotificationAsync(
                        user.Id,
                        title,
                        content,
                        cancellationToken
                    );
                }

                logger.LogInformation("Sent report-creation notification to user: {UserId}", userId);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Failed to send report-creation notification to user: {UserId}", userId);
            }
        }

        public async Task NotifyUserReportApprovedAsync(Report report, CancellationToken cancellation)
        {
            // 1. Thông báo tới user: xin lỗi và xác nhận report hợp lệ
            var booking = await bookingRepository.GetBookingByBookingIdAsync(report.BookingId);
            try
            {
                var user = await userRepository.GetUserByIdAsync((Guid)booking.UserId);
                if (user != null)
                {
                    string userTitle = "Thông báo";
                    string userContent = $"Đã ghi nhận báo cáo và hoàn trả 1 lượt đặt lịch hẹn. Rất tiếc về sự bất tiện vừa qua";

                    await notificationService.SendUserNotificationAsync(
                        user.Id,
                        userTitle,
                        userContent,
                        cancellation
                    );

                    logger.LogInformation(
                        "Sent report-approved apology notification to user {UserId} for report {ReportId}",
                        booking.UserId, report.ReportId);
                }
            }
            catch (Exception ex)
            {
                logger.LogError(
                    ex,
                    "Failed to send approval notification to user {UserId} for report {ReportId}",
                      booking.UserId, report.ReportId);
            }

            // 2. Nhắc nhở consultant: kiểm tra và xử lý report vừa được approve
            try
            {
                var consultant = await consultantRepository.GetConsultantByConsultantId((Guid)booking.ConsultantId);
                if (consultant != null)
                {
                    string consTitle = "Thông báo";
                    string consContent = $"Đã ghi nhận báo cáo liên quan đến cuộc hẹn. Hệ thống sẽ tiến hành xem xét và xử lý";

                    await notificationService.SendUserNotificationAsync(
                        consultant.ConsultantId,
                        consTitle,
                         consContent,
                        cancellation
                    );

                    logger.LogInformation(
                        "Sent report-reminder notification to consultant {ConsultantId} for report {ReportId}",
                        consultant.ConsultantId, report.ReportId);
                }
            }
            catch (Exception ex)
            {
                logger.LogError(
                    ex,
                    "Failed to send reminder notification to consultant {ConsultantId} for report {ReportId}",
                      booking.ConsultantId, report.ReportId);
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
                string content = $"Đã ghi nhận báo cáo, nhưng chưa đủ căn cứ để xử lý theo quy định";

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
                    string content = $"Đã đến lúc bổ sung nước, hãy uống {waterReminder.Volume}ml để duy trì năng lượng";

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

        public async Task NotifyScheduleExceptionApprovedAsync(Booking booking, CancellationToken cancellationToken)
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
                    string consultantContent = $"Lịch hẹn với {member.FullName} lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")} đã bị hủy";

                    await notificationService.SendUserNotificationAsync(
                        (Guid)consultant.UserId,
                        consultantTitle,
                        consultantContent,
                        cancellationToken
                    );

                    // Thông báo cho member
                    string memberTitle = "Thông báo";
                    string memberContent = $"Lịch hẹn với {consultant.AppUser.FullName} lúc {scheduledDateTime.ToString("HH:mm dd/MM/yyyy")} đã bị hủy";

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
                    string consultantContent = $"Yêu cầu nghỉ phép đã bị từ chối sau quá trình xem xét";

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

        public async Task NotifyConsultantHasNewIncomeAsync(Transaction transaction, CancellationToken cancellationToken)
        {
            try
            {
                var consultant = await consultantRepository.GetConsultantByConsultantId((Guid)transaction.ConsultantId);

                if (consultant != null)
                {
                    // Tạo thông báo chi tiết về nguồn thu nhập mới
                    string title = "Thông báo nguồn thu nhập mới";
                    string formattedAmount = transaction.Amount.HasValue
                             ? transaction.Amount.Value.ToString("N0")
                                            : "0";
                    string content = $"Bạn vừa có nguồn thu nhập mới: {formattedAmount} VNĐ";

                    // Gửi thông báo cho consultant
                    await notificationService.SendUserNotificationAsync(
                        (Guid)consultant.UserId,
                        title,
                        content,
                        cancellationToken
                    );

                    logger.LogInformation($"Sent new income notification to consultant: {transaction.ConsultantId}");
                }
                else
                {
                    logger.LogWarning($"Consultant not found with ID: {transaction.ConsultantId} when sending income notification");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send new income notification to consultant: {transaction.ConsultantId}");
            }
        }

        public async Task NotifyWithdrawalApprovedAsync(Transaction transaction, CancellationToken cancellationToken)
        {
            try
            {
                var consultant = await consultantRepository.GetConsultantByConsultantId((Guid)transaction.ConsultantId);
                if (consultant != null)
                {
                    // Tạo thông báo chi tiết về yêu cầu rút tiền thành công
                    string title = "Thông báo rút tiền thành công";
                    string formattedAmount = transaction.Amount.HasValue
                             ? transaction.Amount.Value.ToString("N0")
                                            : "0";
                    string content = $"Yêu cầu rút tiền của bạn đã được xử lý thành công: {formattedAmount} VNĐ";

                    // Gửi thông báo cho consultant
                    await notificationService.SendUserNotificationAsync(
                        (Guid)consultant.UserId,
                        title,
                        content,
                        cancellationToken
                    );
                    logger.LogInformation($"Sent withdrawal success notification to consultant: {transaction.ConsultantId}");
                }
                else
                {
                    logger.LogWarning($"Consultant not found with ID: {transaction.ConsultantId} when sending withdrawal notification");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send withdrawal success notification to consultant: {transaction.ConsultantId}");
            }
        }

        public async Task NotifyWithdrawalRequestSubmittedAsync(WithdrawalRequest withdrawalRequest, CancellationToken cancellationToken)
        {
            try
            {
                var consultant = await consultantRepository.GetConsultantByConsultantId(withdrawalRequest.ConsultantId);
                if (consultant != null)
                {
                    // Tạo thông báo chi tiết về yêu cầu rút tiền đang chờ phê duyệt
                    string title = "Yêu cầu rút tiền đã được tạo";
                    string formattedAmount = withdrawalRequest.Amount > 0
                             ? withdrawalRequest.Amount.ToString("N0")
                             : "0";
                    string content = $"Yêu cầu rút {formattedAmount} VNĐ của bạn đã được tạo thành công và đang chờ phê duyệt";

                    // Gửi thông báo cho consultant
                    await notificationService.SendUserNotificationAsync(
                        (Guid)consultant.UserId,
                        title,
                        content,
                        cancellationToken
                    );
                    logger.LogInformation($"Sent withdrawal request pending notification to consultant: {withdrawalRequest.ConsultantId}");
                }
                else
                {
                    logger.LogWarning($"Consultant not found with ID: {withdrawalRequest.ConsultantId} when sending withdrawal request notification");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send withdrawal request notification to consultant: {withdrawalRequest.ConsultantId}");
            }
        }

        public async Task NotifyWithdrawalRequestRejectedAsync(WithdrawalRequest withdrawalRequest, CancellationToken cancellationToken)
        {
            try
            {
                var consultant = await consultantRepository.GetConsultantByConsultantId(withdrawalRequest.ConsultantId);
                if (consultant != null)
                {
                    // Tạo thông báo chi tiết về yêu cầu rút tiền bị từ chối
                    string title = "Yêu cầu rút tiền bị từ chối";
                    string formattedAmount = withdrawalRequest.Amount > 0
                        ? withdrawalRequest.Amount.ToString("N0")
                        : "0";
                    string content = $"Yêu cầu rút {formattedAmount} VNĐ của bạn đã bị từ chối. Lý do: {withdrawalRequest.Reason}";

                    // Gửi thông báo cho consultant
                    await notificationService.SendUserNotificationAsync(
                        (Guid)consultant.UserId,
                        title,
                        content,
                        cancellationToken
                    );
                    logger.LogInformation($"Sent withdrawal request rejection notification to consultant: {withdrawalRequest.ConsultantId}");
                }
                else
                {
                    logger.LogWarning($"Consultant not found with ID: {withdrawalRequest.ConsultantId} when sending withdrawal rejection notification");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send withdrawal rejection notification to consultant: {withdrawalRequest.ConsultantId}");
            }
        }

        public async Task NotifyNewChatFromMemberAsync(Chat chat, CancellationToken cancellationToken)
        {
            try
            {
                var consultant = await consultantRepository.GetConsultantByConsultantId(chat.ConsultantId);
                if (consultant != null)
                {
                    var member = await userRepository.GetUserByIdAsync(chat.UserId);
                    string memberName = member?.FullName ?? "Khách hàng";

                    string title = "Tin nhắn mới từ khách hàng";
                    string content = $"{memberName} đã gửi một tin nhắn";

                    await notificationService.SendUserNotificationAsync(
                        (Guid)consultant.UserId,
                        title,
                        content,
                        cancellationToken
                    );

                    logger.LogInformation($"Sent new message notification to consultant: {chat.ConsultantId} from member: {chat.UserId}");
                }
                else
                {
                    logger.LogWarning($"Consultant not found with ID: {chat.ConsultantId} when sending new message notification");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send new message notification to consultant: {chat.ConsultantId}");
            }
        }
    }
}