using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application
{
    public class BackGroundServiceBookingCommandHandler : BackgroundService
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;
        private readonly ILogger<BackGroundServiceBookingCommandHandler> _logger;
        private static readonly TimeSpan Interval = TimeSpan.FromMinutes(1);

        public BackGroundServiceBookingCommandHandler(IServiceScopeFactory serviceScopeFactory, ILogger<BackGroundServiceBookingCommandHandler> logger)
        {
            _serviceScopeFactory = serviceScopeFactory;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("BookingReviewBackgroundService started.");
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    using var scope = _serviceScopeFactory.CreateScope();
                    var repo = scope.ServiceProvider.GetRequiredService<IBookingRepository>();

                    // Chọn ngưỡng 3 ngày trước đây
                    DateTime threshold = DateTime.Now.AddMinutes(-1);

                    var pending = await repo.GetPendingReviewsAsync(threshold, stoppingToken);
                    if (pending.Any())
                    {
                        pending.ForEach(b => b.IsReviewed = true);
                        await repo.UpdateRangeAsync(pending, stoppingToken);
                        _logger.LogInformation("Marked {Count} bookings as reviewed.", pending.Count);
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error in BookingReviewBackgroundService");
                }

                await Task.Delay(Interval, stoppingToken);
            }
            _logger.LogInformation("BookingReviewBackgroundService stopping.");
        }
    }
}