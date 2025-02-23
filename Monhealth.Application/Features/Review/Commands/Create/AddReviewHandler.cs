using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Review.Commands.Create
{
    public class AddReviewHandler : IRequestHandler<AddReviewRequest, Unit>
    {
        private readonly IReviewRepository _reviewRepository;
        public AddReviewHandler(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }



        public async Task<Unit> Handle(AddReviewRequest request, CancellationToken cancellationToken)
        {
            var model = new Monhealth.Domain.Review
            {
                BookingId = request.BookingId,
                UserId = request.UserId,
                ConsultantId = request.ConsultantId,
                Rating = request.Rating,
                Comment = request.Comment,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            _reviewRepository.Add(model);
            await _reviewRepository.SaveChangeAsync();
            return Unit.Value;
        }
    }
}