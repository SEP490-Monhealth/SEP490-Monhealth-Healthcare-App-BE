using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Review.Commands.Create
{
    public class AddReviewHandler : IRequestHandler<AddReviewRequest, Unit>
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IConsultantRepository _consultantRepository;
        private readonly IBookingRepository bookingRepository;

        public AddReviewHandler(IReviewRepository reviewRepository, IConsultantRepository consultantRepository, IBookingRepository bookingRepository)
        {
            _reviewRepository = reviewRepository;
            _consultantRepository = consultantRepository;
            this.bookingRepository = bookingRepository;
        }



        public async Task<Unit> Handle(AddReviewRequest request, CancellationToken cancellationToken)
        {
            var model = new Monhealth.Domain.Review
            {
                BookingId = request.BookingId,
                UserId = request.UserId,
                Rating = request.Rating,
                Comment = request.Comment,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            _reviewRepository.Add(model);
            var booking = await bookingRepository.GetByIdAsync(request.BookingId);
            if (booking != null)
                booking.IsReviewed = true;
            var consultantId = booking.ConsultantId;
            if(consultantId.HasValue)
            {
                var consultant = await _consultantRepository.GetByIdAsync(consultantId.Value);
                if (consultant != null)
                {
                    consultant.RatingCount += 1;
                    consultant.AverageRating = (request.Rating + consultant.AverageRating) / 2;
                }
            }          
            await _reviewRepository.SaveChangeAsync();
            return Unit.Value;
        }
    }
}