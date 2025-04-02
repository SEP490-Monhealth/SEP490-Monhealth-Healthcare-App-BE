using Monhealth.Application.Features.Message.Queries.GetAllMessages;

namespace Monhealth.Application.Contracts.ChatBox
{
    public interface IChatHubService
    {
        Task SendMessageAsync(MessageDto message);
        Task NotifyUserTypingAsync(Guid chatId, Guid userId, string username);
        Task NotifyMessagesReadAsync(Guid chatId, Guid userId);
    }
}
