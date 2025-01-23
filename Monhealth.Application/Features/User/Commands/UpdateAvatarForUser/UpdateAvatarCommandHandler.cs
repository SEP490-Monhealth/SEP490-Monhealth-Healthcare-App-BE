using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.User.Commands.UpdateAvatarForUser
{
    public class UpdateAvatarCommandHandler : IRequestHandler<UpdateAvatarCommand, Unit>
    {
        private readonly IUserRepository _userRepository;

        public UpdateAvatarCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Unit> Handle(UpdateAvatarCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.UserId);
            user.Avatar = request.Request.Avatar;
            await _userRepository.SaveChangesAsync();
            return Unit.Value;
        }
    }
}