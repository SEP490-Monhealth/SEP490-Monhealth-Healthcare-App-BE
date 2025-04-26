using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Report.Commands.ChangeStatusReportToApproved
{
    public class ChangeStatusReportToApprovedCommandHandler(IReportRepository reportRepository
    , IBookingRepository bookingRepository, IUserSubscriptionRepository userSubscriptionRepository,
    ITransactionRepository transactionRepository) 
    : IRequestHandler<ChangeStatusReportToApprovedCommand, bool>
    {
        public async Task<bool> Handle(ChangeStatusReportToApprovedCommand request, CancellationToken cancellationToken)
        {
            var report = await reportRepository.GetByIdAsync(request.ReportId);
            var booking = await bookingRepository.GetBookingByBookingIdAsync(report.BookingId);
            var userSubscription = await userSubscriptionRepository.GetUserSubscriptionByUser((Guid)booking.UserId);
            var transaction = await transactionRepository.GetTransactionByBookingId(booking.BookingId);
            if (report == null)
            {
                return false;
            }
            if (report.Status == StatusReport.Pending)
            {
                report.Status = StatusReport.Approved;
                userSubscription.RemainingBookings += 1;
                transaction.Status = (StatusTransaction?)StatusReport.Rejected;
            }
            else
            {
                throw new Exception($"Không thể chấp nhận, trạng thái đang là {report.Status}.");
            }
            reportRepository.Update(report);
            await reportRepository.SaveChangeAsync();
            return true;
        }
    }
}
