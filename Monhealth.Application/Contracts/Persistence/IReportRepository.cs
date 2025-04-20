using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IReportRepository : IGenericRepository<Report, Guid>
    {
        Task<PaginatedResult<Report>> GetAllReports(int page, int limit, string? search, StatusReport? statusReport);
        Task<Report> GetReportById(Guid reportId);
        Task<List<Report>> GetReportByBookingId(Guid bookingId);
        Task<PaginatedResult<Report>> GetReportByConsultantId(Guid consultantId , int page , int limit);
        Task<PaginatedResult<Report>> GetReportByUserId(Guid userId , int page , int limit);
        Task<int> SaveChangeAsync();
    }
}
