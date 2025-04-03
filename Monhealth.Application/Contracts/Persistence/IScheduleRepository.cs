using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IScheduleRepository : IGenericRepository<Schedule, Guid>
    {
        Task<int> SaveChangeAsync();
        Task<PaginatedResult<Schedule>> GetAllScheduleAsync(int page, int limit);
        Task<List<Schedule>> GetSchedulesByUser(Guid userId, DateOnly? Date);
        Task<Schedule> GetScheduleAsync(Guid consultantId, ScheduleType scheduleType, RecurringDay? recurringDay, DateOnly? specificDate);
        Task<Schedule> GetScheduleByIdAsync(Guid ScheduleId);
    }
}