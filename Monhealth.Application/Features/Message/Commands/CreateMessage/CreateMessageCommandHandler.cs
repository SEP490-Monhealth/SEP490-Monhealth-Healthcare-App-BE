using MediatR;
using Monhealth.Application.Contracts.ChatBox;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.Message.Commands.CreateMessage
{
    public class CreateMessageCommandHandler(IMessageRepository messageRepository,
        IChatNotificationService chatNotificationService,
        IChatRepository chatRepository
        ) : IRequestHandler<CreateMessageCommand, Unit>
    {
        public async Task<Unit> Handle(CreateMessageCommand request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(request.content))
                throw new BadRequestException("Nội dung không thể rỗng");
            var chat = await chatRepository.GetChatByIdAsync(request.chatId);
            if (chat == null)
                throw new BadRequestException($"Đoạn hội thoại {request.chatId} không tìm thấy");
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
            await messageRepository.SaveChangeAsync(cancellationToken);

            await chatNotificationService.NotifyNewMessageAsync(request.chatId, request.senderId, request.content);

            return Unit.Value;
        }
    }
}
