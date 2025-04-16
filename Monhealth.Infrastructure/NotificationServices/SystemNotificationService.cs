using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Notification;
using Monhealth.Domain;

namespace Monhealth.Infrastructure.NotificationServices
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
