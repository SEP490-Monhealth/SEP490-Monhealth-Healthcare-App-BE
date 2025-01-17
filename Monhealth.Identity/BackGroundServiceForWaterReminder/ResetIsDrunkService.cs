using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;


namespace Monhealth.Identity.BackGroundServiceForWaterReminder
{
    public class ResetIsDrunkService : BackgroundService
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;
        private readonly ILogger<ResetIsDrunkService> _logger;
        private readonly TimeSpan _interval = TimeSpan.FromMinutes(2); // Khoảng thời gian kiểm tra

        public ResetIsDrunkService(IServiceScopeFactory serviceScopeFactory, ILogger<ResetIsDrunkService> logger)
        {
            _serviceScopeFactory = serviceScopeFactory;
            _logger = logger;
        }

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
                        var now = DateTime.Now; // Lấy thời gian hiện tại

                        _logger.LogInformation($"Checking reminders at {now}.");

                        // Lấy tất cả các reminders cần được kiểm tra
                        var activeReminders = await repository.GetAllActiveWaterRemindersAsync();

                        foreach (var reminder in activeReminders)
                        {
                            // Kiểm tra nếu CreatedAt đã qua ngày mới
                            if (reminder.CreatedAt.HasValue && reminder.CreatedAt.Value.Date < now.Date)
                            {
                                // Đặt IsDrunk về false
                                reminder.IsDrunk = false;
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

                    // Chờ đến lần kiểm tra tiếp theo (định kỳ theo _interval)
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


        public async Task RunCheckAsync()
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                var repository = scope.ServiceProvider.GetRequiredService<IWaterReminderRepository>();
                var now = DateTime.Now;

                _logger.LogInformation($"Manually checking reminders at {now}.");

                var activeReminders = await repository.GetAllActiveWaterRemindersAsync();

                foreach (var reminder in activeReminders)
                {
                    if (reminder.CreatedAt.HasValue && reminder.CreatedAt.Value.Date < now.Date)
                    {
                        reminder.IsDrunk = false;
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
    }
}
