using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application.Features.Review.Queries.GetReviewByUser
{
    public class GetReviewByUserQueryHandler : IRequestHandler<GetReviewByUserQuery, PageResult<ReviewByUserDTO>>
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IUserRepository _userRepository;
        public GetReviewByUserQueryHandler(IReviewRepository reviewRepository,
        IUserRepository userRepository)
        {
            _reviewRepository = reviewRepository;
            _userRepository = userRepository;
        }

        public async Task<PageResult<ReviewByUserDTO>> Handle(GetReviewByUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.UserId);
            var queries = await _reviewRepository.GetReviewsByUser(request.UserId, request.Page, request.Limit);
            var reviewList = new List<ReviewByUserDTO>();
            foreach (var r in queries.Items)
            {
                var reviewDTO = new ReviewByUserDTO
                {
                    BookingId = r.BookingId,
                    Comment = r.Comment,
                    CreatedAt = r.CreatedAt,
                    Rating = r.Rating,
                    ReviewId = r.ReviewId,
                    UpdatedAt = r.UpdatedAt,
                    UserId = r.UserId,
                };
                reviewDTO.Member = new Member
                {
                    AvatarUrl = user.Avatar,
                    Email = user.Email,
                    FullName = user.FullName,
                    PhoneNumber = user.PhoneNumber
                };
                reviewList.Add(reviewDTO);
            }
            return new PageResult<ReviewByUserDTO>
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(queries.TotalCount / (double)request.Limit),
                TotalItems = queries.TotalCount,
                Items = reviewList
            };
        }
    }
}