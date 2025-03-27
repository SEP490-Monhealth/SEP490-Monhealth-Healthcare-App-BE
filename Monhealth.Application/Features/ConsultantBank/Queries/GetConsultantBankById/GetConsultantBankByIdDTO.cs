using System.Text.Json.Serialization;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.ConsultantBank.Queries.GetConsultantBankById
{
    public class GetConsultantBankByIdDTO : TimeEntity
    {
        public Guid ConsultantBankId { get; set; }
        public Guid ConsultantId { get; set; }
        public string BankName { get; set; } = string.Empty;
        public Guid BankId { get; set; }
        [JsonPropertyName("number")]
        public string AccountNumber { get; set; } = string.Empty;
        [JsonPropertyName("name")]
        public string AccountName { get; set; } = string.Empty;
        public bool IsDefault { get; set; }
        public bool Status { get; set; }
    }
}
