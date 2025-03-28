using System.Text.Json.Serialization;
using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Transaction.Queries.GetAllTransactions
{
    public class GetAllTransactionsDTO : BaseEntity
    {
        public Guid TransactionId { get; set; }
        public Guid WalletId { get; set; }
        public Guid BookingId { get; set; }
        public Consultant Consultant { get; set; } = null!;
        [JsonPropertyName("type")]
        public TransactionType TransactionType { get; set; }
        public string? Description { get; set; }
        public float? Amount { get; set; }
        public StatusTransaction? Status { get; set; }
    }
    public class Consultant
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string AvatarUrl { get; set; } = string.Empty;
    }
}
