using Monhealth.Application.Models.Identity;

namespace Monhealth.Application.Contracts.Identity
{
    public interface IAuthService
    {
        Task<AuthResponse> Login(AuthenRequest request);
        Task<AuthAdminResponse> LoginForAdmin(AuthAdminRequest request);
        Task Register(RegistrationRequest request);
        Task<MeResponse> GetInformationCurrentUser(string phoneNumber);
        Task<TokenDto> RefreshToken(TokenDto tokenDto);
        Task LogoutAsync();
    }
}
