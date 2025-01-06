using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Portions.Queries.GetAllFoodPortion;
using Monhealth.Application.Models;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;
using System.Linq.Dynamic.Core;
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

        public async Task<Portion> CheckPortion(string portionSize, float portionWeight, string measurementUnit)
        {
            var existingPortion = await _context.Portions.FirstOrDefaultAsync(p => 
            p.PortionSize == portionSize && 
            p.PortionWeight == portionWeight &&
            p.MeasurementUnit == measurementUnit);
            return existingPortion;
        }

        public async Task<List<Portion>> GetAllPortionAsync(string? sort, string? order)
        {
            IQueryable<Portion> query = _context.Portions.AsQueryable();

            // sap xep
            if (!string.IsNullOrEmpty(sort))
            {
                string sorting = $"{sort} {(order?.ToLower() == "desc" ? "descending" : "ascending")}";
                query = query.OrderBy(sorting);
            }

            var portions = await query.ToListAsync();
            return portions;
        }

        public async Task<Portion> GetPortionAsync(string measurementUnit, string portionSize, float portionWeight)
        {
            return await _context.Portions.FirstOrDefaultAsync(p =>
            p.MeasurementUnit == measurementUnit &&
            p.PortionSize == portionSize &&
            p.PortionWeight == portionWeight);
        }

        public async Task<List<Portion>> GetPortionsByFoodIdAsync(Guid foodId)
        {
            var listPortions = await _context.Portions
                .Where(f => f.FoodPortions.Any(fp => fp.FoodId == foodId))
                .ToListAsync();
            return listPortions;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
