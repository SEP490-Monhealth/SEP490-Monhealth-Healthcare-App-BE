using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monhealth.Domain.Common;

namespace Monhealth.Domain
{
    public class Wallet : TimeEntity
    {
        public Guid WalletId { get; set; }
        public Guid ConsultantId { get; set; }
        public float Balance { get; set; }
        public bool Status { get; set; }

        [ForeignKey(nameof(ConsultantId))]
        public Consultant Consultant { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
