namespace Monhealth.Application.Features.Report.ReportTransactionMonthly
{
    public class ReportTransactionMonthlyDTO
    {
        public List<MonthlyAmountDto> Income { get; set; } = new();
        public List<MonthlyAmountDto> Expense { get; set; } = new();
        
    }
    public class MonthlyAmountDto
    {
        public string Month { get; set; } = default!;
        public float? Amount { get; set; }
    }
}
