using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Report.ReportTransactionMonthly
{
    public class ReportTransactionMonthlyQueryHandler(ITransactionRepository transactionRepository) : IRequestHandler<ReportTransactionMonthlyQuery, ReportTransactionMonthlyDTO>
    {
        public async Task<ReportTransactionMonthlyDTO> Handle(ReportTransactionMonthlyQuery request, CancellationToken cancellationToken)
        {
            var targetMonth = new DateTime(request.Date.Year, request.Date.Month, 1);
            var months = Enumerable.Range(-5, 6)
                .Select(offset => targetMonth.AddMonths(offset))
                .ToList();
            var from = months.First();
            var to = months.Last().AddMonths(1);

            var transactions = await transactionRepository.GetTransactionsByConsultantAndDateRange(request.ConsultantId, from, to);

            // tinh tong booking khi StatusTransaction = Completed
            var transactionCompleted = transactions.Where(s => s.Status == StatusTransaction.Completed).ToList();

            var incomeTypes = new[] { TransactionType.Earning, TransactionType.Bonus };
            var expenseTypes = new[] { TransactionType.Withdrawal, TransactionType.Refund, TransactionType.Fee };

            var incomeGrouped = transactionCompleted
                .Where(t => incomeTypes.Contains(t.TransactionType))
                .GroupBy(t => new { t.CreatedAt.Value.Year, t.CreatedAt.Value.Month })
                .ToDictionary(
                    g => $"{g.Key.Year}-{g.Key.Month:D2}",
                    g => g.Sum(t => t.Amount)
                );

            var expenseGrouped = transactionCompleted
                .Where(t => expenseTypes.Contains(t.TransactionType))
                .GroupBy(t => new { t.CreatedAt.Value.Year, t.CreatedAt.Value.Month })
                .ToDictionary(
                    g => $"{g.Key.Year}-{g.Key.Month:D2}",
                    g => g.Sum(t => t.Amount)
                );

            var incomeList = months.Select(m => new MonthlyAmountDto
            {
                Month = m.ToString("yyyy-MM"),
                Amount = incomeGrouped.TryGetValue(m.ToString("yyyy-MM"), out var amt) ? amt : 0
            }).ToList();

            var expenseList = months.Select(m => new MonthlyAmountDto
            {
                Month = m.ToString("yyyy-MM"),
                Amount = expenseGrouped.TryGetValue(m.ToString("yyyy-MM"), out var amt) ? amt : 0
            }).ToList();

            return new ReportTransactionMonthlyDTO
            {
                Income = incomeList,
                Expense = expenseList
            };
        }
    }
}
