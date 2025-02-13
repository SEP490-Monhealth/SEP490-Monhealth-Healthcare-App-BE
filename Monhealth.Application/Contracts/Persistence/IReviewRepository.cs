using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IReviewRepository : IGenericRepository<Review, Guid>
    {
             Task<int>SaveChangeAsync();
    }
}