using MediatR;

namespace Monhealth.Application.Features.Review.Queries
{
    public class GetReviewListQuery : IRequest<List<ReviewDTO>>
    {
        
    }
}