using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface ICertificateRepository : IGenericRepository<Certificate, Guid>
    {
        Task<List<Certificate>> GetCertificateByExpertiseId(Guid expertiseId);
        Task<int> SaveChangeAsync();
    }
}
