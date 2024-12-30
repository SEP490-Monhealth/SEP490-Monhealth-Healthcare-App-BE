using MediatR;

namespace Monhealth.Application.Features.User.Commands.UpdateUser
{
    public class UpdateUserCommand : IRequest<Unit>
    {
        public Guid UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public UpdateUserCommand(Guid userId, UpdateUserRequest update)
        {
            UserId = userId;
            FullName = update.FullName;
            Email = update.Email;
            PhoneNumber = update.PhoneNumber;
        }
    }
}
