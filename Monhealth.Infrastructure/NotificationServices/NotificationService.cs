using Monhealth.Application.Contracts.Notification;
using Monhealth.Application.Models.Notifications;
using System.Text;
using System.Text.Json;

namespace Monhealth.Infrastructure.NotificationServices
{
    public class NotificationService(HttpClient httpClient) : INotificationService
    {
        public async Task<bool> SendExpoNotificationAsync(string expoPushToken, string title, string body)
        {
            var sendLink = "https://exp.host/--/api/v2/push/send";
            var notificationRequest = new ExpoNotificationRequest
            {
                To = expoPushToken,
                Title = title,
                Body = body
            };
            var jsonPayload = JsonSerializer.Serialize(notificationRequest);
            var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(sendLink, content);
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                // This is critical to know what's wrong:
                Console.WriteLine($"Expo API Error: {errorContent}");
            }
            return response.IsSuccessStatusCode;

        }
    }
}
