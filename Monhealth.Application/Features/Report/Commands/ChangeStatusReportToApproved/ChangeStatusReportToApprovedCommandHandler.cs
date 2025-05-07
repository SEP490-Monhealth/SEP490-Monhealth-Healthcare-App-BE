using MediatR;
using Monhealth.Application.Contracts.Notification;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Report.Commands.ChangeStatusReportToApproved
{
    public class ChangeStatusReportToApprovedCommandHandler(IReportRepository reportRepository
    , IBookingRepository bookingRepository, IUserSubscriptionRepository userSubscriptionRepository,
    ITransactionRepository transactionRepository,
    ISystemNotificationService systemNotificationService,
    IConsultantRepository consultantRepository
    )
    : IRequestHandler<ChangeStatusReportToApprovedCommand, bool>
    {
        public async Task<bool> Handle(ChangeStatusReportToApprovedCommand request, CancellationToken cancellationToken)
        {
            var report = await reportRepository.GetByIdAsync(request.ReportId)
                ?? throw new BadRequestException(@"Không tìm thấy báo cáo {request.ReportId}");
            var booking = await bookingRepository.GetBookingByBookingIdAsync(report.BookingId)
                 ?? throw new BadRequestException(@"Không tìm thấy lịch hẹn {request.BookingId}");
            var userSubscription = await userSubscriptionRepository.GetUserSubscriptionByUser((Guid)booking.UserId)
                 ?? throw new BadRequestException(@"Không tìm thấy gói người dùng {booking.UserId}");

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

                // Check if this is the second report for this consultant in the current month
                var currentMonth = GetCurrentVietnamTime().Month;
                var currentYear = GetCurrentVietnamTime().Year;
                var consultantId = booking.ConsultantId;

                var reportsInCurrentMonth = await reportRepository.GetApprovedReportsByConsultantIdAndMonthAsync(
                           (Guid)consultantId,
                           currentMonth,
                           currentYear);

                //check to ban consultant
                if (reportsInCurrentMonth.Count() >= 1)
                {
                    var consultant = await consultantRepository.GetByIdAsync((Guid)consultantId);
                    if (consultant != null)
                    {
                        consultant.Status = !consultant.Status;
                        consultantRepository.Update(consultant);

                        // Optionally notify consultant about status change
                        await systemNotificationService.NotifyConsultantStatusChangedAsync(consultant, cancellationToken);
                    }
                }

                //Notify user and consultant
                await systemNotificationService.NotifyUserReportApprovedAsync(report, cancellationToken);
            }
            else
            {
                throw new Exception($"Không thể chấp nhận, trạng thái đang là {report.Status}.");
            }
            reportRepository.Update(report);
            await reportRepository.SaveChangeAsync();


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
