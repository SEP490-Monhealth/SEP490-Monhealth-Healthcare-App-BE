using Monhealth.Application.Contracts.PayOS;
using Monhealth.Application.Models.PayOS;
using Monhealth.Infrastructure.PayOSService;
using Net.payOS;

namespace Monhealth.Api.Utils
{
    public class ConfigurationMissingException(string configKey)
    : InvalidOperationException($"Required configuration key '{configKey}' is missing")
    { }

    public static class PayOSConfig
    {
        public static IServiceCollection AddPayOSService(
        this IServiceCollection services,
         IConfiguration configuration
        )
        {
            var settings = configuration.GetSection("PayOS").Get<PayOSSettings>();
            if (settings == null ||
         string.IsNullOrWhiteSpace(settings.PAYOS_CLIENT_ID) ||
         string.IsNullOrWhiteSpace(settings.PAYOS_API_KEY) ||
         string.IsNullOrWhiteSpace(settings.PAYOS_CHECKSUM_KEY))
            {
                throw new Exception("Thiếu cấu hình PayOS trong appsettings.json");
            }


            PayOS payOS = new(settings.PAYOS_CLIENT_ID, settings.PAYOS_API_KEY, settings.PAYOS_CHECKSUM_KEY);
            services.AddSingleton(s => payOS);


            UrlSettings urlSettings = new() { ReturnUrl = settings.RETURN_URL, CancelUrl = settings.CANCEL_URL };
            services.AddSingleton(s => urlSettings);
            services.AddScoped<IPayOSService, PayOSServices>();

            return services;
        }

        private static string GetRequiredConfig(IConfiguration configuration, string key)
        {
            var value = configuration[key];

            return string.IsNullOrWhiteSpace(value)
                ? throw new ConfigurationMissingException(key)
                : value;
        }
    }
}
