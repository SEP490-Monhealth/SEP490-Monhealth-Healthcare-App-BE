using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Review.Queries.GetReviewByBookingId
{
    public class GetReviewByBookingIdHandler(IReviewRepository reviewRepository, IMapper mapper) : IRequestHandler<GetReviewByBookingIdQueries, List<ReviewDTO>>
    {
        public async Task<List<ReviewDTO>> Handle(GetReviewByBookingIdQueries request, CancellationToken cancellationToken)
        {
            var reviewList = await reviewRepository.GetReviewsByBookingId(request.BookingId);
            var reviewDtoList = reviewList.Select(r => new ReviewDTO
            {
                ReviewId = r.ReviewId,
                BookingId = r.BookingId,
                Comment = r.Comment,
                CreatedAt = r.CreatedAt,
                UpdatedAt = r.UpdatedAt,
                Rating = r.Rating,
                UserId = r.UserId,
                UserName = r.User.UserName
            }).ToList();

            return reviewDtoList;
        }
    }
}
