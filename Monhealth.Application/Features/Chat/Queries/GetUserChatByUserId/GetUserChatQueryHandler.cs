using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Chat.Queries.GetUserChatByUserId
{
    public class GetUserChatQueryHandler(IChatRepository chatRepository) : IRequestHandler<GetUserChatQuery, PageResult<ChatDto>>
    {
        public async Task<PageResult<ChatDto>> Handle(GetUserChatQuery request, CancellationToken cancellationToken)
        {
            var chatPaging = await chatRepository.GetUserChatAsync(request.Page, request.Limit, request.UserId, request.Search);
            var chatDtos = chatPaging.Items.Select(c => new ChatDto
            {
                ChatId = c.ChatId,
                UserId = c.UserId,
                ConsultantId = c.ChatId,
                Consultant = new Consultant
                {
                    FullName = c.Consultant?.AppUser?.FullName,
                    AvatarUrl = c.Consultant?.AppUser?.Avatar
                },
                LastMessage = c.LastMessage,
                CreatedAt = c.CreatedAt,
                UpdatedAt = c.UpdatedAt
            }).ToList();
            return new PageResult<ChatDto>()
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(chatPaging.TotalCount / (double)request.Limit),
                TotalItems = chatPaging.TotalCount,
                Items = chatDtos
            };
        }
    }

}
