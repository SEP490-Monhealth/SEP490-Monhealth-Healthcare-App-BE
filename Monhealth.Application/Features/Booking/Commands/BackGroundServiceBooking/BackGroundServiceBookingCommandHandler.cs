using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Services
{
    public class BackGroundServiceBookingCommandHandler : BackgroundService
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;
        private readonly ILogger<BackGroundServiceBookingCommandHandler> _logger;
        private static readonly TimeSpan Interval = TimeSpan.FromMinutes(1);

        public BackGroundServiceBookingCommandHandler(
            IServiceScopeFactory serviceScopeFactory,
            ILogger<BackGroundServiceBookingCommandHandler> logger)
        {
            _serviceScopeFactory = serviceScopeFactory;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("BookingReviewBackgroundService (test mode) started.");

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    using var scope = _serviceScopeFactory.CreateScope();
                    var repo = scope.ServiceProvider.GetRequiredService<IBookingRepository>();

                    // Thử nghiệm: threshold = 1 phút trước giờ hiện tại
                    var threshold = DateTime.Now.AddDays(-3);

                    // Repo đã implement so sánh Day + EndTime bên trong
                    var pending = await repo.GetPendingReviewsAsync(threshold, stoppingToken);

                    // Chỉ update những booking vẫn chưa được review
                    var toUpdate = pending.Where(b => !b.IsReviewed).ToList();
                    if (toUpdate.Any())
                    {
                        toUpdate.ForEach(b => b.IsReviewed = true);
                        await repo.UpdateRangeAsync(toUpdate, stoppingToken);

                        _logger.LogInformation(
                            "TEST: Marked {Count} bookings as reviewed (threshold: {Threshold}).",
                            toUpdate.Count, threshold);
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error in BookingReviewBackgroundService (test mode)");
                }

                await Task.Delay(Interval, stoppingToken);
            }

            _logger.LogInformation("BookingReviewBackgroundService (test mode) stopping.");
        }
    }
}
