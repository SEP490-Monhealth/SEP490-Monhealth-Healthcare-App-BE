﻿using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IScheduleExceptionRepository : IGenericRepository<ScheduleException, Guid>
    {
        Task<PaginatedResult<ScheduleException>> GetAllScheduleExceptionsAsync(int page, int limit);
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);

    }
}
