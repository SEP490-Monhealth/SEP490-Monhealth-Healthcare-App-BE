using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Booking.Queries.GetAllBookings;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Report.Queries.GetAllReports
{
    public class GetAllReportsQueryHandler(IReportRepository reportRepository, IMapper mapper) : IRequestHandler<GetAllReportsQuery, PageResult<GetAllReportsDTO>>
    {
        public async Task<PageResult<GetAllReportsDTO>> Handle(GetAllReportsQuery request, CancellationToken cancellationToken)
        {
            var pagingReport = await reportRepository.GetAllReports(request.Page, request.Limit, request.Search, request.Status);
            return new PageResult<GetAllReportsDTO>()
            {
                Items = mapper.Map<List<GetAllReportsDTO>>(pagingReport.Items),
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(pagingReport.TotalCount / (double)request.Limit),
                TotalItems = pagingReport.TotalCount,
            };
        }
    }
}
