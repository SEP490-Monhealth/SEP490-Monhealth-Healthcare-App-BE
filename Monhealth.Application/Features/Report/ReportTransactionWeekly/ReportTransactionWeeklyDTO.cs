namespace Monhealth.Application.Features.Report.ReportTransaction
{
    public class ReportTransactionWeeklyDTO
    {
        public List<TransactionReportItemDto> Income { get; set; } = new();
        public List<TransactionReportItemDto> Expense { get; set; } = new();
    }
    public class TransactionReportItemDto
    {
        public string Date { get; set; } = default!;
        public float? Amount { get; set; }
    }
}
