using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IConsultantBankRepository : IGenericRepository<ConsultantBank, Guid>
    {
        Task<PaginatedResult<ConsultantBank>> GetAllConsultantBanksAsync(int page, int limit, string? search);
        Task<ConsultantBank> GetConsultantBankById(Guid consultantBankId);
        Task<List<ConsultantBank>> GetConsultantBankByConsultantIdAsync(Guid consultantId);
        Task<ConsultantBank> GetConsultantBankByConsultant(Guid conSultantBankId);
        Task<bool> CheckAccountNumber(string? accountNumber, Guid? excludeId);
        Task SetDefaultBankAccountAsync(Guid consultantId);
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
    }
}
