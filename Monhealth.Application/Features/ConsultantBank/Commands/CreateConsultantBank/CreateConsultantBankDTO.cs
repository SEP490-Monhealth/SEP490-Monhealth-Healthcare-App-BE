using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.ConsultantBank.Commands.CreateConsultantBank
{
    public class CreateConsultantBankDTO
    {
        public Guid ConsultantId { get; set; }
        [JsonPropertyName("bank")]
        public string BankName { get; set; } = string.Empty;
        [JsonPropertyName("number")]
        public string AccountNumber { get; set; } = string.Empty;
        [JsonPropertyName("name")]
        public string AccountName { get; set; } = string.Empty;
    }
}
