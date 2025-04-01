using MediatR;

namespace Monhealth.Application.Features.Chat.Commands.CreateChat
{
    public record CreateChatCommand(Guid UserId, Guid ConsultantId) : IRequest<Guid>;


}
