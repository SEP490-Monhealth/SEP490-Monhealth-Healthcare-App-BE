using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application.Features.Review.Queries
{
    public class GetReviewListQueryHandler : IRequestHandler<GetReviewListQuery, PageResult<ReviewDTO>>
    {
        private readonly IReviewRepository _reviewRepository;
        public GetReviewListQueryHandler(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public async Task<PageResult<ReviewDTO>> Handle(GetReviewListQuery request, CancellationToken cancellationToken)
        {
            var queries = await _reviewRepository
            .GetAllReviewAsync(request.Page, request.Limit, request.Rating);
            var reviewList = queries.Items.Select(r => new ReviewDTO
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