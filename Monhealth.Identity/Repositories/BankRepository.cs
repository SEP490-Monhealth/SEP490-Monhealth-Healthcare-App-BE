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
    public class BankRepository : GenericRepository<Bank, Guid>, IBankRepository
    {
        public BankRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<Bank> CheckBankNameExisted(string bankName)
        {
            var bank = await _context.Banks.FirstOrDefaultAsync(n => n.BankName == bankName);
            return bank;
        }

        public Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }
    }
}
