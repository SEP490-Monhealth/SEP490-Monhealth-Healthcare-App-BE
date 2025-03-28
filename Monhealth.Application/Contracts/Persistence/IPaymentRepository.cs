using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IPaymentRepository : IGenericRepository<Payment, Guid>
    {
        Task<int>SaveChangeAsync();
        Task<PaginatedResult<Payment>> GetAllPaymentsWithPagination(int page, int limit, string search);
        Task<Payment> GetPaymentById(Guid paymentId);
    }
}