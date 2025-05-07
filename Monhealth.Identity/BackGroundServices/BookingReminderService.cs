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

                        //reminder upcoming booking
                        await ProcessReminderNotificationsAsync(bookingRepository, systemNotificationService, stoppingToken);

                        //reminder 24-hour for complted booking
                        await ProcessConsultantReminderAsync(bookingRepository, systemNotificationService, stoppingToken);

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
            var now = GetCurrentVietnamTime();

            // Time window for notifications (30 minutes from now)
            var targetTime = now.AddMinutes(30);

            // Get bookings that start in exactly 30 minutes (with small buffer)
            var startTimeMin = targetTime.AddMinutes(-30);
            var startTimeMax = targetTime.AddMinutes(30);

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

        // New method to remind consultants 24 hours after completed booking
        private async Task ProcessConsultantReminderAsync(
            IBookingRepository bookingRepository,
            ISystemNotificationService systemNotificationService,
            CancellationToken stoppingToken
        )
        {
            var now = GetCurrentVietnamTime();

            // Find completed bookings that are older than 24 hours but not yet reminded
            var completedBookings = await bookingRepository.GetCompletedBookingsOlderThan24HoursAsync(now.AddHours(-24), stoppingToken);

            logger.LogInformation($"Found {completedBookings.Count} completed bookings older than 24 hours.");

            foreach (var booking in completedBookings)
            {
                if (booking.ConsultantReminderSent)
                {
                    // Skip if reminder was already sent
                    continue;
                }

                // Send reminder to consultant to mark the booking as complete
                //await systemNotificationService.NotifyConsultantToCompleteBookingAsync(booking, stoppingToken);

                // Mark reminder as sent
                booking.ConsultantReminderSent = true;
                bookingRepository.Update(booking);

                logger.LogInformation($"Sent 24-hour reminder for consultant to complete booking: {booking.BookingId}");
            }

            await bookingRepository.SaveChangeAsync(stoppingToken);
        }

        private DateTime GetCurrentVietnamTime()
        {
            DateTime utcNow = DateTime.UtcNow;
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // Vietnam Time Zone
            return TimeZoneInfo.ConvertTimeFromUtc(utcNow, vietnamTimeZone);
        }
    }
}
