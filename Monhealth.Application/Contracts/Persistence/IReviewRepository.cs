using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IReviewRepository : IGenericRepository<Review, Guid>
    {
        Task<int> SaveChangeAsync();
        Task<List<Review>> GetReviewsByUser(Guid userId);
        Task<PaginatedResult<Review>> GetAllReviewAsync(int page, int limit, int rating);
        Task<List<Review>> GetReviewsByBookingId(Guid bookingId);
        Task<List<Review>>GetReviewsByConsultant(Guid consultantId);

    }
}