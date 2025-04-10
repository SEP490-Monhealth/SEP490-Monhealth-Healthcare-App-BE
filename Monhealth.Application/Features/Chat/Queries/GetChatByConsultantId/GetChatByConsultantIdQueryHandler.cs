using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Chat.Queries.GetUserChatByUserId;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Chat.Queries.GetChatByConsultantId
{
    public class GetChatByConsultantIdQueryHandler(IChatRepository chatRepository) : IRequestHandler<GetChatByConsultantIdQuery, PageResult<ChatDto>>
    {
        public async Task<PageResult<ChatDto>> Handle(GetChatByConsultantIdQuery request, CancellationToken cancellationToken)
        {
            var chatPaging = await chatRepository.GetChatByConsultantIdAsync(request.Page, request.Limit, request.ConsultantId);

            var chatDtos = chatPaging.Items.Select(c => new ChatDto
            {
                ChatId = c.ChatId,
                UserId = c.UserId,
                ConsultantId = c.ConsultantId,
                LastMessage = c.LastMessage,
                CreatedAt = c.CreatedAt,
                UpdatedAt = c.UpdatedAt,
                CreatedBy = c.CreatedBy,
                UpdatedBy = c.UpdatedBy,
            }).ToList();

            return new PageResult<ChatDto>()
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(chatPaging.TotalCount / (double)request.Limit),
                TotalItems = chatPaging.TotalCount,
                Items = chatDtos
            }; ;
        }
    }
}
