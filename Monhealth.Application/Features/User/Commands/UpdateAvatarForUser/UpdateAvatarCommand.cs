using MediatR;

namespace Monhealth.Application.Features.User.Commands.UpdateAvatarForUser
{
    public class UpdateAvatarCommand : IRequest<Unit>
    {
        public Guid UserId { get; set; }
        public UpdateAvatarRequest Request { get; set; }
        public UpdateAvatarCommand(Guid user , UpdateAvatarRequest request)
        {
            UserId = user;
            Request = request;
        }
    }
}