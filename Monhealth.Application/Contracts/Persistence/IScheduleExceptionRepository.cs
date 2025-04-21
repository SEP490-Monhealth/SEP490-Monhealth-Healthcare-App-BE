using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IScheduleExceptionRepository : IGenericRepository<ScheduleException, Guid>
    {
        Task<ScheduleException> GetScheduleExceptionByIdAsync(Guid scheduleExceptionId);
        Task<PaginatedResult<ScheduleException>> GetAllScheduleExceptionsAsync(int page, int limit);
        Task<PaginatedResult<ScheduleException>> GetScheduleExceptionByConsultantIdAsync(int page, int limit, Guid consultantId);
        Task<bool> CheckScheduleIsExceptionAsync(DateOnly date);
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);

    }
}
