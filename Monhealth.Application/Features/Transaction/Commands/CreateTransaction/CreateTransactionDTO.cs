using System.Text.Json.Serialization;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Transaction.Commands.CreateTransaction
{
    public class CreateTransactionDTO
    {
        public Guid WalletId { get; set; }
        public Guid BookingId { get; set; }
        [JsonPropertyName("type")]
        public TransactionType TransactionType { get; set; }
        public string? Description { get; set; }
        public float? Amount { get; set; }
    }
}
