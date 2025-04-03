using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.ConsultantBank.Commands.CreateConsultantBank
{
    public class CreateConsultantBankDTO
    {
        public Guid ConsultantId { get; set; }
        public Guid BankId { get; set; }
        [JsonPropertyName("number")]
        public string AccountNumber { get; set; } = string.Empty;
        [JsonPropertyName("name")]
        public string AccountName { get; set; } = string.Empty;
        public bool IsDefault { get; set; }
    }
}
