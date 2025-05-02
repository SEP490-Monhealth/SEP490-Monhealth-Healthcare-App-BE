using MediatR;
using Monhealth.Application.Contracts.Notification;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Chat.Commands.CreateChat
{
    public class CreateChatCommandHandler(IChatRepository chatRepository,
        ISystemNotificationService systemNotificationService
        ) : IRequestHandler<CreateChatCommand, CreateChatDto>
    {
        public async Task<CreateChatDto> Handle(CreateChatCommand request, CancellationToken cancellationToken)
        {
            var chat = await chatRepository.GetChatByParticipantAsync(request.UserId, request.ConsultantId);
            if (chat == null)
            {
                var currentUtcTime = DateTime.UtcNow; // Get UTC time
                // Convert UTC time to Vietnam Time (GMT+7)
                TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // Vietnam Time Zone
                DateTime vietnamTime = TimeZoneInfo.ConvertTimeFromUtc(currentUtcTime, vietnamTimeZone);

                var newChat = new Domain.Chat
                {
                    ChatId = Guid.NewGuid(),
                    UserId = request.UserId,
                    ConsultantId = request.ConsultantId,
                    LastMessage = string.Empty,
                    Messages = new List<Domain.Message>(),
                    CreatedAt = vietnamTime, // Store Vietnam time
                    UpdatedAt = vietnamTime
                };

                chatRepository.Add(newChat);
                await chatRepository.SaveChangeAsync(cancellationToken);
                chat = newChat;

                //Notify to consultant 
                await systemNotificationService.NotifyNewChatFromMemberAsync(chat, cancellationToken);
            }

            return new CreateChatDto
            {
                ChatId = chat.ChatId,
            };
        }
    }
}
