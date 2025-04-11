using MediatR;
using Microsoft.AspNetCore.SignalR;
using Monhealth.Domain;

namespace Monhealth.Api.Hubs
{
    public class ChatHub(IMediator mediator) : Hub
    {
        private static readonly List<Message> _messageHistory = new();
        // Sửa đổi để nhận đối tượng message thay vì các tham số riêng lẻ
        public async Task SendMessage(MessageRequest message)
        {
            //try
            //{
            //    // Tạo đối tượng tin nhắn mới từ request
            //    var command = new CreateMessageCommand
            //    {
            //        ChatId = message.ChatId,
            //        SenderId = message.SenderId,
            //        Content = message.Content,
            //    };
            //    await mediator.Send(command);
            //    await Clients.All.SendAsync("ReceiveMessage", command);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error in SendMessage: {ex.Message}");
            //    throw;
            //}
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