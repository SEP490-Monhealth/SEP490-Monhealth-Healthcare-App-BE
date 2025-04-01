namespace Monhealth.Application.Contracts.ChatBox
{
    public interface IChatNotificationService
    {
        Task NotifyNewMessageAsync(Guid chatId, Guid senderId, string content);
    }
}
