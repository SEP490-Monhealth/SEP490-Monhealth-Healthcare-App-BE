using MediatR;

namespace Monhealth.Application.Features.Report.ReportBookingMonthly
{
    public class ReportBookingMonthlyQuery : IRequest<List<ReportBookingMonthlyDTO>>
    {
        public Guid ConsultantId { get; set; }
        public DateTime Date { get; set; }
    }
}
