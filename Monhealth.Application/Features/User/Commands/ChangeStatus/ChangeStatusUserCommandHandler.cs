using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.User.Commands.ChangeStatus
{
    public class ChangeStatusUserCommandHandler : IRequestHandler<ChangeStatusUserCommand, bool>
    {
        private readonly IUserRepository _userRepository;
        public ChangeStatusUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Handle(ChangeStatusUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.UserId);
            user.Status = !user.Status;
            await _userRepository.SaveChangesAsync();
            return true;
        }
    }
}