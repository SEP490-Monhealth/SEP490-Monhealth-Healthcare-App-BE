using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Booking.Queries.GetBookingByConsultantIdMonthly
{
    public class GetBookingByConsultantIdMonthlyQuery : IRequest<PageResult<GetBookingByConsultantIdMonthlyDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public Guid ConsultantId { get; set; }
        public DateTime? Month { get; set; }
    }
}
