namespace Monhealth.Application.Contracts.Notification
{
    public interface INotificationService
    {
        Task<bool> SendExpoNotificationAsync(string expoPushToken, string title, string body);
    }
}
