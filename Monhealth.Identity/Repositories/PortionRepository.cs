using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;
using System.Linq.Dynamic.Core;

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

        public async Task<List<FoodPortion>> GetFoodPortionsByFoodIdsAsync(List<Guid> foodPortions)
        {
            return await _context.FoodPortions
      .Include(fp => fp.Portion) // Bao gồm Portion để lấy liên kết
      .Where(fp => foodPortions.Contains(fp.FoodId))
      .ToListAsync();
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

        public async Task<List<Portion>> GetPortionsByFoodIdsAsync(List<Guid> foodIds)
        {
            if (foodIds == null || !foodIds.Any())
            {
                return new List<Portion>();
            }

            return await _context.Set<Portion>()
                .Include(p => p.FoodPortions) // Include liên kết tới FoodPortions nếu cần.
                .Where(p => p.FoodPortions.Any(fp => foodIds.Contains(fp.FoodId)))
                .ToListAsync();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
