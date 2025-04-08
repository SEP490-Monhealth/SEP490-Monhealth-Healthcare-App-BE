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
        Task<List<Payment>> GetPaymentByUser(Guid user);
        Task<List<Payment>> GetPaymentBySubscriptionId(Guid subcriptionId);
        Task<Payment> GetPayemntByOrderCodeAsync(long orderCode);
    }
}