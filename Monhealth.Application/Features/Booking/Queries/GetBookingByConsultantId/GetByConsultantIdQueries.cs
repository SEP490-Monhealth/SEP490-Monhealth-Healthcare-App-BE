using MediatR;
using Monhealth.Application.Features.Booking.Queries.GetAllBookings;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Booking.Queries.GetBookingByConsultantId
{
    public class GetByConsultantIdQueries : IRequest<PageResult<BookingDto>>
    {
        public Guid ConsultantId { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
        public DateTime? Date { get; set; }
    }
}
