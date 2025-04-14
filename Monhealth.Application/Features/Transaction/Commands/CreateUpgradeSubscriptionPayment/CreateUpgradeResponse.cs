namespace Monhealth.Application.Features.Transaction.Commands.CreateUpgradeSubscriptionPayment
{
    public class CreateUpgradeResponse
    {
        public Guid TransactionId { get; set; }
        public Guid UserId { get; set; }
        public Guid SubscriptionId { get; set; }
        public long OrderCode { get; set; }
        public string QrCode { get; set; }
        public string PaymentUrl { get; set; }
        public string Description { get; set; }
        public float? Amount { get; set; }
    }
}
