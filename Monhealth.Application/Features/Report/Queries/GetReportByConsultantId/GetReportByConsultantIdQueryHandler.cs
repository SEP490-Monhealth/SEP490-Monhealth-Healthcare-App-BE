using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Report.Queries.GetReportByBookingId;

namespace Monhealth.Application.Features.Report.Queries.GetReportByConsultantId
{
    public class GetReportByConsultantIdQueryHandler(IReportRepository reportRepository, IMapper mapper) : IRequestHandler<GetReportByConsultantIdQuery, List<GetReportByConsultantIdDTO>>
    {
        public async Task<List<GetReportByConsultantIdDTO>> Handle(GetReportByConsultantIdQuery request, CancellationToken cancellationToken)
        {
            var listReport = await reportRepository.GetReportByConsultantId(request.ConsultantId);
            return mapper.Map<List<GetReportByConsultantIdDTO>>(listReport);
        }
    }
}
