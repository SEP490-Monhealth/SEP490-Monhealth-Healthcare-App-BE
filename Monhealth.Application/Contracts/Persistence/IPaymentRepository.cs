using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IPaymentRepository : IGenericRepository<Payment, Guid>
    {
        Task<int>SaveChangeAsync();
    }
}