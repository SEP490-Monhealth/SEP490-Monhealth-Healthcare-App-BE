using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IScheduleRepository : IGenericRepository<Schedule, Guid>
    {
        Task<int> SaveChangeAsync();
        Task<PaginatedResult<Schedule>> GetAllScheduleAsync(int page, int limit, Guid? consultantId, DateOnly? date);
        Task<List<Schedule>> GetSchedulesByUser(Guid userId, DateOnly? Date);
        Task<Schedule> GetScheduleAsync(Guid consultantId, ScheduleType scheduleType, RecurringDay recurringDay);
        Task<Schedule> GetScheduleByIdAsync(Guid ScheduleId);
    }
}