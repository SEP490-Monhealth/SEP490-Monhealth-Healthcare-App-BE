using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Chat.Queries.GetUserChatByUserId
{
    public class GetUserChatQuery : IRequest<PageResult<ChatDto>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public Guid UserId { get; set; }
    }
}
