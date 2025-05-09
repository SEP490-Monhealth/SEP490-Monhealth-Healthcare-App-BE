﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Monhealth.Application.Contracts.Email;
using Monhealth.Application.Contracts.Notification;
using Monhealth.Application.Contracts.Phone;
using Monhealth.Infrastructure.Email;
using Monhealth.Infrastructure.JobServices;
using Monhealth.Infrastructure.NotificationServices;
using Monhealth.Infrastructure.Phone;

namespace Monhealth.Infrastructure
{
    public static class InfrastructureServicesRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
            //services.AddTransient<IEmailSender, EmailSender>();
            //services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));

            services.AddScoped<IEmailSender, EmailService>();
            services.AddScoped<IOtpService, OtpService>();
            services.AddHttpClient();
            services.AddScoped<INotificationService, NotificationService>();
            services.AddScoped<ISystemNotificationService, SystemNotificationService>();

            //add hangfire job service
            services.AddScoped<IHangFireJobServices, HangFireJobServices>();
            return services;
        }
    }
}
