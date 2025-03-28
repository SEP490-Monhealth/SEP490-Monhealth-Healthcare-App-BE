using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Transaction.Commands.CreateTransaction
{
    public class CreateTransactionDTO
    {
        public Guid ConsultantId { get; set; }
        public Guid BookingId { get; set; }
        public TransactionType TransactionType { get; set; }
        public string? Description { get; set; }
        public float? Amount { get; set; }
    }
}
