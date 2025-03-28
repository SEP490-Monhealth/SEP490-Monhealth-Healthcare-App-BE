using System.Text.Json.Serialization;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Transaction.Commands.UpdateTransaction
{
        public class UpdateTransactionDTO
        {
                public Guid ConsultantId { get; set; }
                [JsonPropertyName("type")]
                public TransactionType TransactionType { get; set; }
                public string? Description { get; set; }
                public float? Amount { get; set; }
        }
}
