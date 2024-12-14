using Monhealth.Application.Models.Identity;

namespace Monhealth.Application.Contracts.Identity
{
    public interface IAuthService
    {
        Task<AuthResponse> Login(AuthenRequest request);
        //Task<RegistrationResponse> Register(RegistrationRequest request);
    }
}
