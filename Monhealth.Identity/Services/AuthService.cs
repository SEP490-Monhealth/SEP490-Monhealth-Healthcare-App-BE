using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Identity;
using Monhealth.Application.Exceptions;
using Monhealth.Application.Models.Identity;
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
        public AuthService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager, ITokenService tokenService, MonhealthDbcontext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _tokenService = tokenService;
            _context = context;
        }
        public async Task<AuthResponse> Login(AuthenRequest request)
        {
            AppUser user = null;


            if (IsEmail(request.Email))
            {
                user = await _userManager.FindByEmailAsync(request.Email);

            }
            else
            {
                user = await _context.Users.FirstOrDefaultAsync(u => u.PhoneNumber == request.Email);
                if (user == null)
                {
                    throw new BadRequestException("Incorrect phone number.");
                }
            }

            if (user == null || !user.Status || user.LockoutEnabled)
            {

                throw new BadRequestException("Invalid Email.");
            }

            var result = await _signInManager.PasswordSignInAsync(user, request.Password, false, true);
            if (!result.Succeeded)
            {
                throw new BadRequestException("Incorrect Password. Please try again.");
            }

            // Authorization
            var roles = await _userManager.GetRolesAsync(user);
            var claims = new[]
            {
                 new Claim(JwtRegisteredClaimNames.Email, user.Email),
                 new Claim(ClaimTypes.NameIdentifier, user.UserName),
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
            return new AuthResponse()
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                ExpiredAt = user.RefreshTokenExpiryTime
            }; ;
        }
        private bool IsEmail(string input)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(input, emailPattern);
        }
    }
}
