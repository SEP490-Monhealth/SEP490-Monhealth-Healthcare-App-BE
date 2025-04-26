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
            float bookingMoney = 200000;
            var newTransaction = new Domain.Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = booking.ConsultantId,
                BookingId = booking.BookingId,
                TransactionType = TransactionType.Earning,
                Description = "Thanh toán hoàn thành lịch hẹn",
                Amount = bookingMoney,
                Status = StatusTransaction.Pending,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            transactionRepository.Add(newTransaction);

            booking.UpdatedAt = DateTime.Now;
            booking.CompletedAt = DateTime.Now;
            booking.Status = BookingStatus.Completed;

            //notify for both user and consultant done booking
            await systemNotificationService.NotifyBookingCompleteForBoth(booking, cancellationToken);

            await bookingRepository.SaveChangeAsync(cancellationToken);
            return true;
        }

    }
}
