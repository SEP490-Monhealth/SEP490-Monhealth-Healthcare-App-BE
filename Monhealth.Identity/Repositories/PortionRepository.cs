using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Portions.Queries.GetAllFoodPortion;
using Monhealth.Application.Models;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Identity.Repositories
{
    public class PortionRepository : GenericRepository<Portion, Guid>, IPortionRepository
    {
        public PortionRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task AddPortionAsync(FoodPortion foodPortion)
        {
            _context.FoodPortions.Add(foodPortion);
            await _context.SaveChangesAsync();
        }

        public async Task<PageResult<Portion>> GetAllPortionAsync(int page, int limit)
        {
            IQueryable<Portion> query = _context.Portions.Include(fp => fp.FoodPortions).AsQueryable();
            var totalItems = await query.CountAsync();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }            
            var portions = await query.ToListAsync();
            return new PageResult<Portion>
            {
                Data = portions,
                TotalItems = totalItems
            };
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
