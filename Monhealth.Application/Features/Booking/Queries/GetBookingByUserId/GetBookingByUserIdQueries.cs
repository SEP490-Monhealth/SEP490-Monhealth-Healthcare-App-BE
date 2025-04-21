using MediatR;
using Monhealth.Application.Features.Booking.Queries.GetAllBookings;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application.Features.Booking.Queries.GetBookingByUserId
{
    public class GetBookingByUserIdQueries : IRequest<PageResult<BookingDto>>
    {
        public Guid UserId { get; set; }
        public int Page { get; set; } 
        public int Limit { get; set; }
        public GetBookingByUserIdQueries(Guid userId, int page, int limit)
        {
            UserId = userId;
            Page = page;
            Limit = limit;
        }
    }
}
