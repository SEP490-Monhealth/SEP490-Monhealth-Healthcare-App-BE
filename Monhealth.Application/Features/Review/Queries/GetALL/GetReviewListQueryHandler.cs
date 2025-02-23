using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Review.Queries
{
    public class GetReviewListQueryHandler : IRequestHandler<GetReviewListQuery, List<ReviewDTO>>
    {
        private readonly IReviewRepository _reviewRepository;
        public GetReviewListQueryHandler(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public async Task<List<ReviewDTO>> Handle(GetReviewListQuery request, CancellationToken cancellationToken)
        {
            var queries = await _reviewRepository.GetAllAsync();
            return queries.Select(r => new ReviewDTO
            {
                ReviewId = r.ReviewId,
                BookingId = r.BookingId,
                Comment = r.Comment,
                ConsultantId = r.ConsultantId,
                CreatedAt = r.CreatedAt,
                UpdatedAt = r.UpdatedAt,
                Rating = r.Rating,
                UserId = r.UserId,
            }).ToList();
        }
    }
}