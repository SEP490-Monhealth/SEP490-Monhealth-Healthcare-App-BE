using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using Monhealth.Application.Contracts.ChatBox;

namespace Monhealth.Api.Hubs
{
    [Authorize]
    public class ChatHub(IUserConnectionManager userConnectionManager) : Hub
    {
        public override async Task OnConnectedAsync()
        {
            var userId = Context.GetHttpContext().Request.Query["userId"];

            if (!string.IsNullOrEmpty(userId))
            {
                userConnectionManager.AddConnection(Guid.Parse(userId), Context.ConnectionId);
            }

            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            var userId = Context.GetHttpContext().Request.Query["userId"];

            if (!string.IsNullOrEmpty(userId))
            {
                userConnectionManager.RemoveConnection(Guid.Parse(userId), Context.ConnectionId);
            }

            await base.OnDisconnectedAsync(exception);
        }
        public async Task JoinChat(Guid chatId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, chatId.ToString());
        }

        public async Task LeaveChat(Guid chatId)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, chatId.ToString());
        }

        public async Task UserTyping(Guid chatId, Guid userId, string username)
        {
            await Clients.Group(chatId.ToString()).SendAsync("UserTyping", userId, username);
        }
    }
}
