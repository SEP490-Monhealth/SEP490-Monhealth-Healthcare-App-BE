using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Monhealth.Application.Features.Notificacation.Commands;

namespace Monhealth.Identity.NotificationService
{
    public class ReminderBackgroundService : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;

        public ReminderBackgroundService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                using (var scope = _serviceProvider.CreateScope())
                {
                    var mediator = scope.ServiceProvider.GetRequiredService<IMediator>();

                    try
                    {
                        
                        await mediator.Send(new CreateNotificationCommand());
                        Console.WriteLine($"Notifications created at {DateTime.Now}");
                    }
                    catch (Exception ex)
                    {
                        
                        Console.WriteLine($"Error in ReminderBackgroundService: {ex.Message}");
                    }
                }

                // Chờ 1 phút trước khi kiểm tra lại
                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
            }
        }
        
    }
}