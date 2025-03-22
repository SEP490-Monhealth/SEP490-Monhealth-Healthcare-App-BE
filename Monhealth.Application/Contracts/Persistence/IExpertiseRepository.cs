using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IExpertiseRepository : IGenericRepository<Expertise, Guid>
    {
        Task<PaginatedResult<Expertise>> GetAllExpertisesAsync(int page, int limit);
        Task<Expertise> GetExpertiseByNameAsync(string expertiseName);
        Task<int> SaveChangeAsync();
    }
}
