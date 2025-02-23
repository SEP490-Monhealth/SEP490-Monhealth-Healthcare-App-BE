using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Review.Queries.GetReviewByConsultant
{
    public class GetReviewByConsultantQueryHandler : IRequestHandler<GetReviewByConsultantQuery, List<ReviewByConsultantDTO>>
    {
        private readonly IReviewRepository _reviewRepository;
        public GetReviewByConsultantQueryHandler(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public async Task<List<ReviewByConsultantDTO>> Handle(GetReviewByConsultantQuery request, CancellationToken cancellationToken)
        {
            var queries = await _reviewRepository.GetReviewsByConsultant(request.ConsultantId);
            return queries.Select(r => new ReviewByConsultantDTO{
                BookingId = r.BookingId,
                Comment = r.Comment,
                UserId = r.UserId,
                CreatedAt = r.CreatedAt,
                UpdatedAt = r.UpdatedAt,
                Rating = r.Rating,
            }).ToList();
        }
    }
}