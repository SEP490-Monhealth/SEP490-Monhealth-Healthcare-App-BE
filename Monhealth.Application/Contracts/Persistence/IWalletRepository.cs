using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IWalletRepository : IGenericRepository<Wallet, Guid>
    {
        Task<PaginatedResult<Wallet>> GetAllWalletAsync(int page, int limit, bool? status);
        Task<Wallet> GetWalletByConsultantId(Guid consultantId);
        Task<int> SaveChangeAsync();
    }
}
