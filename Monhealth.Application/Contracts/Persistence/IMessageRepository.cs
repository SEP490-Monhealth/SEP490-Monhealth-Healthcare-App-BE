using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IMessageRepository : IGenericRepository<Message, Guid>
    {
        Task<int> SaveChangeAsync();

    }
}
