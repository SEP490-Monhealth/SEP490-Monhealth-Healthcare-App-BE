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
            if (await _userRepository.IsPhoneNumberDuplicateAsync(request.PhoneNumber))
            {
                throw new BadRequestException("Số điện thoại đã được sử dụng");
            }
            if (await _userRepository.IsEmailDuplicatedAsync(request.Email))
            {
                throw new BadRequestException("Email đã được sử dụng");
            }
            if (user == null)
            {
                throw new NotFoundException("Không tìm thấy người dùng");

            }
            user.FullName = request.FullName;
            user.Email = request.Email;
            user.NormalizedEmail = request.Email.ToUpper();
            user.PhoneNumber = request.PhoneNumber;
            _userRepository.Update(user);
            _userRepository.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
