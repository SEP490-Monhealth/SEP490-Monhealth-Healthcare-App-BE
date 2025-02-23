using MediatR;

namespace Monhealth.Application.Features.Review.Queries.GetReviewByUser
{
    public class GetReviewByUserQuery : IRequest<List<ReviewByUserDTO>>
    {
        public Guid userId { get; set; }
    }
}