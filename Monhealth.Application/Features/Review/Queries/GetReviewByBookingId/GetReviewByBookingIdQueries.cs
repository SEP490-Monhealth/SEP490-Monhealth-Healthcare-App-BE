using MediatR;

namespace Monhealth.Application.Features.Review.Queries.GetReviewByBookingId
{
    public class GetReviewByBookingIdQueries : IRequest<List<ReviewDTO>>
    {
        public Guid BookingId { get; set; }

    }
}
