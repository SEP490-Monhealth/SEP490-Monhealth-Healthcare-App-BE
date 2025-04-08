using Net.payOS.Types;

namespace Monhealth.Infrastructure.PayOSService
{
    public record CreatePaymentRequest(
      long OrderCode,
      int Amount,
      string Description,
      string BuyerName,
      string ReturnUrl,
      string CancelUrl,
      IEnumerable<ItemData> Items
  );
}
