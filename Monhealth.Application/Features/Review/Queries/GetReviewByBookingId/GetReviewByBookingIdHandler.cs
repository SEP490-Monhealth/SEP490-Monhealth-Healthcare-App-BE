using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Review.Queries.GetReviewByBookingId
{
    public class GetReviewByBookingIdHandler(IReviewRepository reviewRepository, IUserRepository userRepository) : IRequestHandler<GetReviewByBookingIdQueries, List<ReviewDTO>>
    {
        public async Task<List<ReviewDTO>> Handle(GetReviewByBookingIdQueries request, CancellationToken cancellationToken)
        {
            var query = await reviewRepository.GetReviewsByBookingId(request.BookingId);
            var reviewList = new List<ReviewDTO>();

            foreach (var r in query)
            {
                // Ensure that user exists
                var user = await userRepository.GetByIdAsync(r.UserId);

                // If user is null, skip the review or handle the situation (e.g., log, default Member values)
                if (user == null)
                {
                    // You can choose to skip or create a default Member for the review
                    reviewList.Add(new ReviewDTO
                    {
                        BookingId = r.BookingId,
                        Comment = r.Comment,
                        CreatedAt = r.CreatedAt,
                        Rating = r.Rating,
                        ReviewId = r.ReviewId,
                        UpdatedAt = r.UpdatedAt,
                        UserId = r.UserId,
                        Member = null // Or initialize with a default Member if needed
                    });
                    continue; // Skip this review if user is not found
                }

                var reviewDto = new ReviewDTO
                {
                    BookingId = r.BookingId,
                    Comment = r.Comment,
                    CreatedAt = r.CreatedAt,
                    Rating = r.Rating,
                    ReviewId = r.ReviewId,
                    UpdatedAt = r.UpdatedAt,
                    UserId = r.UserId
                };

                reviewDto.Member = new Member
                {
                    AvatarUrl = user.Avatar,
                    Email = user.Email,
                    FullName = user.FullName,
                    PhoneNumber = user.PhoneNumber
                };

                reviewList.Add(reviewDto);
            }

            return reviewList;
        }

    }
}
