using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IScheduleExceptionRepository : IGenericRepository<ScheduleException, Guid>
    {
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);

    }
}
