using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Review.Queries.GetReviewByUser
{
    public class GetReviewByUserQueryHandler : IRequestHandler<GetReviewByUserQuery, List<ReviewByUserDTO>>
    {
        private readonly IReviewRepository _reviewRepository;
        public GetReviewByUserQueryHandler(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public async Task<List<ReviewByUserDTO>> Handle(GetReviewByUserQuery request, CancellationToken cancellationToken)
        {
            var queries = await _reviewRepository.GetReviewsByUser(request.userId);
            return queries.Select(r => new ReviewByUserDTO
            {
                BookingId = r.BookingId,
                Comment = r.Comment,
                CreatedAt = r.CreatedAt,
                UpdatedAt = r.UpdatedAt,
                Rating = r.Rating,
            }).ToList();
        }
    }
}