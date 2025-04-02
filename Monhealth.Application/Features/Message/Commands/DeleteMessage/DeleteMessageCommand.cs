using MediatR;

namespace Monhealth.Application.Features.Message.Commands.DeleteMessage
{
    public class DeleteMessageCommand : IRequest<bool>
    {
        public Guid MessageId { get; set; }
    }
}
