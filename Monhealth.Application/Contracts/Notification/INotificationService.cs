namespace Monhealth.Application.Contracts.Notification
{
    public interface INotificationService
    {
        Task<bool> SendExpoNotificationAsync(string expoPushToken, string title, string body);
        Task SendUserNotificationAsync(Guid userId, string title, string content,
            CancellationToken cancellationToken,
            string actionUrl = null, Guid? referenceId = null);
        Task SendUserNotificationWithoutSaveAsync(Guid userId, string title, string content,
             string actionUrl = null, Guid? referenceId = null
            );
    }
}
