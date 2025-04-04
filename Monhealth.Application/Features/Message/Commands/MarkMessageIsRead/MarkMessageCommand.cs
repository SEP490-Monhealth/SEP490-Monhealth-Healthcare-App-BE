using MediatR;

namespace Monhealth.Application.Features.Message.Commands.MarkMessageIsRead
{
    public class MarkMessageCommand : IRequest<bool>
    {
        public Guid MessageId { get; set; }
    }
}
