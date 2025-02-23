using MediatR;

namespace Monhealth.Application.Features.Review.Commands.Update
{
    public class UpdateReviewCommand : IRequest<bool>
    {
        public Guid ReviewId { get; set; }
        public UpdateReviewRequest Request { get; set; }
        public UpdateReviewCommand(Guid reviewId, UpdateReviewRequest request)
        {
            ReviewId = reviewId;
            Request = request;
        }
    }
}