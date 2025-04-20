using MediatR;

namespace Monhealth.Application.Features.Report.Queries.GetReportByBookingId
{
    public class GetReportByBookingIdQuery : IRequest<List<GetReportByBookingIdDTO>>
    {
        public Guid BookingId { get; set; }
    }
}
