using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;

namespace Monhealth.Application
{
    public class GetWithdrawalRequestDTO : BaseEntity
    {
        public Guid WithdrawalRequestId { get; set; }
        public Guid ConsultantId { get; set; }
        public string Description { get; set; }
        public float Amount { get; set; }
        public WithdrawalStatus Status { get; set; }
    }
}