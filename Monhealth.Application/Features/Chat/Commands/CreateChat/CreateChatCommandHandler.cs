using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Chat.Commands.CreateChat
{
    public class CreateChatCommandHandler(IChatRepository chatRepository) : IRequestHandler<CreateChatCommand, Guid>
    {
        public async Task<Guid> Handle(CreateChatCommand request, CancellationToken cancellationToken)
        {
            var newChat = new Domain.Chat
            {
                ChatId = Guid.NewGuid(),
                UserId = request.UserId,
                ConsultantId = request.ConsultantId,
                LastMessage = string.Empty,
                Messages = new List<Domain.Message>(),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                CreatedBy = request.UserId,
                UpdatedBy = request.UserId
            };

            chatRepository.Add(newChat);
            await chatRepository.SaveChangeAsync(cancellationToken);
            return newChat.ChatId;
        }
    }
}
