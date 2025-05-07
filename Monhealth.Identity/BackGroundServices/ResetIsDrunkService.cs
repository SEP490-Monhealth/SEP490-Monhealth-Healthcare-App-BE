using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Notification;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;


namespace Monhealth.Identity.BackGroundServiceForWaterReminder
{
    public class ResetIsDrunkService : BackgroundService
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;
        private readonly ILogger<ResetIsDrunkService> _logger;
        private readonly TimeSpan _interval = TimeSpan.FromMinutes(1); // Khoảng thời gian kiểm tra

        public ResetIsDrunkService(IServiceScopeFactory serviceScopeFactory, ILogger<ResetIsDrunkService> logger)
        {
            _serviceScopeFactory = serviceScopeFactory;
            _logger = logger;
        }
        DateTime lastCheckedDate = DateTime.MinValue;
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("ResetIsDrunkService started.");

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    using (var scope = _serviceScopeFactory.CreateScope())
                    {
                        var repository = scope.ServiceProvider.GetRequiredService<IWaterReminderRepository>();
                        var notificationService = scope.ServiceProvider.GetRequiredService<ISystemNotificationService>();

                        var now = GetCurrentVietnamTime(); // Lấy thời gian hiện tại

                        _logger.LogInformation($"Checking reminders at {now}.");

                        // Lấy tất cả các reminders cần được kiểm tra
                        var activeReminders = await repository.GetAllActiveWaterRemindersAsync();

                        string currentTimeString = now.ToString("HH:mm"); // Format giờ:phút

                        if (now.Date != lastCheckedDate.Date)
                        {
                            // Cập nhật lại IsDrunk nếu đã qua ngày mới
                            foreach (var reminder in activeReminders)
                            {
                                if (reminder.CreatedAt.HasValue && reminder.CreatedAt.Value.Date < now.Date)
                                {
                                    reminder.IsDrunk = false; // Đặt lại IsDrunk thành false nếu đã qua ngày mới
                                }
                            }
                            lastCheckedDate = now; // Lưu lại ngày hiện tại để kiểm tra lần sau
                        }

                        foreach (var reminder in activeReminders)
                        {

                            // Phần 2: Kiểm tra và gửi thông báo
                            if (ShouldSendReminder(reminder, currentTimeString))
                            {
                                await notificationService.NotifyWaterReminderNotificationAsync(reminder, stoppingToken);

                                //// Cập nhật trạng thái nếu cần
                                //if (!reminder.IsRecurring)
                                //{
                                //    reminder.IsDrunk = true;
                                //}
                            }

                        }

                        // Cập nhật cơ sở dữ liệu nếu có thay đổi
                        if (activeReminders.Count > 0)
                        {
                            await repository.UpdateWaterReminders(activeReminders);
                            _logger.LogInformation($"Reset completed for {activeReminders.Count} reminders.");
                        }
                        else
                        {
                            _logger.LogInformation("No reminders to reset.");
                        }
                    }

                    await Task.Delay(_interval, stoppingToken);
                }
                catch (TaskCanceledException)
                {
                    break; // Dừng nếu bị hủy
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error occurred in ResetIsDrunkService.");
                }
            }
        }

        private bool ShouldSendReminder(WaterReminder reminder, string currentTimeString)
        {
            // Kiểm tra các điều kiện để gửi thông báo:
            // 1. Reminder đang active (Status = true)
            // 2. Thời gian hiện tại trùng với thời gian nhắc nhở
            // 3. Chưa uống nước (IsDrunk = false) hoặc là reminder lặp lại

            if (!reminder.Status)
                return false;

            if (reminder.Time != currentTimeString)
                return false;

            if (reminder.IsDrunk && !reminder.IsRecurring)
                return false;

            return true;
        }

        public async Task RunCheckAsync()
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                var repository = scope.ServiceProvider.GetRequiredService<IWaterReminderRepository>();
                var notificationService = scope.ServiceProvider.GetRequiredService<ISystemNotificationService>();
                var now = DateTime.Now;
                string currentTimeString = now.ToString("HH:mm");

                _logger.LogInformation($"Manually checking reminders at {now}.");

                var activeReminders = await repository.GetAllActiveWaterRemindersAsync();

                foreach (var reminder in activeReminders)
                {
                    // Reset IsDrunk nếu sang ngày mới
                    if (reminder.CreatedAt.HasValue && reminder.CreatedAt.Value.Date < now.Date)
                    {
                        reminder.IsDrunk = false;
                    }

                    // Kiểm tra và gửi thông báo - giống như trong ExecuteAsync
                    if (ShouldSendReminder(reminder, currentTimeString))
                    {
                        await notificationService.NotifyWaterReminderNotificationAsync(reminder, CancellationToken.None);

                        // Cập nhật trạng thái nếu cần
                        if (!reminder.IsRecurring)
                        {
                            reminder.IsDrunk = true;
                        }

                        _logger.LogInformation($"Manual notification sent for reminder: {reminder.WaterReminderId}");
                    }
                }

                if (activeReminders.Count > 0)
                {
                    await repository.UpdateWaterReminders(activeReminders);
                    _logger.LogInformation($"Manual reset completed for {activeReminders.Count} reminders.");
                }
                else
                {
                    _logger.LogInformation("No reminders to reset.");
                }
            }
        }

        private DateTime GetCurrentVietnamTime()
        {
            DateTime utcNow = DateTime.UtcNow;
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // Vietnam Time Zone
            return TimeZoneInfo.ConvertTimeFromUtc(utcNow, vietnamTimeZone);
        }
    }
}
