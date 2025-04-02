using Microsoft.AspNetCore.SignalR;
using Monhealth.Application.Contracts.ChatBox;
using Monhealth.Application.Features.Message.Queries.GetAllMessages;

namespace Monhealth.Api.Hubs
{
    public class ChatHubService(IHubContext<ChatHub> hubContext,
        IUserConnectionManager userConnectionManager)

        : IChatHubService
    {
        public async Task NotifyMessagesReadAsync(Guid chatId, Guid userId)
        {
            await hubContext.Clients.Group(chatId.ToString())
                           .SendAsync("MessagesRead", chatId, userId);
        }

        public async Task NotifyUserTypingAsync(Guid chatId, Guid userId, string username)
        {
            await hubContext.Clients.Group(chatId.ToString())
                           .SendAsync("UserTyping", userId, username);
        }

        public async Task SendMessageAsync(MessageDto message)
        {
            //// Gửi tin nhắn đến người nhận
            //var receiverConnections = userConnectionManager.GetConnections(message.ReceiverId);
            //if (receiverConnections != null && receiverConnections.Any())
            //{
            //    await hubContext.Clients.Clients(receiverConnections).SendAsync("ReceiveMessage", message);
            //}

            // Gửi xác nhận đến người gửi
            var senderConnections = userConnectionManager.GetConnections(message.SenderId);
            if (senderConnections != null && senderConnections.Any())
            {
                await hubContext.Clients.Clients(senderConnections).SendAsync("MessageSent", message);
            }

            // Gửi tin nhắn đến tất cả người dùng đang tham gia chat này
            await hubContext.Clients.Group(message.ChatId.ToString()).SendAsync("ReceiveMessage", message);
        }
    }
}
