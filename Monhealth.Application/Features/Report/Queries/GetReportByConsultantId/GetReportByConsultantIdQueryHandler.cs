using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;


namespace Monhealth.Application.Features.Report.Queries.GetReportByConsultantId
{
    public class GetReportByConsultantIdQueryHandler(IReportRepository reportRepository, IMapper mapper) : IRequestHandler<GetReportByConsultantIdQuery, PageResult<GetReportByConsultantIdDTO>>
    {
        public async Task<PageResult<GetReportByConsultantIdDTO>> Handle(GetReportByConsultantIdQuery request, CancellationToken cancellationToken)
        {
            var listReport = await reportRepository.GetReportByConsultantId(request.ConsultantId, request.Page, request.Limit);

            return new PageResult<GetReportByConsultantIdDTO>()
            {
                Items = mapper.Map<List<GetReportByConsultantIdDTO>>(listReport.Items),
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(listReport.TotalCount / (double)request.Limit),
                TotalItems = listReport.TotalCount,
            };


        }
    }
}
