using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;

namespace Monhealth.Application
{
    public class GetWithdrawalRequestDTO : BaseEntity
    {
        public Guid WithdrawalRequestId { get; set; }
        public Guid ConsultantId { get; set; }
        public ConsultantDTO12 Consultant { get; set; } = null!;
        public string Description { get; set; } = string.Empty;
        public float Amount { get; set; }
        public WithdrawalStatus Status { get; set; }
    }
    public class ConsultantDTO12
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string AvatarUrl { get; set; } = string.Empty;
    }
}