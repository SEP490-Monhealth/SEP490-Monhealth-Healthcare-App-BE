using Hangfire;
using MediatR;
using Monhealth.Application.Contracts.Notification;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Booking.Commands.UpdateEvidensForConsultant
{
    public class UpdateEvidensForConsultantCommandHandler(IBookingRepository bookingRepository,
        ITransactionRepository transactionRepository,
        ISystemNotificationService systemNotificationService
        )
        : IRequestHandler<UpdateEvidensForConsultantCommand, bool>
    {
        public async Task<bool> Handle(UpdateEvidensForConsultantCommand request, CancellationToken cancellationToken)
        {
            const float BOKING_MONEY = 200000;

            var booking = await bookingRepository.GetBookingByBookingIdAsync(request.BookingId)
            ?? throw new BadRequestException($"Không tìm thấy lịch hẹn {request.BookingId}");

            if (request.UpdateEvidensDto.EvidenceUrls == null || request.UpdateEvidensDto.EvidenceUrls.Count == 0)
            {
                throw new BadRequestException("Danh sách URL không được để trống");
            }

            foreach (var url in request.UpdateEvidensDto.EvidenceUrls)
            {
                if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
                {
                    throw new BadRequestException($"URL '{url}' không hợp lệ");
                }
            }

            booking.EvidenceUrls = request.UpdateEvidensDto.EvidenceUrls;

            //create transaction
            var newTransaction = new Domain.Transaction
            {
                TransactionId = Guid.NewGuid(),
                ConsultantId = booking.ConsultantId,
                BookingId = booking.BookingId,
                TransactionType = TransactionType.Earning,
                Description = "Thanh toán hoàn thành lịch hẹn",
                Amount = BOKING_MONEY,
                Status = StatusTransaction.Pending,
                CreatedAt = GetCurrentVietnamTime(),
                UpdatedAt = GetCurrentVietnamTime(),
            };
            transactionRepository.Add(newTransaction);

            booking.UpdatedAt = GetCurrentVietnamTime();
            booking.CompletedAt = GetCurrentVietnamTime();
            booking.Status = BookingStatus.Completed;

            //notify for both user and consultant done booking
            //await systemNotificationService.NotifyBookingCompleteForBoth(booking, cancellationToken);

            await bookingRepository.SaveChangeAsync(cancellationToken);

            //add 3 days to check is Review field
            BackgroundJob.Schedule<UpdateEvidensForConsultantCommandHandler>(service =>
                service.AutoUpdateReviewStatusAsync(booking.BookingId),
                    TimeSpan.FromDays(3));

            return true;
        }
        private DateTime GetCurrentVietnamTime()
        {
            DateTime utcNow = DateTime.UtcNow;
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // Vietnam Time Zone
            return TimeZoneInfo.ConvertTimeFromUtc(utcNow, vietnamTimeZone);
        }
        public async Task AutoUpdateReviewStatusAsync(Guid bookingId)
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
