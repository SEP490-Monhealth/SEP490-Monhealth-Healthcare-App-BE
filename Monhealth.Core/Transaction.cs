using System.ComponentModel.DataAnnotations.Schema;
using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;

namespace Monhealth.Domain
{
    public class Transaction : TimeEntity
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

        [ForeignKey(nameof(WalletId))]
        public Wallet Wallet { get; set; }
        [ForeignKey(nameof(BookingId))]
        public Booking Booking { get; set; }
    }
}
