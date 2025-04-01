using MediatR;

namespace Monhealth.Application.Features.Chat.Queries.GetUserChatByUserId
{
    public class GetUserChatQuery : IRequest<List<ChatDto>>
    {
        public Guid UserId { get; set; }
    }
}
