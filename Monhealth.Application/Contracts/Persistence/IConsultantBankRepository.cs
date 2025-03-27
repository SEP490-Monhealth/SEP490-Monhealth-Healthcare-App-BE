using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IConsultantBankRepository : IGenericRepository<ConsultantBank, Guid>
    {
        Task<PaginatedResult<ConsultantBank>> GetAllConsultantBanksAsync(int page, int limit, string? search, bool? status);
        Task<List<ConsultantBank>> GetConsultantBankByConsultantIdAsync(Guid consultantId);
        Task<ConsultantBank>GetConsultantBankByConsultant(Guid conSultantBankId);
        Task<bool> CheckAccountNumber(string? accountNumber);
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
    }
}
