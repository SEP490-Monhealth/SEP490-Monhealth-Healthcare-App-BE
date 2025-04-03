using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IBankRepository : IGenericRepository<Bank, Guid>
    {
        Task<PaginatedResult<Bank>> GetAllBanksAsync(int page, int limit, string? search, bool? status);
        Task<bool> CheckBankNameExisted(string? bankName);
        Task<bool> CheckBankCodeExisted(string? bankCode);
        Task<bool> CheckShortNameExisted(string? shortName);
        Task<Bank> GetBankByBankName(string? bankName);
        Task<Bank> GetBankByBankCode(string bankCode);
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
    }
}
