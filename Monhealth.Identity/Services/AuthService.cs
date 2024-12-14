using Monhealth.Application.Contracts.Identity;
using Monhealth.Application.Models.Identity;

namespace Monhealth.Identity.Services
{
    public class AuthService : IAuthService
    {
        public Task<AuthResponse> Login(AuthenRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
