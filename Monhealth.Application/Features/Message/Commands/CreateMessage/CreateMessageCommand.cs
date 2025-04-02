using MediatR;

namespace Monhealth.Application.Features.Message.Commands.CreateMessage
{
    public record CreateMessageCommand(Guid senderId, Guid receiverId, string content) : IRequest<Unit>;


}
