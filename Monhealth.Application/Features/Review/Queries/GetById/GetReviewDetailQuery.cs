using MediatR;

namespace Monhealth.Application.Features.Review.Queries.GetById
{
    public class GetReviewDetailQuery : IRequest<ReviewDetailDTO>
    {
        public Guid ReviewId { get; set; }
    }
}