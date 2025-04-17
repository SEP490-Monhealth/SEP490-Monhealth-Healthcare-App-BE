using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Notification
{
    public interface ISystemNotificationService
    {
        Task NotifyNewConsultantRegistrationAsync(Consultant consultant, CancellationToken cancellationToken);
        Task NotifyNewBookingAsync(Booking booking, CancellationToken cancellationToken);
        Task NotifyBookingUpdateAsync(Booking booking, CancellationToken cancellationToken);
        Task NotifySubscriptionPurchaseAsync(Transaction transaction, Subscription subscription);
    }
}
