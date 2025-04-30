
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Infrastructure.JobServices
{
    public class HangFireJobServices(IBookingRepository bookingRepository,
        ILogger<HangFireJobServices> logger
        ) : IHangFireJobServices
    {
        public async Task HandleAutoUpdateReviewStatusAsync(Guid bookingId)
        {
            var booking = await bookingRepository.GetByIdAsync(bookingId);

            // Kiểm tra xem booking đã được review chưa
            if (booking != null && !booking.IsReviewed && !booking.Reviews.Any())
            {
                booking.IsReviewed = true;
                await bookingRepository.SaveChangeAsync();
            }
        }
    }
}
