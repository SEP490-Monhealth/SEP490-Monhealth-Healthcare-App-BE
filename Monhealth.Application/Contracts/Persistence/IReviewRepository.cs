using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IReviewRepository : IGenericRepository<Review, Guid>
    {
        Task<int> SaveChangeAsync();
        Task<PaginatedResult<Review>> GetReviewsByUser(Guid userId, int page, int limit );
        Task<PaginatedResult<Review>> GetAllReviewAsync(int page, int limit, int rating, string search);
        Task<List<Review>> GetReviewsByBookingId(Guid bookingId);
        Task<PaginatedResult<Review>> GetReviewsByConsultant(Guid consultantId, int page, int limit);

    }
}