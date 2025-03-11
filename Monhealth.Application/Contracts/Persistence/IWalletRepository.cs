using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IWalletRepository : IGenericRepository<Wallet, Guid>
    {
        Task<Wallet> GetWalletByConsultantId(Guid consultantId);
        Task<int> SaveChangeAsync();
    }
}
