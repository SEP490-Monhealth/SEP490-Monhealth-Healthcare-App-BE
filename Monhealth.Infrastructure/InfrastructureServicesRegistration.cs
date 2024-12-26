using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Monhealth.Application.Contracts.Email;
using Monhealth.Infrastructure.Email;

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

            return services;
        }
    }
}
