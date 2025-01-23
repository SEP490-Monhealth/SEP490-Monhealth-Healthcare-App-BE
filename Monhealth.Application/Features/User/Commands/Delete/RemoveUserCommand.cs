using MediatR;

namespace Monhealth.Application.Features.User.Commands.Delete
{
    public class RemoveUserCommand : IRequest<Unit>
    {
        public  Guid UserId { get; set; }
        public RemoveUserCommand(Guid userId)
        {
            UserId = userId;
        }

    }
}