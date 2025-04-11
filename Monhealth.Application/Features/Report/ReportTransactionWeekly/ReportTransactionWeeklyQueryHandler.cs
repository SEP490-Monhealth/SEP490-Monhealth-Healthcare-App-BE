using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Report.ReportTransaction
{
    public class ReportTransactionWeeklyQueryHandler(ITransactionRepository transactionRepository, IMapper mapper) : IRequestHandler<ReportTransactionWeeklyQuery, ReportTransactionWeeklyDTO>
    {
        public async Task<ReportTransactionWeeklyDTO> Handle(ReportTransactionWeeklyQuery request, CancellationToken cancellationToken)
        {
            var transactions = await transactionRepository.GetTransactionByConsultantId(request.ConsultantId, request.Date);
            // Xac dinh va tao list 7 ngay
            int dayOfWeek = (int)request.Date.DayOfWeek;
            dayOfWeek = dayOfWeek == 0 ? 7 : dayOfWeek;
            var monday = request.Date.Date.AddDays(-dayOfWeek + 1);

            var weekDates = Enumerable.Range(0, 7)
                .Select(offset => monday.AddDays(offset))
                .ToList();

            // Khai bao các TransactionType theo nhom
            var incomeTypes = new[] { TransactionType.Earning, TransactionType.Bonus };
            var expenseTypes = new[] { TransactionType.Withdrawal, TransactionType.Refund, TransactionType.Fee };

            // tinh income va expend khi TransactionStatus = completed
            var transactionCompleted = transactions.Where(t => t.Status == StatusTransaction.Completed).ToList();

            // Gom nhom income
            var incomeGrouped = transactionCompleted
                .Where(t => incomeTypes.Contains(t.TransactionType))
                .GroupBy(t => t.CreatedAt.Value.Date)
                .ToDictionary(g => g.Key, g => g.Sum(t => t.Amount));

            // Gom nhom expense
            var expenseGrouped = transactionCompleted
                .Where(t => expenseTypes.Contains(t.TransactionType))
                .GroupBy(t => t.CreatedAt.Value.Date)
                .ToDictionary(g => g.Key, g => g.Sum(t => t.Amount));

            // Tao danh sach tra ve du 7 ngay
            var incomeList = weekDates
                .Select(date => new TransactionReportItemDto
                {
                    Date = date.ToString("yyyy-MM-dd"),
                    Amount = incomeGrouped.TryGetValue(date, out var amount) ? amount : 0
                })
                .ToList();

            var expenseList = weekDates
                .Select(date => new TransactionReportItemDto
                {
                    Date = date.ToString("yyyy-MM-dd"),
                    Amount = expenseGrouped.TryGetValue(date, out var amount) ? amount : 0
                })
                .ToList();

            return new ReportTransactionWeeklyDTO
            {
                Income = incomeList,
                Expense = expenseList
            };
        }
    }
}
