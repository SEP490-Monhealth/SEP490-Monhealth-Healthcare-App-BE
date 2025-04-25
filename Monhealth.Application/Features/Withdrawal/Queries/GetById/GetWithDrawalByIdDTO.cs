using System.Text.Json.Serialization;
using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;

namespace Monhealth.Application
{
    public class GetWithdrawalByIdDTO : TimeEntity
    {
        public Guid WithdrawalRequestId { get; set; }
        public Guid ConsultantId { get; set; }
        public Guid ConsultantBankId { get; set; }
        public ConsultantDTOForId Consultant { get; set; } = null!;
        public ConsultantBankDto ConsultantBank { get; set; } = null!;
        public string Description { get; set; } = string.Empty;
        public float Amount { get; set; }
        [JsonPropertyName("bank")]
        public ConsultantBankInformation ConsultantBankInformation { get; set; }
        public string Reason { get; set; } = string.Empty;
        public WithdrawalStatus Status { get; set; }
    }
    public class ConsultantDTOForId
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string AvatarUrl { get; set; } = string.Empty;
    }
    public class ConsultantBankDto
    {
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
    }
    public class ConsultantBankInformation
    {
        public string BankName { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;
        public string LogoUrl { get; set; } = string.Empty;
    }
}