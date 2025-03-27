using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Bank.Commands.UpdateBank
{
    public class UpdateBankDTO
    {
        [JsonPropertyName("code")]
        public string BankCode { get; set; } = string.Empty;
        [JsonPropertyName("name")]
        public string BankName { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;
        public string LogoUrl { get; set; } = string.Empty;
    }
}
