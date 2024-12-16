using Monhealth.Application.Models.Identity;

namespace Monhealth.Application.Contracts.Identity
{
    public interface IAuthService
    {
        Task<AuthResponse> Login(AuthenRequest request);
        Task Register(RegistrationRequest request);
        Task<MeResponse> GetInfomationCurrentUser(string phoneNumber);
        Task LogoutAsync();
    }
}
