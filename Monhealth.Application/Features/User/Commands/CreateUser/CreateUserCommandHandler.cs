using MediatR;
using Microsoft.AspNetCore.Identity;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Identity.Models;

namespace Monhealth.Application.Features.User.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Unit>
    {
        private readonly IUserRepository _userRepository;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public CreateUserCommandHandler(IUserRepository userRepository, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userRepository = userRepository;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {

            if (await _userRepository.IsPhoneNumberDuplicateAsync(request.PhoneNumber))
                throw new BadRequestException("trùng số điện thoại");
            if (await _userRepository.IsEmailDuplicatedAsync(request.Email))
                throw new BadRequestException("trùng email");
            if (!await _roleManager.RoleExistsAsync(request.Role))
                throw new BadRequestException($"Vai trò '{request.Role}' không tồn tại");
            var user = new AppUser()
            {
                Id = Guid.NewGuid(),
                FullName = request.FullName,
                Status = request.Status,
                Email = request.Email,
                UserName = request.Email,
                PhoneNumber = request.PhoneNumber,
                Avatar = request.AvatarUrl,
                LockoutEnabled = false,
                EmailConfirmed = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
            };
            var password = "User@123";

            var result = await _userManager.CreateAsync(user, password);
            if (!result.Succeeded)
            {
                var errorMessages = string.Join("; ", result.Errors.Select(e => e.Description));
                throw new Exception($"Failed to create user: {errorMessages}");
            }
            await _userManager.AddToRoleAsync(user, request.Role);
            return Unit.Value;

        }
    }
}
