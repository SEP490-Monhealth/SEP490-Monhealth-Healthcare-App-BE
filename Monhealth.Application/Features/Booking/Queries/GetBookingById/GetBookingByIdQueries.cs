using MediatR;
using Monhealth.Application.Features.Booking.Queries.GetAllBookings;

namespace Monhealth.Application.Features.Booking.Queries.GetBookingById
{
    public class GetBookingByIdQueries : IRequest<BookingDto>
    {
        public Guid BookingId { get; set; }
    }
}
