using MediatR;
using Monhealth.Application.Contracts.ChatBox;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Application.Features.Message.Queries.GetAllMessages;

namespace Monhealth.Application.Features.Message.Commands.CreateMessage
{
    public class CreateMessageCommandHandler(IMessageRepository messageRepository,
        IChatNotificationService chatNotificationService,
        IChatRepository chatRepository,
        IUserRepository userRepository,
        IConsultantRepository consultantRepository,
        IChatHubService chatHubService

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
                await chatRepository.SaveChangeAsync(cancellationToken);
            }
            var newMessage = new Domain.Message
            {
                MessageId = Guid.NewGuid(),
                ChatId = chat.ChatId,
                SenderId = request.senderId,
                ReceiverId = request.receiverId,
                Content = request.content,
                CreatedAt = DateTime.Now,

            };
            messageRepository.Add(newMessage);

            //udpate last message
            chat.LastMessage = request.content;
            await messageRepository.SaveChangeAsync(cancellationToken);

            var messageDto = new MessageDto
            {
                MessageId = newMessage.MessageId,
                ChatId = newMessage.ChatId,
                SenderId = newMessage.SenderId,
                ReceiverId = newMessage.ReceiverId,
                Content = newMessage.Content,
                CreatedAt = newMessage.CreatedAt,
            };
            await chatHubService.SendMessageAsync(messageDto);
            return Unit.Value;
        }
    }
}
