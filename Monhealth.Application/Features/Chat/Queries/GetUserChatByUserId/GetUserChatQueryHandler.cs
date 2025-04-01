using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Chat.Queries.GetUserChatByUserId
{
    public class GetUserChatQueryHandler(IChatRepository chatRepository) : IRequestHandler<GetUserChatQuery, List<ChatDto>>
    {
        public async Task<List<ChatDto>> Handle(GetUserChatQuery request, CancellationToken cancellationToken)
        {
            var chats = await chatRepository.GetUserChatAsync(request.UserId);
            var chatDtos = chats.Select(c => new ChatDto
            {
                ChatId = c.ChatId,
                UserId = c.UserId,
                ConsultantId = c.ChatId,
                LastMessage = c.LastMessage,
                CreatedAt = c.CreatedAt,
                UpdatedAt = c.UpdatedAt,
            }).ToList();
            return chatDtos;
        }
    }
}
