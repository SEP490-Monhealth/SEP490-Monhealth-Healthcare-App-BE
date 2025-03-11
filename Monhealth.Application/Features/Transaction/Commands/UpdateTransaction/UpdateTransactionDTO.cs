using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Transaction.Commands.UpdateTransaction
{
    public class UpdateTransactionDTO
    {
        public TransactionType TransactionType { get; set; }
        public string? Description { get; set; }
        public float? Amount { get; set; }
        public float? BalanceBefore { get; set; }
        public float? BalanceAfter { get; set; }
    }
}
