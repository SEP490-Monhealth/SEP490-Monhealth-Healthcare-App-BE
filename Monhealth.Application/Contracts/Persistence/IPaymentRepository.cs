using Monhealth.Application.Models.Paging;
using Monhealth.Core;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IPaymentRepository : IGenericRepository<Payment, Guid>
    {
        Task<int> SaveChangeAsync();
        Task<PaginatedResult<Payment>> GetAllPaymentsWithPagination(int page, int limit
        , string search, PaymentStatus? Status);
        Task<Payment> GetPaymentById(Guid paymentId);
        Task<PaginatedResult<Payment>> GetPaymentByUser(Guid user, int page, int limit);
        Task<List<Payment>> GetPaymentBySubscriptionId(Guid subcriptionId);
        Task<Payment> GetPayemntByOrderCodeAsync(long orderCode);
        Task<int> GetCompletedPaymentsCountAsync();

        // Lấy số lượng thanh toán đã hoàn thành dựa theo khoảng thời gian (ví dụ: theo tháng)
        Task<int> GetCompletedPaymentsCountAsync(DateTime targetDate);

        // Lấy tổng doanh thu từ các giao dịch đã hoàn thành (tất cả)
        Task<decimal> GetTotalRevenueAsync();

        // Lấy tổng doanh thu từ các giao dịch đã hoàn thành dựa theo khoảng thời gian (ví dụ: theo tháng)
        Task<decimal> GetTotalRevenueAsync(DateTime targetDate);
    }
}