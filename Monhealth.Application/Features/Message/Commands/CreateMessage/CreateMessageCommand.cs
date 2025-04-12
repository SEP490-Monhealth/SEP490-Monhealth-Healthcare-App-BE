using MediatR;
using Monhealth.Application.Features.Message.Queries.GetAllMessages;

namespace Monhealth.Application.Features.Message.Commands.CreateMessage
{
    public class CreateMessageCommand : IRequest<MessageDto>
    {
        public Guid ChatId { get; set; }
        public Guid SenderId { get; set; }
        public string Content { get; set; }

    }
}
