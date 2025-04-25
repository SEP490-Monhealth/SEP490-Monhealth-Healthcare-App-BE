using Microsoft.AspNetCore.SignalR;
using Monhealth.Api.Hubs;
using Monhealth.Application.Contracts.ChatBox;

namespace Monhealth.Api.Services
{
    public class ChatNotificationService(IHubContext<ChatHub> hubContext) : IChatNotificationService
    {
        public async Task NotifyNewMessageAsync(Guid chatId, Guid senderId, string content)
        {
            await hubContext.Clients.Group(chatId.ToString()).SendAsync("ReceiveMessage", new
            {
                ChatId = chatId,
                SenderId = senderId,
                Content = content,
                Timestamp = DateTime.UtcNow
            });
        }
    }
}
