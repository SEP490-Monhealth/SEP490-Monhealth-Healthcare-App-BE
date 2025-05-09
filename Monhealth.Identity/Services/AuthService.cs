﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Identity;
using Monhealth.Application.Contracts.Notification;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Application.Models.Identity;
using Monhealth.Application.Models.SeedWorks;
using Monhealth.Identity.Dbcontexts;
using Monhealth.Identity.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text.RegularExpressions;

namespace Monhealth.Identity.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly ITokenService _tokenService;
        private readonly MonhealthDbcontext _context;
        private readonly IUserRepository _userRepository;
        private readonly ISystemNotificationService systemNotificationService;

        public AuthService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,
            RoleManager<AppRole> roleManager, ITokenService tokenService,
            MonhealthDbcontext context, IUserRepository userRepository,
            ISystemNotificationService systemNotificationService
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _tokenService = tokenService;
            _context = context;
            _userRepository = userRepository;
            this.systemNotificationService = systemNotificationService;
        }

        public async Task<MeResponse> GetInformationCurrentUser(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber)) throw new BadRequestException("Số điện thoại không được để trống");
            var user = await _userRepository.GetByPhoneNumberAsync(phoneNumber);
            if (user == null) throw new NotFoundException("Người dùng không tồn tại");

            var roles = await _userManager.GetRolesAsync(user);
            return new MeResponse
            {
                UserId = user.Id,
                ConsultantId = user.Consultant?.ConsultantId ?? null,
                FullName = user.FullName ?? string.Empty,  // Kiểm tra null cho FullName
                PhoneNumber = user.PhoneNumber ?? string.Empty,  // Kiểm tra null cho PhoneNumber
                Email = user.Email,
                Avatar = user.Avatar ?? string.Empty,  // Kiểm tra null cho Avatar
                Role = roles.FirstOrDefault(),  // Đảm bảo role không bị null
                Subscription = user.UserSubscriptions.Where(us => us.Status == Core.Enum.UserSubscriptionStatus.Active)
                .Select(us => us.Subscription.SubscriptionName).FirstOrDefault() ?? string.Empty,
            };
        }

        public async Task<AuthResponse> Login(AuthenRequest request)
        {

            AppUser user = await _context.Users.FirstOrDefaultAsync(u => u.PhoneNumber == request.PhoneNumber);
            if (user == null)
            {
                throw new BadRequestException("Số điện thoại không tồn tại");
            }


            if (!user.Status || user.LockoutEnabled)
            {

                throw new BadRequestException("Tài khoản chưa được kích hoạt");
            }

            var result = await _signInManager.PasswordSignInAsync(user, request.Password, false, true);
            if (!result.Succeeded)
            {
                throw new BadRequestException("Tài khoản hoặc mật khẩu không đúng");
            }

            // Authorization
            var roles = await _userManager.GetRolesAsync(user);
            var claims = new[]
            {
                 new Claim(JwtRegisteredClaimNames.Email, user.Email),
                 new Claim(ClaimTypes.NameIdentifier, user.UserName),
                 new Claim(ClaimTypes.MobilePhone, user.PhoneNumber),
                 new Claim(ClaimTypes.Name, user.UserName),
                 new Claim(UserClaims.UserId, user.Id.ToString()),
                 new Claim(UserClaims.FullName, user.FullName),
                 new Claim(UserClaims.Role, string.Join(";", roles)),
                 new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            var accessToken = _tokenService.GenerateAccessToken(claims);
            var refreshToken = _tokenService.GenerateRefreshToken();

            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(30);
            await _userManager.UpdateAsync(user);

            //notify user 
            await systemNotificationService.NotifyNewUserSessionAsync(user);
            return new AuthResponse()
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                ExpiredAt = user.RefreshTokenExpiryTime
            };
        }

        public async Task<AuthAdminResponse> LoginForAdmin(AuthAdminRequest request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.Email);
            if (user == null)
            {
                throw new BadRequestException("Email không tồn tại");
            }
            var result = await _signInManager.PasswordSignInAsync(user, request.Password, false, true);
            if (!result.Succeeded)
            {
                throw new BadRequestException("Tài khoản hoặc mật khẩu không đúng");
            }

            // Authorization
            var roles = await _userManager.GetRolesAsync(user);
            var claims = new[]
            {
                 new Claim(JwtRegisteredClaimNames.Email, user.Email),
                 new Claim(ClaimTypes.NameIdentifier, user.UserName),
                 new Claim(ClaimTypes.MobilePhone, user.PhoneNumber),
                 new Claim(ClaimTypes.Name, user.UserName),
                 new Claim(UserClaims.UserId, user.Id.ToString()),
                 new Claim(UserClaims.FullName, user.FullName),
                 new Claim(UserClaims.Role, string.Join(";", roles)),
                 new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            var accessToken = _tokenService.GenerateAccessToken(claims);
            var refreshToken = _tokenService.GenerateRefreshToken();

            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(30);
            await _userManager.UpdateAsync(user);
            return new AuthAdminResponse()
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                ExpiredAt = user.RefreshTokenExpiryTime
            };
        }

        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<TokenDto> RefreshToken(TokenDto tokenDto)
        {
            var principal = _tokenService.GetPrincipalFromExpiredToken(tokenDto.AccessToken);
            var user = await _userManager.FindByNameAsync(principal.Identity.Name);
            if (user is null || user.RefreshToken != tokenDto.RefreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
            {

                throw new BadRequestException("Token không hợp lệ");
            }
            var roles = await _userManager.GetRolesAsync(user);
            var claims = new[]
            {
                 new Claim(JwtRegisteredClaimNames.Email, user.Email),
                 new Claim(ClaimTypes.NameIdentifier, user.UserName),
                 new Claim(ClaimTypes.MobilePhone, user.PhoneNumber),

                 new Claim(ClaimTypes.Name, user.UserName),
                 new Claim(UserClaims.UserId, user.Id.ToString()),
                 new Claim(UserClaims.FullName, user.FullName),
                 new Claim(UserClaims.Role, string.Join(";", roles)),
                 new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            return new TokenDto() { AccessToken = _tokenService.GenerateAccessToken(claims), RefreshToken = _tokenService.GenerateRefreshToken() };
        }

        public async Task Register(RegistrationRequest request)
        {
            var checkUser = await _userRepository.GetByPhoneNumberAsync(request.PhoneNumber);
            var existEmail = await _userManager.FindByEmailAsync(request.Email);

            if (checkUser != null)
            {
                throw new BadRequestException("Số điện thoại đã tồn tại");
            }

            if (existEmail != null)
                throw new BadRequestException("Email đã được đăng ký");

            var newUserId = Guid.NewGuid();
            var user = new AppUser
            {
                Id = newUserId,
                FullName = request.FullName,
                UserName = request.Email.ToLower(),
                Email = request.Email,
                Status = true,
                PhoneNumber = request.PhoneNumber,
                SecurityStamp = Guid.NewGuid().ToString(),
                LockoutEnabled = false,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                CreatedBy = newUserId,
                UpdatedBy = newUserId
            };

            // Step 4: Register the user
            var result = await _userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                // Step 6: Assign a role to the user
                await _userManager.AddToRoleAsync(user, Roles.Member);

                return;
            }

            // If the registration fails, return the errors
            var errors = result.Errors.Select(e => e.Description).ToList();
            throw new Exception(string.Join(", ", errors));
        }

        private bool IsEmail(string input)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(input, emailPattern);
        }
    }
}
