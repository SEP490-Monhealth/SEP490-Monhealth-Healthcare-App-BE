using MediatR;

namespace Monhealth.Application.Features.Report.ReportTransactionMonthly
{
    public class ReportTransactionMonthlyQuery : IRequest<ReportTransactionMonthlyDTO>
    {
        public Guid ConsultantId { get; set; }
        public DateTime Date { get; set; }
    }
}
