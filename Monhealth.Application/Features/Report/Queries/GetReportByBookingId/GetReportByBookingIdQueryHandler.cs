using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Report.Queries.GetReportByBookingId
{
    public class GetReportByBookingIdQueryHandler(IReportRepository reportRepository, IMapper mapper) : IRequestHandler<GetReportByBookingIdQuery, List<GetReportByBookingIdDTO>>
    {
        public async Task<List<GetReportByBookingIdDTO>> Handle(GetReportByBookingIdQuery request, CancellationToken cancellationToken)
        {
            var listReport = await reportRepository.GetReportByBookingId(request.BookingId);
            return mapper.Map<List<GetReportByBookingIdDTO>>(listReport);
        }
    }
}
