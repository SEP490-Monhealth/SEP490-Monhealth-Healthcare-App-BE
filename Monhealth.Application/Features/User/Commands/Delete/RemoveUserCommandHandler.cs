using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.User.Commands.Delete
{
    public class RemoveUserCommandHandler : IRequestHandler<RemoveUserCommand, Unit>
    {
        private readonly IUserRepository _userRepository;
        public RemoveUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Unit> Handle(RemoveUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.UserId);
            _userRepository.Remove(user);
            await _userRepository.SaveChangesAsync();
            return Unit.Value;
        }
    }
}