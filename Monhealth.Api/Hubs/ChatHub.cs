using MediatR;
using Microsoft.AspNetCore.SignalR;
using Monhealth.Domain;
using System.Collections.Concurrent;

namespace Monhealth.Api.Hubs
{
    public class ChatHub(IMediator mediator) : Hub
    {
        private static readonly List<Message> _messageHistory = new();
        private static readonly ConcurrentDictionary<string, Guid> _connectionMapping = new();
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
        //public async Task JoinChat(Guid chatId)
        //{
        //    try
        //    {
        //        var userId = Context.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        //        // Lưu mapping giữa connectionId và userId
        //        _connectionMapping[Context.ConnectionId] = userId;

        //        // Thêm vào group tương ứng với chatId
        //        await Groups.AddToGroupAsync(Context.ConnectionId, chatId.ToString());

        //        // Gửi thông báo cho group là có người tham gia
        //        await Clients.Group(chatId.ToString()).SendAsync("UserJoined", userId);

        //        // Lấy lịch sử tin nhắn từ database
        //        var query = new GetMessageHistoryQuery { ChatId = chatId };
        //        var messageHistory = await _mediator.Send(query);

        //        // Gửi lịch sử tin nhắn cho người dùng vừa tham gia
        //        await Clients.Caller.SendAsync("LoadMessageHistory", messageHistory);
        //    }
        //    catch (Exception ex)
        //    {
        //        await Clients.Caller.SendAsync("ErrorOccurred", $"Error joining chat: {ex.Message}");
        //    }
        //}
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