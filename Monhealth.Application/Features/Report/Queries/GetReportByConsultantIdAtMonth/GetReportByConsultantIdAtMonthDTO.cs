using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Report.Queries.GetReportByConsultantIdAtMonth
{
    public class GetReportByConsultantIdAtMonthDTO : BaseEntity
    {
        public Guid ReportId { get; set; }
        public Guid BookingId { get; set; }
        public string Reason { get; set; }
        public List<string> ImageUrls { get; set; } = new();
        public StatusReport Status { get; set; }
    }
}
