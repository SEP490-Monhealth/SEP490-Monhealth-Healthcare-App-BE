using Microsoft.AspNetCore.SignalR;
using Monhealth.Domain;

namespace Monhealth.Api.Hubs
{
    public class ChatHub : Hub
    {
        private static readonly List<Message> _messageHistory = new List<Message>();

        public List<Message> GetMessageHistory()
        {
            return _messageHistory;
        }

        // Sửa đổi để nhận đối tượng message thay vì các tham số riêng lẻ
        public async Task SendMessage(MessageRequest message)
        {
            try
            {
                // Tạo đối tượng tin nhắn mới từ request
                var chatMessage = new Message
                {
                    MessageId = Guid.NewGuid(),
                    ChatId = message.ChatId,
                    SenderId = message.SenderId,
                    Content = message.Content ?? "",
                    IsRead = false,
                    CreatedAt = DateTime.UtcNow
                };

                _messageHistory.Add(chatMessage);

                if (_messageHistory.Count > 100)
                {
                    _messageHistory.RemoveAt(0);
                }

                await Clients.All.SendAsync("ReceiveMessage", chatMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SendMessage: {ex.Message}");
                throw;
            }
        }

        public override async Task OnConnectedAsync()
        {
            try
            {
                await Clients.Caller.SendAsync("LoadMessageHistory", _messageHistory);
                await Clients.Others.SendAsync("UserConnected", Context.ConnectionId);
                await base.OnConnectedAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in OnConnectedAsync: {ex.Message}");
                throw;
            }
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            try
            {
                await Clients.All.SendAsync("UserDisconnected", Context.ConnectionId);
                await base.OnDisconnectedAsync(exception);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in OnDisconnectedAsync: {ex.Message}");
                await Clients.Caller.SendAsync("ErrorOccurred", ex.Message);
                throw;
            }
        }
    }

    // Thêm class này để đại diện cho request từ client
    public class MessageRequest
    {
        public Guid ChatId { get; set; }
        public Guid SenderId { get; set; }
        public string Content { get; set; }
    }
}