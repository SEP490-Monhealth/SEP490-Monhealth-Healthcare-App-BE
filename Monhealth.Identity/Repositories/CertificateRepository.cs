using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class CertificateRepository : GenericRepository<Certificate, Guid>, ICertificateRepository
    {
        public CertificateRepository(MonhealthDbcontext context) : base(context)
        {
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
    }
}
