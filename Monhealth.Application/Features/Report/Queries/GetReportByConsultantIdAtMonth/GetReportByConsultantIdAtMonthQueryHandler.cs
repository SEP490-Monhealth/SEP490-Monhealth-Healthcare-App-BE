using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Report.Queries.GetReportByConsultantIdAtMonth
{
    public class GetReportByConsultantIdAtMonthQueryHandler(IReportRepository reportRepository) : IRequestHandler<GetReportByConsultantIdAtMonthQuery, List<GetReportByConsultantIdAtMonthDTO>>
    {
        public async Task<List<GetReportByConsultantIdAtMonthDTO>> Handle(GetReportByConsultantIdAtMonthQuery request, CancellationToken cancellationToken)
        {
            var reports = await reportRepository.GetReportedByConsultantIdAtMonth(request.ConsultantId, request.Month);
            return reports.Select(r => new GetReportByConsultantIdAtMonthDTO
            {
                ReportId = r.ReportId,
                BookingId = r.BookingId,
                Reason = r.Reason,
                ImageUrls = r.ImageUrls,
                Status = r.Status,
                CreatedAt = r.CreatedAt,
                UpdatedAt = r.UpdatedAt,
                CreatedBy = r.CreatedBy,
                UpdatedBy = r.UpdatedBy,
            }).ToList();
        }
    }
}
