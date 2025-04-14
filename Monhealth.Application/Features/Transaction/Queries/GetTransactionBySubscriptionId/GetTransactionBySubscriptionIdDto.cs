using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;
using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Transaction.Queries.GetTransactionBySubscriptionId
{
    public class GetTransactionBySubscriptionIdDto : BaseEntity
    {
        public Guid TransactionId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? WalletId { get; set; }
        public Guid? BookingId { get; set; }
        public Guid? WithdrawalRequestId { get; set; }
        public Guid? SubscriptionId { get; set; }
        [JsonPropertyName("subscription")]
        public string SubscriptionName { get; set; } = string.Empty;
        public TransactionType TransactionType { get; set; }
        public string? Description { get; set; }
        public float? Amount { get; set; }
        public long? OrderCode { get; set; }
        public StatusTransaction? Status { get; set; }
    }
}
