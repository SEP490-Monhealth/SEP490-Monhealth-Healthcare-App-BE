using MediatR;

namespace Monhealth.Application.Features.Message.Commands.CreateMessage
{
    public class CreateMessageCommand : IRequest<Unit>
    {
        public Guid ChatId { get; set; }
        public Guid SenderId { get; set; }
        public string Content { get; set; }

    }
}
