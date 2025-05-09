﻿using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;
using System.Linq.Expressions;

namespace Monhealth.Identity.Repositories
{
    public class CertificateRepository : GenericRepository<Certificate, Guid>, ICertificateRepository
    {
        public CertificateRepository(MonhealthDbcontext context) : base(context)
        {

        }

        public async Task<bool> AnyAsync(Expression<Func<Certificate, bool>> predicate)
        {
            return await _context.Set<Certificate>().AnyAsync(predicate);

        }

        public async Task<PaginatedResult<Certificate>> GetAllCertificateAsync(int page, int limit, string? search, bool? isVerfied)
        {
            search = search?.Trim();
            IQueryable<Certificate> query =
            _context.Certificates.Include(c => c.Consultant).ThenInclude(c => c.Expertise)
            .Include(c => c.Consultant)
            .ThenInclude(u => u.AppUser).AsQueryable();


            // filter search
            if (!string.IsNullOrEmpty(search))
            {
                // cho phep search khong dau
                query = query.Where(s => EF.Functions.Collate(s.CertificateName, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower()) ||
                    s.CertificateId.ToString().ToLower().Contains(search.ToLower()) ||
                    s.ExpertiseId.ToString().ToLower().Contains(search.ToLower()) ||
                    s.ConsultantId.ToString().ToLower().Contains(search.ToLower()) ||
                    s.Consultant.AppUser.PhoneNumber.ToLower().Contains(search.ToLower()) ||
                    s.Consultant.AppUser.Email.ToLower().Contains(search.ToLower()) ||
                    EF.Functions.Collate(s.Consultant.AppUser.FullName, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower()) ||
                    s.CertificateNumber.Contains(search)
                    );
            }

            if (isVerfied.HasValue)
            {
                query = query.Where(c => c.IsVerified == isVerfied);
            }
            query = query.OrderByDescending(c => c.CreatedAt);
            int totalItems = await query.CountAsync();

            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<Certificate>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };

        }
        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
        public async Task<List<Certificate>> GetCertificateByExpertiseId(Guid expertiseId)
        {
            return await _context.Certificates
                             .Where(c => c.ExpertiseId == expertiseId)
                             .ToListAsync();
        }
        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<List<Certificate>> GetCertificateByConsultant(Guid consultantId)
        {
            return await _context.Certificates.
            Include(c => c.Consultant).
            ThenInclude(c => c.Expertise)
            .Where(c => c.ConsultantId == consultantId).ToListAsync();
        }

        public async Task<Certificate> GetByCertificateIdAsync(Guid certificateId)
        {

            return await _context.Certificates.Include(c => c.Consultant)
                .ThenInclude(c => c.Expertise).FirstOrDefaultAsync(c => c.CertificateId == certificateId);
        }

        public async Task<List<Certificate>> GetAllCertificatesAsync()
        {
            return await _context.Certificates.Include(c => c.Consultant)
            .ThenInclude(c => c.Expertise).ToListAsync();
        }

        public Task<List<Certificate>> GetCertificateByConsultantId(Guid consultantId)
        {
            return _context.Certificates.Include(c => c.Consultant).ThenInclude(c => c.Expertise)
            .Where(c => c.ConsultantId == consultantId).ToListAsync();
        }
    }
}
