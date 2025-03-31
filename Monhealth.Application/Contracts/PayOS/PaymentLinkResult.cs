namespace Monhealth.Application.Contracts.PayOS
{
    public record PaymentLinkResult(
         string PaymentLinkId,
         long OrderCode,
        string CheckoutUrl,
       string QrCode,
      string Status
        );

}
