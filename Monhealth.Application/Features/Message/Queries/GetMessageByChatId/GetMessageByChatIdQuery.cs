using MediatR;
using Monhealth.Application.Features.Message.Queries.GetAllMessages;

namespace Monhealth.Application.Features.Message.Queries.GetMessageByChatId
{
    public class GetMessageByChatIdQuery : IRequest<List<MessageDto>>
    {
        public Guid ChatId { get; set; }
    }
}
