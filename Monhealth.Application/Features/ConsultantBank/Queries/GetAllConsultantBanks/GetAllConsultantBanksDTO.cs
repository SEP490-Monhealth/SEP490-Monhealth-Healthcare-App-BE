using Monhealth.Domain.Common;
using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.ConsultantBank.Queries.GetAllConsultantBanks
{
    public class GetAllConsultantBanksDTO : BaseEntity
    {
        public Guid ConsultantBankId { get; set; }
        public Guid ConsultantId { get; set; }
        public Guid BankId { get; set; }
        public BankInfoDTO Bank { get; set; } = new BankInfoDTO();
        [JsonPropertyName("number")]
        public string AccountNumber { get; set; } = string.Empty;
        [JsonPropertyName("name")]
        public string AccountName { get; set; } = string.Empty;
        public bool IsDefault { get; set; }
    }
    public class BankInfoDTO
    {
        [JsonPropertyName("name")]
        public string BankName { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;
        public string LogoUrl { get; set; } = string.Empty;
    }
}
