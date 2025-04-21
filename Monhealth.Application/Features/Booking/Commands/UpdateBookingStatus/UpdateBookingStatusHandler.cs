using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Booking.Commands.UpdateBookingStatus
{
    public class UpdateBookingStatusHandler(IBookingRepository bookingRepository,
        IConsultantRepository consultantRepository,
        IUserSubscriptionRepository userSubscriptionRepository,
        ITransactionRepository transactionRepository,
        IWalletRepository walletRepository
        )
        : IRequestHandler<UpdateBookingStatusCommand, bool>
    {
        public async Task<bool> Handle(UpdateBookingStatusCommand request, CancellationToken cancellationToken)
        {
            var booking = await bookingRepository.GetByIdAsync(request.BookingId);
            if (booking == null) throw new BadRequestException("Không tìm thấy lịch hẹn");
            if (booking.Status == BookingStatus.Completed) throw new BadRequestException("Không thể cập nhập lịch đã hoàn thành");

            if (booking.Status == BookingStatus.Cancelled) throw new BadRequestException("Không thể cập nhập lịch đã hủy");
            else if (booking.Status == BookingStatus.Confirmed)
            {
                var earnMoney = 200000;
                var wallet = await walletRepository.GetWalletByConsultantId((Guid)booking.ConsultantId);
                if (wallet == null) throw new BadRequestException("Không tìm thấy ví của tư vấn viên");
                //create transaction 
                var newTransaction = new Domain.Transaction
                {
                    UserId = booking.ConsultantId,
                    WalletId = wallet.WalletId,
                    BookingId = booking.BookingId,
                    TransactionType = TransactionType.Earning,
                    Description = "Thanh toán cho lịch hẹn đã hoàn thành",
                    Amount = earnMoney,
                    Status = StatusTransaction.Pending,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                };
                transactionRepository.Add(newTransaction);

                booking.CompletedAt = DateTime.Now;
                booking.Status = BookingStatus.Completed;

                //
            }
            booking.UpdatedAt = DateTime.Now;
            await bookingRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
