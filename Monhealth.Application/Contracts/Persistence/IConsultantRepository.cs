﻿using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IConsultantRepository : IGenericRepository<Consultant, Guid>
    {
        Task<PaginatedResult<Consultant>> GetAllConsultants(int page, int limit, bool? status);
        Task<Consultant> GetConsultantById(Guid consultantId);
        Task<Consultant> GetConsultantByUserId(Guid? userId);
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
    }
}
