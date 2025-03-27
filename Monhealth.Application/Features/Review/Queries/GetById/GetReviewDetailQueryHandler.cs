using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Identity.Models;

namespace Monhealth.Application.Features.Review.Queries.GetById
{
    public class GetReviewDetailQueryHandler : IRequestHandler<GetReviewDetailQuery, ReviewDetailDTO>
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IUserRepository _userRepository;
        public GetReviewDetailQueryHandler(IReviewRepository reviewRepository,
        IUserRepository userRepository)
        {
            _reviewRepository = reviewRepository;
            _userRepository = userRepository;
        }

        public async Task<ReviewDetailDTO> Handle(GetReviewDetailQuery request, CancellationToken cancellationToken)
        {
            var query = await _reviewRepository.GetByIdAsync(request.ReviewId);
            AppUser user = await _userRepository.GetByIdAsync(query.UserId);
            return new ReviewDetailDTO
            {
                ReviewId = query.ReviewId,
                BookingId = query.BookingId,
                Comment = query.Comment,
                Rating = query.Rating,
                UserId = query.UserId,
                CreatedAt = query.CreatedAt,
                UpdatedAt = query.UpdatedAt,
                Member = new Member
                {
                    AvatarUrl = user.Avatar,
                    Email = user.Email,
                    FullName = user.Email,
                    PhoneNumber = user.PhoneNumber
                }
            };

        }
    }
}