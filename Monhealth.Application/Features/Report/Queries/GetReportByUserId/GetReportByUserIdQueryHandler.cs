using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application.Features.Report.Queries.GetReportByUserId
{
    public class GetReportByUserIdQueryHandler(IReportRepository reportRepository, IMapper mapper) : IRequestHandler<GetReportByUserIdQuery, PageResult<GetReportByUserIdDTO>>
    {
        public async Task<PageResult<GetReportByUserIdDTO>> Handle(GetReportByUserIdQuery request, CancellationToken cancellationToken)
        {
            var listReport = await reportRepository.GetReportByUserId(request.UserId, request.Page, request.Limit);
            return new PageResult<GetReportByUserIdDTO>()
            {
                Items = mapper.Map<List<GetReportByUserIdDTO>>(listReport.Items),
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(listReport.TotalCount / (double)request.Limit),
                TotalItems = listReport.TotalCount,
            };
        }
    }
}
