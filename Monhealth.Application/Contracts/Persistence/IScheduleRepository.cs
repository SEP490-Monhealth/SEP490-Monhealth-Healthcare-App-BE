using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IScheduleRepository : IGenericRepository<Schedule, Guid>
    {
        Task<int> SaveChangeAsync();
        Task<List<Schedule>> GetSchedulesByUser(Guid userId, DateOnly? Date);
    }
}