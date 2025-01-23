using MediatR;

namespace Monhealth.Application.Features.User.Commands.ChangeStatus
{
    public class ChangeStatusUserCommand : IRequest<bool>
    {
        public Guid UserId { get; set; }
    }
}