using System.Text.Json.Serialization;
using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;

namespace Monhealth.Application
{
    public class GetWithdrawalRequestDTO : TimeEntity
    {
        public Guid WithdrawalRequestId { get; set; }
        public Guid ConsultantId { get; set; }
        public ConsultantDTO12 Consultant { get; set; } = null!;
        [JsonPropertyName("bank")]
        public BankInfo ConsultantBank { get; set; }
        public string Description { get; set; } = string.Empty;
        public float Amount { get; set; }
        public string Reason { get; set; } = string.Empty;
        public WithdrawalStatus Status { get; set; }
    }

    public class ConsultantDTO12
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string AvatarUrl { get; set; } = string.Empty;
    }

    public class BankInfo
    {
        [JsonPropertyName("name")]
        public string BankName { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;
        public string LogoUrl { get; set; } = string.Empty;
    }
}