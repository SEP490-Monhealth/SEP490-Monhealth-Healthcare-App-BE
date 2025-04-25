using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Notification;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Notifications;
using Monhealth.Domain;
using System.Text;
using System.Text.Json;

namespace Monhealth.Infrastructure.NotificationServices
{
    public class NotificationService(HttpClient httpClient,
        ILogger<NotificationService> logger,
        INotificationRepository notificationRepository,
        IUserNotificationRepository userNotificationRepository,
        IDeviceRepository deviceRepository
        ) : INotificationService
    {
        public async Task<bool> SendExpoNotificationAsync(string expoPushToken, string title, string body)
        {
            if (string.IsNullOrEmpty(expoPushToken))
            {
                logger.LogWarning("Cannot send push notification: ExpoPushToken is null or empty");
                return false;
            }
            try
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
                    logger.LogError($"Expo API Error: {errorContent}");
                    return false;
                }
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Exception occurred while sending Expo push notification");
                return false;
            }

        }

        public async Task SendUserNotificationAsync(Guid userId, string title, string content,
            CancellationToken cancellationToken,
            string actionUrl = null, Guid? referenceId = null)
        {
            try
            {
                // 1. Tạo bản ghi thông báo trong cơ sở dữ liệu
                var notification = new Notification
                {
                    Title = title,
                    Content = content,
                    ActionUrl = actionUrl,
                    ReferenceId = referenceId,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                };

                notificationRepository.Add(notification);

                // 2. Tạo liên kết giữa người dùng và thông báo
                var userNotification = new UserNotification
                {
                    UserId = userId,
                    NotificationId = notification.NotificationId,
                    IsRead = false,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                };

                userNotificationRepository.Add(userNotification);

                // 3. Lấy thông tin tất cả thiết bị của người dùng
                var userDevices = await deviceRepository.GetAllDevicesByUserId(userId);

                if (!userDevices.Any())
                {
                    logger.LogInformation($"User {userId} has no registered devices for push notifications");
                    return;
                }

                // 4. Gửi push notification đến từng thiết bị
                int successCount = 0;
                foreach (var device in userDevices)
                {
                    try
                    {
                        // Gửi thông báo đến thiết bị
                        bool success = await SendExpoNotificationAsync(
                            device.ExpoPushToken ?? string.Empty,
                            title,
                            content
                        );

                        if (success)
                        {
                            successCount++;
                        }
                        else
                        {
                            logger.LogWarning($"Failed to send push notification to device {device.DeviceId} for user {userId}");

                            //// Nếu token không hợp lệ, đánh dấu để cập nhật sau
                            //if (await IsTokenInvalid(device.ExpoPushToken))
                            //{
                            //    device.ExpoPushToken = null;
                            //    device.UpdatedAt = DateTime.UtcNow;
                            //    _context.Devices.Update(device);
                            //    await _context.SaveChangesAsync();
                            //}
                        }
                    }
                    catch (Exception ex)
                    {
                        logger.LogError(ex, $"Error sending push notification to device {device.DeviceId}");
                    }
                }
                await notificationRepository.SaveChangeAsync(cancellationToken);
                logger.LogInformation($"Sent push notifications to {successCount}/{userDevices.Count} devices for user {userId}");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send notification to user {userId}");
                throw;
            }
        }

        public async Task SendUserNotificationWithoutSaveAsync(Guid userId, string title, string content, string actionUrl = null, Guid? referenceId = null)
        {
            try
            {

                // 3. Lấy thông tin tất cả thiết bị của người dùng
                var userDevices = await deviceRepository.GetAllDevicesByUserId(userId);

                if (!userDevices.Any())
                {
                    logger.LogInformation($"User {userId} has no registered devices for push notifications");
                    return;
                }

                // 4. Gửi push notification đến từng thiết bị
                int successCount = 0;
                foreach (var device in userDevices)
                {
                    try
                    {
                        // Gửi thông báo đến thiết bị
                        bool success = await SendExpoNotificationAsync(
                            device.ExpoPushToken ?? string.Empty,
                            title,
                            content
                        );

                        if (success)
                        {
                            successCount++;
                        }
                        else
                        {
                            logger.LogWarning($"Failed to send push notification to device {device.DeviceId} for user {userId}");

                            //// Nếu token không hợp lệ, đánh dấu để cập nhật sau
                            //if (await IsTokenInvalid(device.ExpoPushToken))
                            //{
                            //    device.ExpoPushToken = null;
                            //    device.UpdatedAt = DateTime.UtcNow;
                            //    _context.Devices.Update(device);
                            //    await _context.SaveChangesAsync();
                            //}
                        }
                    }
                    catch (Exception ex)
                    {
                        logger.LogError(ex, $"Error sending push notification to device {device.DeviceId}");
                    }
                }
                logger.LogInformation($"Sent push notifications to {successCount}/{userDevices.Count} devices for user {userId}");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send notification to user {userId}");
                throw;
            }
        }
    }
}
