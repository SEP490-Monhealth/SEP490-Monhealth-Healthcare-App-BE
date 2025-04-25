using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Review.Commands.Update
{
    public class UpdateReviewCommandHandler : IRequestHandler<UpdateReviewCommand, bool>
    {
        private readonly IReviewRepository _reviewRepository;
        public UpdateReviewCommandHandler(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public async Task<bool> Handle(UpdateReviewCommand request, CancellationToken cancellationToken)
        {
            var update = await _reviewRepository.GetByIdAsync(request.ReviewId);
            update.Comment = request.Request?.Comment;
            update.Rating = request.Request.Rating;
            update.UpdatedAt = DateTime.UtcNow;
            _reviewRepository.Update(update);
            await _reviewRepository.SaveChangeAsync();
            return true;
        }
    }
}