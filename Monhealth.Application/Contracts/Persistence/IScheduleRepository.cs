using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IScheduleRepository : IGenericRepository<Schedule, Guid>
    {
        Task<int> SaveChangeAsync();
        Task<List<Schedule>> GetSchedulesByUser(Guid userId, DateOnly? Date);
        Task<Schedule> GetScheduleAsync(Guid consultantId, ScheduleType scheduleType, RecurringDay recurringDay);
    }
}