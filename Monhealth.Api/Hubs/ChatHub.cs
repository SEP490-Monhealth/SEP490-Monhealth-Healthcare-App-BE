using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace Monhealth.Api.Hubs
{
    [Authorize]
    public class ChatHub : Hub
    {
        public async Task JoinChat(Guid chatId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, chatId.ToString());
        }

        public async Task LeaveChat(Guid chatId)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, chatId.ToString());
        }

        public async Task SendMessage(Guid chatId, Guid senderId, string message)
        {
            // Gửi message đến tất cả client thuộc group chat này
            await Clients.Group(chatId.ToString()).SendAsync("ReceiveMessage", new
            {
                ChatId = chatId,
                SenderId = senderId,
                Content = message,
                Timestamp = DateTime.UtcNow
            });
        }
    }
}
