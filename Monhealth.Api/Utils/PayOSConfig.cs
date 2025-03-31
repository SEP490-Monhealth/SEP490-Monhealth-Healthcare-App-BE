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
            // Validate and get PayOS configuration
            var clientId = GetRequiredConfig(configuration, "PAYOS_CLIENT_ID");
            var apiKey = GetRequiredConfig(configuration, "PAYOS_API_KEY");
            var checkSumKey = GetRequiredConfig(configuration, "PAYOS_CHECKSUM_KEY");

            PayOS payOS = new(clientId, apiKey, checkSumKey);
            services.AddSingleton(s => payOS);

            // Validate and get URL settings
            var returnUrl = GetRequiredConfig(configuration, "RETURN_URL");
            var cancelUrl = GetRequiredConfig(configuration, "CANCEL_URL");

            UrlSettings urlSettings = new() { ReturnUrl = returnUrl, CancelUrl = cancelUrl };
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
