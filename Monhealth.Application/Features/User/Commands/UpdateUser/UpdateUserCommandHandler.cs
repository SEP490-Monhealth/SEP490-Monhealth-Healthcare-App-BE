using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.User.Commands.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Unit>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UpdateUserCommandHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserByUserId(request.UserId);
            if (user == null)
                throw new NotFoundException("Không tìm thấy người dùng");

            if (!string.Equals(request.Email, user.Email, StringComparison.OrdinalIgnoreCase))
            {
                if (await _userRepository.IsEmailDuplicatedAsync(request.Email))
                    throw new BadRequestException("Email đã được sử dụng");

                user.Email = request.Email;
                user.NormalizedEmail = request.Email.ToUpperInvariant();
            }

            if (!string.Equals(request.PhoneNumber, user.PhoneNumber, StringComparison.OrdinalIgnoreCase))
            {
                if (await _userRepository.IsPhoneNumberDuplicateAsync(request.PhoneNumber))
                    throw new BadRequestException("Số điện thoại đã được sử dụng");

                user.PhoneNumber = request.PhoneNumber;
            }

            user.FullName = request.FullName;

            _userRepository.Update(user);
            await _userRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
