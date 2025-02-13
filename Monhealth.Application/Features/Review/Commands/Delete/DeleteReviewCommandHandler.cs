using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Review.Commands.Delete
{
    public class DeleteReviewCommandHandler : IRequestHandler<DeleteReviewRequest, bool>
    {
        private readonly IReviewRepository _reviewRepository;
        public DeleteReviewCommandHandler(IReviewRepository reviewRepository)
        {
            _reviewRepository  = reviewRepository;
        }

        public async Task<bool> Handle(DeleteReviewRequest request, CancellationToken cancellationToken)
        {
            var id = await _reviewRepository.GetByIdAsync(request.ReviewId);
            _reviewRepository.Remove(id);
            await _reviewRepository.SaveChangeAsync();
            return true;
        }
    }
}