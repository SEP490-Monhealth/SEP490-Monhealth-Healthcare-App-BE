using MediatR;
using Monhealth.Application.Features.Chat.Queries.GetUserChatByUserId;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Chat.Queries.GetChatByConsultantId
{
    public class GetChatByConsultantIdQuery : IRequest<PageResult<ChatDto>>
    {
        public Guid ConsultantId { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
    }
}
