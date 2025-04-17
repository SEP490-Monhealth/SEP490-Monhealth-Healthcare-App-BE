using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Chat.Queries.GetChatByConsultantId
{
    public class GetChatByConsultantIdQueryHandler(IChatRepository chatRepository) : IRequestHandler<GetChatByConsultantIdQuery, PageResult<ChatConsultantDto>>
    {
        public async Task<PageResult<ChatConsultantDto>> Handle(GetChatByConsultantIdQuery request, CancellationToken cancellationToken)
        {
            var chatPaging = await chatRepository.GetChatByConsultantIdAsync(request.Page, request.Limit, request.ConsultantId, request.Search);

            var chatDtos = chatPaging.Items.Select(c => new ChatConsultantDto
            {
                ChatId = c.ChatId,
                UserId = c.UserId,
                ConsultantId = c.ConsultantId,
                Member = new Member
                {
                    FullName = c.AppUser.FullName,
                    AvatarUrl = c.AppUser.Avatar
                },
                LastMessage = c.LastMessage,
                CreatedAt = c.CreatedAt,
                UpdatedAt = c.UpdatedAt
            }).ToList();

            return new PageResult<ChatConsultantDto>()
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(chatPaging.TotalCount / (double)request.Limit),
                TotalItems = chatPaging.TotalCount,
                Items = chatDtos
            }; ;
        }
    }
}
