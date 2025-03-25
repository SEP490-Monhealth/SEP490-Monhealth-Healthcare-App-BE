using MediatR;
using Monhealth.Application.Features.Booking.Queries.GetAllBookings;

namespace Monhealth.Application.Features.Booking.Queries.GetBookingByConsultantId
{
    public class GetByConsultantIdQueries : IRequest<List<BookingDto>>
    {
        public Guid ConsultantId { get; set; }
    }
}
