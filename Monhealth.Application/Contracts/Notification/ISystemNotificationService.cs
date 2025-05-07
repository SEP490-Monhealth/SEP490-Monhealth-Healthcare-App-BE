using Monhealth.Domain;
using Monhealth.Identity.Models;

namespace Monhealth.Application.Contracts.Notification
{
    public interface ISystemNotificationService
    {
        Task NotifyNewConsultantRegistrationAsync(Guid userId, CancellationToken cancellationToken);
        Task NotifyNewBookingAsync(Booking booking, CancellationToken cancellationToken);
        Task NotifyBookingUpdateAsync(Booking booking, CancellationToken cancellationToken);
        Task NotifySubscriptionPurchaseAsync(Transaction transaction, UserSubscription userSubscription, CancellationToken cancellationToken);
        Task NotifySubscriptionBuySingleBooking(Transaction transaction, CancellationToken cancellationToken);
        Task NotifyNewUserSessionAsync(AppUser user);
        Task NotifyBookingCompleteForBoth(Booking booking, CancellationToken cancellationToken);
        Task NotifyCreateMetricSuccessfully(Guid userId, CancellationToken cancellationToken);
        Task SendRejectedScheduleExceptionForConsultant(Consultant consultant, CancellationToken cancellationToken);
        Task NotifyScheduleExceptionApprovedAsync(Booking booking, CancellationToken cancellationToken);
        Task NotifyUpComingBookingReminderAsync(Booking booking, CancellationToken cancellationToken);
        Task NotifyConsultantAboutNewReviewAsync(Review review, Booking booking, CancellationToken cancellationToken);
        Task NotifyUserReportApprovedAsync(Report report, CancellationToken cancellation);
        Task NotifyUserReportRejectedAsync(Report report, CancellationToken cancellation);
        Task NotifyWaterReminderNotificationAsync(WaterReminder waterReminder, CancellationToken cancellationToken);
        Task NotifyConsultantStatusUpdateAsync(Consultant consultant, CancellationToken cancellationToken);
        Task NotifyConsultantVerificationAsync(Consultant consultant, CancellationToken cancellationToken);
        Task NotifyConsultantRejectionAsync(Consultant consultant, CancellationToken cancellationToken);
        Task NotifyGoalCompletionAsync(Goal goal, CancellationToken cancellationToken);
        Task NotifyGoalAbandonedAsync(Goal goal, CancellationToken cancellationToken);
        Task NotifyUpdateMetricSuccessfully(Guid userId, CancellationToken cancellationToken);
        Task NotifyUserCreateReportSuccessfully(Report report, Guid userId, CancellationToken cancellationToken);
        Task NotifyConsultantOnExceptionCreatedAsync(Guid consultantId, ScheduleException scheduleException, CancellationToken cancellationToken);
        Task NotifyConsultantHasNewIncomeAsync(Transaction transaction, CancellationToken cancellationToken);
        Task NotifyWithdrawalApprovedAsync(Transaction transaction, CancellationToken cancellationToken);
        Task NotifyWithdrawalRequestSubmittedAsync(WithdrawalRequest withdrawalRequest, CancellationToken cancellationToken);
        Task NotifyWithdrawalRequestRejectedAsync(WithdrawalRequest withdrawalRequest, CancellationToken cancellationToken);
        Task NotifyNewChatFromMemberAsync(Chat chat, CancellationToken cancellationToken);
        Task NotifyConsultantStatusChangedAsync(Consultant consultant, CancellationToken cancellationToken);
    }
}
