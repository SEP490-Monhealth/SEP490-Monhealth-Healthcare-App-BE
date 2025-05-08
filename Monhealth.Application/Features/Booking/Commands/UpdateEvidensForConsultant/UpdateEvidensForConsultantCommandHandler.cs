using Hangfire;
using MediatR;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Notification;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Domain.Enum;
using Monhealth.Infrastructure.JobServices;

namespace Monhealth.Application.Features.Booking.Commands.UpdateEvidensForConsultant
{
    public class UpdateEvidensForConsultantCommandHandler(IBookingRepository bookingRepository,
        ITransactionRepository transactionRepository,
        ISystemNotificationService systemNotificationService,
        ILogger<UpdateEvidensForConsultantCommandHandler> logger,
        IHangFireJobServices hangFireJobServices,
        IConsultantRepository consultantRepository
        )
        : IRequestHandler<UpdateEvidensForConsultantCommand, bool>
    {
        public async Task<bool> Handle(UpdateEvidensForConsultantCommand request, CancellationToken cancellationToken)
        {
            const float BOKING_MONEY = 200000;

            var booking = await bookingRepository.GetBookingByBookingIdAsync(request.BookingId)
            ?? throw new BadRequestException($"Không tìm thấy lịch hẹn {request.BookingId}");

            // var now = GetCurrentVietnamTime();
            // var nowDayOnly = DateOnly.FromDateTime(now);
            // var currentTimeOnly = TimeOnly.FromDateTime(now);
            // // 1. Chưa đến ngày hẹn
            // if (nowDayOnly < booking.Day)
            //      throw new BadRequestException("Chưa đến ngày hẹn, không thể hoàn thành lịch hẹn");
            // //chưa qua giờ đã hoàn thành
            // if(nowDayOnly == booking.Day){
            //      if (currentTimeOnly < booking.EndTime){
            //         throw new BadRequestException("Chưa đến giờ kết thúc lịch hẹn, không thể hoàn thành");
            //         }   
            // }

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

            //plus booking count 
            var consultant = await consultantRepository.GetConsultantByConsultantId((Guid)booking.ConsultantId);
            if (consultant != null)
            {
                consultant.BookingCount += 1;
            }

            await bookingRepository.SaveChangeAsync(cancellationToken);

            //add 3 days to check is Review field
            try
            {
                BackgroundJob.Schedule<IHangFireJobServices>(
                           job => job.HandleAutoUpdateReviewStatusAsync(booking.BookingId),
                                TimeSpan.FromDays(3));
            }
            catch (Exception ex)
            {
                // Log error for debugging
                logger.LogError(ex, $"Failed to schedule background job, bookingId {booking.BookingId}");
            }
            //notify for both user and consultant done booking
            await systemNotificationService.NotifyBookingCompleteForBoth(booking, cancellationToken);
            return true;
        }
        private DateTime GetCurrentVietnamTime()
        {
            DateTime utcNow = DateTime.UtcNow;
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // Vietnam Time Zone
            return TimeZoneInfo.ConvertTimeFromUtc(utcNow, vietnamTimeZone);
        }


    }

}
