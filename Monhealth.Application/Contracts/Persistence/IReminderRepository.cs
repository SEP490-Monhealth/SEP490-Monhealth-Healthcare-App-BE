using Monhealth.Core;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IReminderRepository : IGenericRepository<Reminder, Guid>
    {
        Task<int> SaveChangeAsync();
    }
}