namespace Monhealth.Application.Contracts.PayOS
{
    public interface IPayOSService
    {
        Task<PaymentLinkResult> CreatePaymentLinkAsync(
            Guid paymentId,
         decimal amount,
         string description
        );
    }
}
