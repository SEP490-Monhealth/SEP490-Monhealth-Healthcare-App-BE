using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IBookingRepository : IGenericRepository<Booking, Guid>
    {
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
        Task<PaginatedResult<Booking>> GetAllBookingAsync(int page, int limit);
        Task<Booking> GetBookingByUserId(Guid userId);
        Task<Booking> GetBookingByConsultantId(Guid consultantId);
    }
}
