using Monhealth.Domain;
using Monhealth.Identity.Models;

namespace Monhealth.Application.Contracts.Notification
{
    public interface ISystemNotificationService
    {
        Task NotifyNewConsultantRegistrationAsync(Consultant consultant, CancellationToken cancellationToken);
        Task NotifyNewBookingAsync(Booking booking, CancellationToken cancellationToken);
        Task NotifyBookingUpdateAsync(Booking booking, CancellationToken cancellationToken);
        Task NotifySubscriptionPurchaseAsync(Transaction transaction, UserSubscription userSubscription, CancellationToken cancellationToken);
        Task NotifySubscriptionBuySingleBooking(Transaction transaction, CancellationToken cancellationToken);
        Task NotifyNewUserSessionAsync(AppUser user);
        Task NotifyBookingCompleteForBoth(Booking booking, CancellationToken cancellationToken);
        Task NotifyCreateMetricSuccessfully(Guid userId, CancellationToken cancellationToken);

        Task SendBookingCancellationNotificationAsync(Booking booking, CancellationToken cancellationToken);
    }
}
