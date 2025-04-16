using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class WithdrawalRequest : TimeEntity
    {
        public Guid WithdrawalRequestId { get; set; }
        public Guid ConsultantId { get; set; }
        public Guid ConsultantBankId { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Reason { get; set; } = string.Empty;
        public float Amount { get; set; }
        public WithdrawalStatus Status { get; set; }

        [ForeignKey(nameof(ConsultantId))]
        public Consultant Consultant { get; set; }
    }
}
