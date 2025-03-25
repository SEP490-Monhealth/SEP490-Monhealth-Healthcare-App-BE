using MediatR;
using Monhealth.Application.Features.Booking.Queries.GetAllBookings;

namespace Monhealth.Application.Features.Booking.Queries.GetBookingByUserId
{
    public class GetBookingByUserIdQueries : IRequest<List<BookingDto>>
    {
        public Guid UserId { get; set; }
    }
}
