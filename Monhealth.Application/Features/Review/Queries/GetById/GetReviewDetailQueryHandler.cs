using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Review.Queries.GetById
{
    public class GetReviewDetailQueryHandler : IRequestHandler<GetReviewDetailQuery, ReviewDetailDTO>
    {
        private readonly IReviewRepository _reviewRepository;
        public GetReviewDetailQueryHandler(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public async Task<ReviewDetailDTO> Handle(GetReviewDetailQuery request, CancellationToken cancellationToken)
        {
            var query = await _reviewRepository.GetByIdAsync(request.ReviewId);
            return new ReviewDetailDTO
            {
               BookingId = query.BookingId,
               Comment = query.Comment,
               ConsultantId = query.ConsultantId,
               Rating = query.Rating,
               UserId = query.UserId
            };
        }
    }
}