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
            var chat = await chatRepository.GetChatBySenderIdAndReceiverId(request.senderId, request.receiverId);
            if (chat == null)
            {
                chat = new Domain.Chat
                {
                    ChatId = Guid.NewGuid(),
                    UserId = request.senderId,
                    ConsultantId = request.receiverId,
                    LastMessage = request.content,
                    Messages = new List<Domain.Message>()
                };
                chatRepository.Add(chat);

            }
            var newMessage = new Domain.Message
            {
                MessageId = Guid.NewGuid(),
                ChatId = chat.ChatId,
                SenderId = request.senderId,
                ReceiverId = request.receiverId,
                Content = request.content,
                CreatedAt = DateTime.UtcNow
            };
            messageRepository.Add(newMessage);
            await messageRepository.SaveChangeAsync(cancellationToken);

            await chatNotificationService.NotifyNewMessageAsync(chat.ChatId, request.senderId, request.content);

            return Unit.Value;
        }
    }
}
