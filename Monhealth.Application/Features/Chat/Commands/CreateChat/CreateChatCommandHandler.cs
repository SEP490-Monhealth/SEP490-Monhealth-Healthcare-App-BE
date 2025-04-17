using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Chat.Commands.CreateChat
{
    public class CreateChatCommandHandler(IChatRepository chatRepository) : IRequestHandler<CreateChatCommand, CreateChatDto>
    {
        public async Task<CreateChatDto> Handle(CreateChatCommand request, CancellationToken cancellationToken)
        {
            var chat = await chatRepository.GetChatByParticipantAsync(request.UserId, request.ConsultantId);
            if (chat == null)
            {
                var newChat = new Domain.Chat
                {
                    ChatId = Guid.NewGuid(),
                    UserId = request.UserId,
                    ConsultantId = request.ConsultantId,
                    LastMessage = string.Empty,
                    Messages = new List<Domain.Message>(),
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };
                chatRepository.Add(newChat);
                await chatRepository.SaveChangeAsync(cancellationToken);
                chat = newChat;

            }

            return new CreateChatDto
            {
                ChatId = chat.ChatId,
            };
        }
    }
}
