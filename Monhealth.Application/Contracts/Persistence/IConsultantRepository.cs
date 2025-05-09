﻿using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IConsultantRepository : IGenericRepository<Consultant, Guid>
    {
        Task<PaginatedResult<Consultant>> GetAllConsultants(int page, int limit, string? expertise, string? search, bool? verification, bool? popular, bool? status);
        Task<Consultant> GetConsultantById(Guid consultantId);
        Task<Consultant> GetConsultantByUserId(Guid? userId);
        Task<Consultant> GetConsultantByConsultantId(Guid consultantId);
        Task<int> SaveChangeAsync();
        Task<Consultant> GetConsultantWithWalletAndTransactionsAsync(Guid ConsultantId);
        Task<Dictionary<Guid, string>> GetAvatarsByConsultantIds(List<Guid> consultantIds);
    }
}
