using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Report.Queries.GetReportById
{
    public class GetReportByIdQueryHandler(IReportRepository reportRepository, IMapper mapper) : IRequestHandler<GetReportByIdQuery, GetReportByIdDTO>
    {
        public async Task<GetReportByIdDTO> Handle(GetReportByIdQuery request, CancellationToken cancellationToken)
        {
            var report = await reportRepository.GetReportById(request.ReportId);
            return mapper.Map<GetReportByIdDTO>(report);
        }
    }
}
