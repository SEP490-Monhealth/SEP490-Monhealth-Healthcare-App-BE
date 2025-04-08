using Microsoft.Extensions.Caching.Memory;
using Monhealth.Application.Contracts.PayOS;
using Monhealth.Application.Models.PayOS;
using Net.payOS;
using Net.payOS.Types;

namespace Monhealth.Infrastructure.PayOSService
{
    public class PayOSServices(IMemoryCache cache, PayOS payOS, UrlSettings urlSettings) : IPayOSService
    {
        public async Task<PaymentLinkResult> CreatePaymentLinkAsync(Guid bookingId, decimal amount, string description)
        {
            // Check if the payment link is already cached
            var cacheKey = $"PaymentLink_{bookingId}";
            if (cache.TryGetValue<PaymentLinkResult>(cacheKey, out var cachedResult))
                return cachedResult!;

            var timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            var hashCode = Math.Abs(bookingId.GetHashCode());
            var shortTimestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds() % 1_000_000;
            var orderCode = long.Parse($"{timestamp}{hashCode % 1_000_000}");

            var items = new List<ItemData> { new("Thanh toán nâng cấp gói đăng ký", 1, (int)amount) };
            var paymentData = new PaymentData(
                orderCode: orderCode,
                amount: (int)amount,
                description: description,
                items: items,
                cancelUrl: urlSettings.CancelUrl,
                returnUrl: urlSettings.ReturnUrl,
                expiredAt: (int?)DateTimeOffset.UtcNow.AddMinutes(15).ToUnixTimeSeconds(),
                signature: bookingId.ToString()
            );

            var result = await payOS.createPaymentLink(paymentData);

            var paymentLinkResult = new PaymentLinkResult(
                result.paymentLinkId,
                orderCode,
                result.checkoutUrl,
                result.qrCode,
                result.status
            );

            // Cache the link with a lifetime of 15 minutes
            var cacheEntryOptions = new MemoryCacheEntryOptions().SetAbsoluteExpiration(
                TimeSpan.FromMinutes(15)
            );

            cache.Set(cacheKey, paymentLinkResult, cacheEntryOptions);

            return paymentLinkResult;
        }
    }
}
