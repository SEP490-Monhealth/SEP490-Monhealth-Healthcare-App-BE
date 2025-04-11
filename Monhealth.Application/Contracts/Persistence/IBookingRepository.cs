using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IBookingRepository : IGenericRepository<Booking, Guid>
    {
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
        Task<PaginatedResult<Booking>> GetAllBookingAsync(int page, int limit, string? search, BookingStatus? statis);
        Task<List<Booking>> GetBookingByUserId(Guid userId);
        Task<List<Booking?>> GetBookingByConsultantId(Guid consultantId, DateTime? date);
        Task<Booking> GetBookingByBookingIdAsync(Guid bookingId);
        Task<List<Booking>> GetBookingByConsultantIds(List<Guid> consultantIds);
        Task<List<TimeOnly>> GetBookedTimeAsync(Guid consultantId, DateOnly? date);
        Task<List<Booking>> GetBookingsByConsultantAndDateRange(Guid consultantId, DateTime from, DateTime to);
    }
}
