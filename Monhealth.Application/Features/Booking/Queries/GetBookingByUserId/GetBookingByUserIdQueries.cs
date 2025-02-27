using MediatR;

namespace Monhealth.Application.Features.Booking.Queries.GetBookingByUserId
{
    public class GetBookingByUserIdQueries : IRequest<GetBookingByUserIdDto>
    {
        public Guid UserId { get; set; }
    }
}
