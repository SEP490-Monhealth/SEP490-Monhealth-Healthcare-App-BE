﻿using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using System.Linq.Expressions;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface ICertificateRepository : IGenericRepository<Certificate, Guid>
    {
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
        Task<bool> AnyAsync(Expression<Func<Certificate, bool>> predicate);
        Task<PaginatedResult<Certificate>> GetAllCertificateAsync(int page, int limit, string? search, bool? isVerified);
        Task<List<Certificate>> GetCertificateByExpertiseId(Guid expertiseId);
        Task<List<Certificate>>GetCertificateByConsultant(Guid consultantId);
        Task<int> SaveChangeAsync();
    }
}
