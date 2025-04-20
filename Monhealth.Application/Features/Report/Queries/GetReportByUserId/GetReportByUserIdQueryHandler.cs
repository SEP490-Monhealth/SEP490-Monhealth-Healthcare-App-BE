using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Report.Queries.GetReportByBookingId;

namespace Monhealth.Application.Features.Report.Queries.GetReportByUserId
{
    public class GetReportByUserIdQueryHandler(IReportRepository reportRepository, IMapper mapper) : IRequestHandler<GetReportByUserIdQuery, List<GetReportByUserIdDTO>>
    {
        public async Task<List<GetReportByUserIdDTO>> Handle(GetReportByUserIdQuery request, CancellationToken cancellationToken)
        {
            var listReport = await reportRepository.GetReportByUserId(request.UserId);
            return mapper.Map<List<GetReportByUserIdDTO>>(listReport);
        }
    }
}
