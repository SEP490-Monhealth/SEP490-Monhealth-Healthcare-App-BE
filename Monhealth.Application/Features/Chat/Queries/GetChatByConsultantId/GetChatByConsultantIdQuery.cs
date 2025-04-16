using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Chat.Queries.GetChatByConsultantId
{
    public class GetChatByConsultantIdQuery : IRequest<PageResult<ChatConsultantDto>>
    {
        public Guid ConsultantId { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
        public string? Search { get; set; }
    }
}
