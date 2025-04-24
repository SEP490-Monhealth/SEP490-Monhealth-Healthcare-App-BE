using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Notification;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Identity.BackGroundServices
{
    public class BookingReminderService(ILogger<BookingReminderService> logger,
        IServiceScopeFactory serviceScopeFactory)
        : BackgroundService
    {

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            logger.LogInformation("Booking Reminder Service is starting.");

            while (!stoppingToken.IsCancellationRequested)
            {
                using (var scope = serviceScopeFactory.CreateScope()) // Create scope here
                {
                    try
                    {
                        // Resolve scoped services inside the scope
                        var bookingRepository = scope.ServiceProvider.GetRequiredService<IBookingRepository>();
                        var systemNotificationService = scope.ServiceProvider.GetRequiredService<ISystemNotificationService>();

                        await ProcessReminderNotificationsAsync(bookingRepository, systemNotificationService, stoppingToken);
                    }
                    catch (Exception ex)
                    {
                        logger.LogError(ex, "Error occurred while processing booking reminders.");
                    }
                }
                // Run every minute to check for bookings that need notifications
                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
            }
        }
        private async Task ProcessReminderNotificationsAsync(
            IBookingRepository bookingRepository,
            ISystemNotificationService systemNotificationService,
            CancellationToken stoppingToken
        )
        {
            // Current time
            var now = DateTime.Now;

            // Time window for notifications (30 minutes from now)
            var targetTime = now.AddMinutes(30);

            // Get bookings that start in exactly 30 minutes (with small buffer)
            var startTimeMin = targetTime.AddMinutes(-0.5);
            var startTimeMax = targetTime.AddMinutes(0.5);

            // Get bookings that should receive notifications
            var bookings = await bookingRepository.GetBookingsForRemindersAsync(
                startTimeMin,
                startTimeMax,
                stoppingToken);

            logger.LogInformation($"Found {bookings.Count} bookings for reminder notifications.");

            foreach (var booking in bookings)
            {
                if (booking.NotificationSent30Min)
                {
                    // Skip if notification was already sent
                    continue;
                }

                // Send notifications
                await systemNotificationService.NotifyUpComingBookingReminderAsync(booking, stoppingToken);

                // Mark notification as sent
                booking.NotificationSent30Min = true;
                bookingRepository.Update(booking);

                logger.LogInformation($"Sent 30-minute reminder for booking: {booking.BookingId}");
            }

            await bookingRepository.SaveChangeAsync(stoppingToken);
        }

    }
}
