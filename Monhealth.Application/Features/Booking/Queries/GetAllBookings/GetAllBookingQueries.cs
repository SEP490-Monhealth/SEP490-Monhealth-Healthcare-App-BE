using MediatR;
using Monhealth.Application.Models;


namespace Monhealth.Application.Features.Booking.Queries.GetAllBookings
{
    public class GetAllBookingQueries : IRequest<PageResult<BookingDto>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public string? Search { get; set; }

    }
}
