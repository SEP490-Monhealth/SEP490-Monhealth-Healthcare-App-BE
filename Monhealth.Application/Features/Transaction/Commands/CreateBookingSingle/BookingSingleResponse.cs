using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Transaction.Commands.CreateBookingSingle
{
    public class BookingSingleResponse
    {
        public Guid TransactionId { get; set; }
        public Guid UserId { get; set; }
        public long? OrderCode { get; set; }
        public string QrCode { get; set; }
        public string PaymentUrl { get; set; }
        public string Description { get; set; } = string.Empty;
        public float Amount { get; set; }
    }
}
