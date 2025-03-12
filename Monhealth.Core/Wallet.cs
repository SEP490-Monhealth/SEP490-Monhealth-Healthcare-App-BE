using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Monhealth.Domain.Common;

namespace Monhealth.Domain
{
    public class Wallet : TimeEntity
    {
        [Key]
        public Guid WalletId { get; set; }
        public Guid ConsultantId { get; set; }
        public float? Balance { get; set; }
        public bool Status { get; set; } = false;

        [ForeignKey(nameof(ConsultantId))]
        public Consultant? Consultant { get; set; }
        public ICollection<Transaction>? Transactions { get; set; }
    }
}
