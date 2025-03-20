using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IBookingRepository : IGenericRepository<Booking, Guid>
    {
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
        Task<PaginatedResult<Booking>> GetAllBookingAsync(int page, int limit, string? search, BookingStatus? statis);
        Task<Booking> GetBookingByUserId(Guid userId);
        Task<Booking?> GetBookingByConsultantId(Guid consultantId);
    }
}
