using MediatR;

namespace Monhealth.Application.Features.Report.ReportTransaction
{
    public class ReportTransactionWeeklyQuery : IRequest<ReportTransactionWeeklyDTO>
    {
        public Guid ConsultantId { get; set; }
        public DateTime Date {  get; set; }
    }
}
