using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Review.Queries.GetReviewByConsultant
{
    public class GetReviewByConsultantQueryHandler : IRequestHandler<GetReviewByConsultantQuery, List<ReviewByConsultantDTO>>
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IUserRepository _userRepository;
        public GetReviewByConsultantQueryHandler(IReviewRepository reviewRepository,
        IUserRepository userRepository)
        {
            _reviewRepository = reviewRepository;
            _userRepository = userRepository;
        }

        public async Task<List<ReviewByConsultantDTO>> Handle(GetReviewByConsultantQuery request, CancellationToken cancellationToken)
        {
            var queries = await _reviewRepository.GetReviewsByConsultant(request.ConsultantId);
            var reviewList = new List<ReviewByConsultantDTO>();
            foreach (var r in queries)
            {
                var reviewDTO = new ReviewByConsultantDTO
                {
                    BookingId = r.BookingId,
                    Comment = r.Comment,
                    CreatedAt = r.CreatedAt,
                    Rating = r.Rating,
                    ReviewId = r.ReviewId,
                    UpdatedAt = r.UpdatedAt,
                    UserId = r.UserId,
                };
                var user = await _userRepository.GetByIdAsync(r.UserId);
                reviewDTO.Member = new Member
                {
                    AvatarUrl = user.Avatar,
                    Email = user.Email,
                    FullName = user.FullName,
                    PhoneNumber = user.PhoneNumber
                };
                reviewList.Add(reviewDTO);
            }
            return reviewList;
        }
    }
}