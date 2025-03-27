using Microsoft.AspNetCore.SignalR;

namespace Monhealth.Identity.Services
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(Guid chatId, Guid senderId, Guid receiverId, string content)
        {
            // Validate message and user permissions
            await Clients.Group(chatId.ToString()).SendAsync("ReceiveMessage", new
            {
                ChatId = chatId,
                SenderId = senderId,
                Content = content,
                Timestamp = DateTime.UtcNow
            });
        }

        public async Task JoinChat(Guid chatId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, chatId.ToString());
        }

        public async Task LeaveChat(Guid chatId)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, chatId.ToString());
        }

        public override async Task OnConnectedAsync()
        {
            // Optional: Add custom connection logic
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            // Optional: Add cleanup or logging
            await base.OnDisconnectedAsync(exception);
        }
    }
}
