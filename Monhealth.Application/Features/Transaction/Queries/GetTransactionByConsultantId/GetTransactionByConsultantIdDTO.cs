using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Transaction.Queries.GetTransactionByConsultantId
{
    public class GetTransactionByConsultantIdDTO
    {
        public Guid TransactionId { get; set; }
        public Guid WalletId { get; set; }
        public Guid BookingId { get; set; }
        public TransactionType TransactionType { get; set; }
        public string? Description { get; set; }
        public float? Amount { get; set; }
        public float? BalanceBefore { get; set; }
        public float? BalanceAfter { get; set; }
        public StatusTransaction? Status { get; set; }
    }
}
