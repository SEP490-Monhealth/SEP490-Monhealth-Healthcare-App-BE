using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Review.Queries.GetReviewByUser
{
    public class GetReviewByUserQueryHandler : IRequestHandler<GetReviewByUserQuery, List<ReviewByUserDTO>>
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IUserRepository _userRepository;
        public GetReviewByUserQueryHandler(IReviewRepository reviewRepository,
        IUserRepository userRepository)
        {
            _reviewRepository = reviewRepository;
            _userRepository = userRepository;
        }

        public async Task<List<ReviewByUserDTO>> Handle(GetReviewByUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.userId);
            var queries = await _reviewRepository.GetReviewsByUser(request.userId);
            return queries.Select(r => new ReviewByUserDTO
            {
                ReviewId = r.ReviewId,
                BookingId = r.BookingId,
                Comment = r.Comment,
                CreatedAt = r.CreatedAt,
                UpdatedAt = r.UpdatedAt,
                Rating = r.Rating,
                UserId = r.UserId,
                Member = new Member
                {
                    AvatarUrl = user.Avatar,
                    Email = user.Email,
                    FullName = user.FullName,
                    PhoneNumber = user.PhoneNumber
                }

            }).ToList();
        }
    }
}