using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IReviewRepository : IGenericRepository<Review, Guid>
    {
             Task<int>SaveChangeAsync();
             Task<List<Review>>GetReviewsByUser(Guid userId);
             Task<List<Review>>GetReviewsByConsultant(Guid consultantId);

    }
}