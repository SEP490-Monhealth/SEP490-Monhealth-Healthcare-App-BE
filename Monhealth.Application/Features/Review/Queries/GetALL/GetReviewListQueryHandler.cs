using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application.Features.Review.Queries
{
    public class GetReviewListQueryHandler : IRequestHandler<GetReviewListQuery, PageResult<ReviewDTO>>
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IUserRepository _userRepository;
        public GetReviewListQueryHandler(IReviewRepository reviewRepository,
        IUserRepository userRepository)
        {
            _reviewRepository = reviewRepository;
            _userRepository = userRepository;
        }

        public async Task<PageResult<ReviewDTO>> Handle(GetReviewListQuery request, CancellationToken cancellationToken)
        {

            var queries = await _reviewRepository
               .GetAllReviewAsync(request.Page, request.Limit, request.Rating , request.Search);

            var reviewList = new List<ReviewDTO>();

            foreach (var r in queries.Items)
            {
                // Lấy AppUser từ UserId trong Review
                var appUser = await _userRepository.GetByIdAsync(r.UserId); // Giả sử bạn có repository để lấy AppUser

                var reviewDto = new ReviewDTO
                {
                    ReviewId = r.ReviewId,
                    BookingId = r.BookingId,
                    Comment = r.Comment,
                    CreatedAt = r.CreatedAt,
                    UpdatedAt = r.UpdatedAt,
                    Rating = r.Rating,
                    UserId = r.UserId
                };

                // Nếu có AppUser, ánh xạ thông tin vào ReviewDTO
                if (appUser != null)
                {
                    reviewDto.Member = new Member
                    {
                        FullName = appUser.FullName,
                        Email = appUser.Email,
                        PhoneNumber = appUser.PhoneNumber,
                        AvatarUrl = appUser.Avatar
                    };
                }
                else
                {
                    reviewDto.Member = null; // Hoặc giá trị mặc định nếu không tìm thấy AppUser
                }

                reviewList.Add(reviewDto);
            }



            return new PageResult<ReviewDTO>
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(queries.TotalCount / (double)request.Limit),
                TotalItems = queries.TotalCount,
                Items = reviewList
            };
        }
    }
}