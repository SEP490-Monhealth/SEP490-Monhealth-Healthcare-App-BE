using MediatR;
using Monhealth.Application.Contracts.ChatBox;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Message.Commands.CreateMessage
{
    public class CreateMessageCommandHandler(IMessageRepository messageRepository,
        IChatNotificationService chatNotificationService
        ) : IRequestHandler<CreateMessageCommand>
    {
        public async Task<Unit> Handle(CreateMessageCommand request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(request.content))
                throw new ArgumentException("Nội dung không thể rỗng");
            var newMessage = new Domain.Message
            {
                MessageId = Guid.NewGuid(),
                ChatId = request.chatId,
                SenderId = request.senderId,
                ReceiverId = request.receiverId,
                Content = request.content,
                CreatedAt = DateTime.UtcNow
            };
            messageRepository.Add(newMessage);
            await messageRepository.SaveChangeAsync();

            await chatNotificationService.NotifyNewMessageAsync(request.chatId, request.senderId, request.content);

            return Unit.Value;
        }
    }
}
