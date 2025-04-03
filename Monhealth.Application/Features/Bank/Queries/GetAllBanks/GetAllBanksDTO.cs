using Monhealth.Domain.Common;
using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Bank.Queries.GetAllBanks
{
    public class GetAllBanksDTO : BaseEntity
    {
        public Guid BankId { get; set; }
        [JsonPropertyName("code")]
        public string BankCode { get; set; } = string.Empty;
        [JsonPropertyName("name")]
        public string BankName { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;
        public string LogoUrl { get; set; } = string.Empty;
        public bool Status { get; set; }
    }
}
