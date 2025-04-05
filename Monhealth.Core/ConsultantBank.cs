using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class ConsultantBank : TimeEntity
    {
        public Guid ConsultantBankId { get; set; }
        public Guid ConsultantId { get; set; }
        public Guid BankId { get; set; }
        public string AccountNumber { get; set; } = string.Empty;
        public string AccountName { get; set; } = string.Empty;
        public bool IsDefault { get; set; }
        //public bool IsVerified { get; set; }
        //public bool Status { get; set; }

        [ForeignKey(nameof(ConsultantId))]
        public Consultant Consultant { get; set; }

        [ForeignKey(nameof(BankId))]
        public Bank Bank { get; set; }
    }
}
