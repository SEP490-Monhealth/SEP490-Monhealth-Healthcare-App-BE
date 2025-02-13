using MediatR;

namespace Monhealth.Application.Features.Review.Commands.Delete
{
    public class DeleteReviewRequest : IRequest<bool>
    {
        public Guid ReviewId { get; set; }
        public DeleteReviewRequest(Guid reviewId)
        {
            ReviewId = reviewId;
        }
    }
}