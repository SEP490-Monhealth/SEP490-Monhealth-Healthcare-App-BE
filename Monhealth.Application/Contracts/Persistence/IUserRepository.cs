using Monhealth.Identity.Models;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IUserRepository
    {
        Task<AppUser> GetByPhoneNumberAsync(string phoneNumber);
    }
}
