using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Transaction : TimeEntity
    {
        [Key]
        public Guid TransactionId { get; set; }
        public Guid WalletId { get; set; }
        public Guid? BookingId { get; set; }
        public TransactionType TransactionType { get; set; }
        public string? Description { get; set; }
        public float? Amount { get; set; }
        public StatusTransaction? Status { get; set; }
        [ForeignKey(nameof(WalletId))]
        public Wallet Wallet { get; set; }
        [ForeignKey(nameof(BookingId))]
        public Booking Booking { get; set; }
    }
}
