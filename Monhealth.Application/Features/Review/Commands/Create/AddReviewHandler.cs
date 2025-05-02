using MediatR;
using Monhealth.Application.Contracts.Notification;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.Review.Commands.Create
{
    public class AddReviewHandler : IRequestHandler<AddReviewRequest, Unit>
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IConsultantRepository _consultantRepository;
        private readonly IBookingRepository bookingRepository;
        private readonly ISystemNotificationService systemNotificationService;

        public AddReviewHandler(IReviewRepository reviewRepository,
            IConsultantRepository consultantRepository,
            IBookingRepository bookingRepository,
            ISystemNotificationService systemNotificationService
            )
        {
            _reviewRepository = reviewRepository;
            _consultantRepository = consultantRepository;
            this.bookingRepository = bookingRepository;
            this.systemNotificationService = systemNotificationService;
        }

        public async Task<Unit> Handle(AddReviewRequest request, CancellationToken cancellationToken)
        {
            var booking = await bookingRepository.GetByIdAsync(request.BookingId)
            ?? throw new BadRequestException($"Không tìm thấy lịch hẹn {request.BookingId}");
            if (booking.IsReviewed) throw new BadRequestException($"Lịch hẹn này đã được đánh giá rồi");
            booking.IsReviewed = true;


            var vietNamTimeNow = GetCurrentVietnamTime();
            var review = new Domain.Review
            {
                BookingId = request.BookingId,
                UserId = request.UserId,
                Rating = request.Rating,
                Comment = request.Comment,
                CreatedAt = vietNamTimeNow,
                UpdatedAt = vietNamTimeNow
            };

            _reviewRepository.Add(review);

            var consultantId = booking.ConsultantId;
            if (consultantId.HasValue)
            {
                var consultant = await _consultantRepository.GetByIdAsync(consultantId.Value);
                if (consultant != null)
                {
                    consultant.RatingCount += 1;

                    consultant.AverageRating = Math.Round(
                        ((consultant.AverageRating * (consultant.RatingCount - 1)) + request.Rating) / consultant.RatingCount,
                        1,
                        MidpointRounding.AwayFromZero
                    );
                }
            }
            await _reviewRepository.SaveChangeAsync();

            //notify consultant for new review
            await systemNotificationService.NotifyConsultantAboutNewReviewAsync(review, booking, cancellationToken);

            return Unit.Value;
        }
        private DateTime GetCurrentVietnamTime()
        {
            DateTime utcNow = DateTime.UtcNow;
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // Vietnam Time Zone
            return TimeZoneInfo.ConvertTimeFromUtc(utcNow, vietnamTimeZone);
        }
    }
}