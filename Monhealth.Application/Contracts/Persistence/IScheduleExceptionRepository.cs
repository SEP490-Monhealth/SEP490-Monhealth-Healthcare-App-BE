using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IScheduleExceptionRepository : IGenericRepository<ScheduleException, Guid>
    {
        Task<ScheduleException> GetScheduleExceptionByIdAsync(Guid scheduleExceptionId);
        Task<PaginatedResult<ScheduleException>> GetAllScheduleExceptionsAsync(int page, int limit, string? search, ScheduleExceptionStatus? status);
        Task<PaginatedResult<ScheduleException>> GetScheduleExceptionByConsultantIdAsync(int page, int limit, Guid consultantId);
        Task<bool> CheckScheduleIsExceptionAsync(Guid consultantId, DateOnly date);
        Task<ScheduleException> CheckScheduleIsExceptionPending(Guid? consultantId, DateOnly date);
        Task<ScheduleException> CheckScheduleIsExceptionApproved(Guid? consultantId, DateOnly date);
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);

    }
}
