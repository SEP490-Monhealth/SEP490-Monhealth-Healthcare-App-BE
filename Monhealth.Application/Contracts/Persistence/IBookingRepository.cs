using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IBookingRepository : IGenericRepository<Booking, Guid>
    {
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
        Task<int> SaveChangeAsync();
        Task<PaginatedResult<Booking>> GetAllBookingAsync(int page, int limit, string? search, BookingStatus? statis);
        Task<PaginatedResult<Booking>> GetBookingByUserId(Guid userId, int page, int limit);
        Task<PaginatedResult<Booking?>> GetBookingByConsultantId(Guid consultantId, int page, int limit, DateTime? date);
        Task<List<Booking>> GetBookingsByConsultantIdAndDate(Guid consultantId, DateOnly date);
        Task<Booking> GetBookingByBookingIdAsync(Guid bookingId);
        Task<List<Booking>> GetBookingByConsultantIds(List<Guid> consultantIds);
        Task<List<TimeOnly>> GetBookedTimeAsync(Guid consultantId, DateOnly? date);
        Task<List<Booking>> GetBookingsByConsultantAndDateRange(Guid consultantId, DateTime from, DateTime to);
        Task<List<Booking>> GetBookingByUserAndConsultant(Guid userId, Guid consultantId);
        Task<PaginatedResult<Booking>> GetBookingByConsultantIdMonthly(int page, int limit, Guid consultantId, DateTime from, DateTime to);
        Task<List<Booking>> GetBookingsForRemindersAsync(DateTime startTimeMin, DateTime endTimeMax, CancellationToken cancellationToken);
        Task<List<Booking>> GetCompletedBookingsOlderThan24HoursAsync(DateTime thresholdTime, CancellationToken cancellationToken);
    }
}
