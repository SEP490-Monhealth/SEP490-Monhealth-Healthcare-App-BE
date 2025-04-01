using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IChatRepository : IGenericRepository<Chat, Guid>
    {
        Task<int> SaveChangeAsync();
    }
}
