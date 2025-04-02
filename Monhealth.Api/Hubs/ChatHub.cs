using Microsoft.AspNetCore.SignalR;

namespace Monhealth.Api.Hubs
{
    public class ChatHub : Hub
    {
        // Đảm bảo biến static được khởi tạo đúng cách
        private static readonly List<ChatMessage> _messageHistory = new List<ChatMessage>();

        // Định nghĩa lớp ChatMessage
        public class ChatMessage
        {
            public string Sender { get; set; } = string.Empty;
            public string Content { get; set; } = string.Empty;
            public DateTime Timestamp { get; set; } = DateTime.Now;
        }

        // Phương thức lấy lịch sử tin nhắn khi kết nối
        public List<ChatMessage> GetMessageHistory()
        {
            return _messageHistory;
        }

        // Phương thức gửi tin nhắn
        public async Task SendMessage(string user, string message)
        {
            try
            {
                // Tạo đối tượng tin nhắn mới với kiểm tra null
                var chatMessage = new ChatMessage
                {
                    Sender = user ?? "Unknown",
                    Content = message ?? "",
                    Timestamp = DateTime.UtcNow
                };

                // Thêm vào lịch sử - đảm bảo _messageHistory không null
                _messageHistory.Add(chatMessage);

                // Giới hạn số lượng tin nhắn lưu trữ
                if (_messageHistory.Count > 100)
                {
                    _messageHistory.RemoveAt(0);
                }

                // Gửi tin nhắn đến tất cả client
                await Clients.All.SendAsync("ReceiveMessage", chatMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SendMessage: {ex.Message}");
                throw;
            }
        }

        // Phương thức được gọi khi client kết nối
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

        // Phương thức được gọi khi client ngắt kết nối
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
                throw;
            }
        }
    }
}