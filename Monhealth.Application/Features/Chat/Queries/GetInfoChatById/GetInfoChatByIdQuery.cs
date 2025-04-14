using MediatR;

namespace Monhealth.Application.Features.Chat.Queries.GetInfoChatById
{
    public class GetInfoChatByIdQuery : IRequest<GetInfoChatByIdDTO>
    {
        public Guid ChatId { get; set; }
    }
}
