using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Notification;
using Monhealth.Domain;

namespace Monhealth.Identity.Services
{
    public class SystemNotificationService(INotificationService notificationService,
        ILogger<SystemNotificationService> logger

        ) : ISystemNotificationService
    {
        public Task NotifyBookingUpdateAsync(Booking booking, string changeDescription)
        {
            throw new NotImplementedException();
        }

        public Task NotifyNewBookingAsync(Booking booking)
        {
            throw new NotImplementedException();
        }

        public async Task NotifyNewConsultantRegistrationAsync(Consultant consultant, CancellationToken cancellationToken)
        {
            try
            {
                string title = "Chào mừng bạn tham gia làm Consultant";
                string content = $"Xin chào {consultant.AppUser.FullName}, cảm ơn bạn đã đăng ký làm consultant trên hệ thống của chúng tôi. Tài khoản của bạn đã được tạo thành công.";
                string actionUrl = "/consultant/dashboard";

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
