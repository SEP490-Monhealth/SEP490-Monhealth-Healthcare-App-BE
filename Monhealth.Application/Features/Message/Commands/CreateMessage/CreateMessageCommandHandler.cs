using MediatR;
using Monhealth.Application.Contracts.ChatBox;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Application.Features.Message.Queries.GetAllMessages;

namespace Monhealth.Application.Features.Message.Commands.CreateMessage
{
    public class CreateMessageCommandHandler(
        IMessageRepository messageRepository,
        IChatNotificationService chatNotificationService,
        IChatRepository chatRepository,
        IUserRepository userRepository,
        IConsultantRepository consultantRepository
        ) : IRequestHandler<CreateMessageCommand, MessageDto>
    {
        public async Task<MessageDto> Handle(CreateMessageCommand request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(request.Content))
                throw new BadRequestException("Nội dung không thể rỗng");
            var chat = await chatRepository.GetChatByIdAsync(request.ChatId);
            if (chat == null)
            {
                throw new BadRequestException("Đoạn chat không tìm thấy");
            }
            var newMessage = new Domain.Message
            {
                MessageId = Guid.NewGuid(),
                ChatId = chat.ChatId,
                SenderId = request.SenderId,
                Content = request.Content,

                CreatedAt = GetCurrentVietnamTime(),
                UpdatedAt = GetCurrentVietnamTime(),

            };
            messageRepository.Add(newMessage);

            //udpate last message
            chat.UpdatedAt = GetCurrentVietnamTime();
            chat.LastMessage = request.Content;
            await messageRepository.SaveChangeAsync(cancellationToken);

            //get avatarUrl for return
            string avatarUrl = await userRepository.GetAvatarBySenderIdAsync(request.SenderId);
            var messageDto = new MessageDto
            {
                MessageId = newMessage.MessageId,
                ChatId = newMessage.ChatId,
                SenderId = newMessage.SenderId,
                Content = newMessage.Content,
                AvatarUrl = avatarUrl ?? string.Empty,
                CreatedAt = newMessage.CreatedAt,
                UpdatedAt = newMessage.UpdatedAt,
            };

            return messageDto;
        }
        private DateTime GetCurrentVietnamTime()
        {
            DateTime utcNow = DateTime.UtcNow;
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // Vietnam Time Zone
            return TimeZoneInfo.ConvertTimeFromUtc(utcNow, vietnamTimeZone);
        }
    }
}
