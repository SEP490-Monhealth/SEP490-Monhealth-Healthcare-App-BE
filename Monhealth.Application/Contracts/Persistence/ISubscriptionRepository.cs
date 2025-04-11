using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface ISubscriptionRepository : IGenericRepository<Subscription, Guid>
    {
        Task<int> SaveChangeAsync();
        Task<PaginatedResult<Subscription>> GetAllSubcriptionAsync(int page, int limit, string? search, bool? sort, bool? status);
        Task<Subscription?> GetBasicSubscription();
    }
}