using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
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

        public async Task<PaginatedResult<Portion>> GetAllPortionAsync(int page, int limit, string? sort, string? order)
        {
            IQueryable<Portion> query = _context.Portions.AsNoTracking().AsQueryable();

            // sap xep
            if (!string.IsNullOrEmpty(sort))
            {
                string sorting = $"{sort} {(order?.ToLower() == "desc" ? "descending" : "ascending")}";
                query = query.OrderBy(sorting);
            }

            int totalItems = await query.CountAsync();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<Portion>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems,
            };
        }

        public async Task<List<FoodPortion>> GetFoodPortionsByFoodIdsAsync(List<Guid> foodPortions)
        {
            return await _context.FoodPortions
      .Include(fp => fp.Portion) // Bao gồm Portion để lấy liên kết
      .Where(fp => foodPortions.Contains(fp.FoodId))
      .ToListAsync();
        }

        public async Task<Portion> GetOrCreatePortionAsync(string measurementUnit, string portionSize, float portionWeight)
        {
            var portion = await _context.Portions
                .FirstOrDefaultAsync(p => p.MeasurementUnit == measurementUnit && p.PortionSize == portionSize && p.PortionWeight == portionWeight);

            if (portion == null)
            {
                portion = new Portion
                {
                    MeasurementUnit = measurementUnit,
                    PortionSize = portionSize,
                    PortionWeight = portionWeight,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };

                _context.Portions.Add(portion);
                await _context.SaveChangesAsync();
            }

            return portion;
        }

        public async Task<Portion> GetPortionAsync(string measurementUnit, string portionSize, float portionWeight)
        {
            return await _context.Portions.FirstOrDefaultAsync(p =>
            p.MeasurementUnit == measurementUnit &&
            p.PortionSize == portionSize &&
            p.PortionWeight == portionWeight);
        }

        public async Task<PaginatedResult<Portion>> GetPortionsByFoodIdAsync(Guid foodId, int page, int limit, string? search, string? sort, string? order)
        {
            IQueryable<Portion> query = _context.Portions.AsNoTracking().AsQueryable();
            query = query.Where(f => f.FoodPortions.Any(fp => fp.FoodId == foodId));
            if (!string.IsNullOrEmpty(search))
            {
                // cho phep search khong dau
                query = query.Where(s => EF.Functions.Collate(s.PortionSize, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower().Trim()) ||
                    s.PortionWeight.ToString().ToLower().Contains(search.ToLower().Trim()));
            }
            // sap xep
            //if (!string.IsNullOrEmpty(sort))
            //{
            //    string sorting = $"{sort} {(order?.ToLower() == "desc" ? "descending" : "ascending")}";
            //    query = query.OrderBy(sorting);
            //}
            if (!string.IsNullOrEmpty(sort))
            {
                string? sortColumn = sort.ToLower() switch
                {
                    "size" => "PortionSize",
                    "weight" => "PortionWeight",
                    _ => null
                };

                if (sortColumn != null)
                {
                    string sorting = $"{sortColumn} {(order?.ToLower() == "desc" ? "descending" : "ascending")}";
                    query = query.OrderBy(sorting);
                }
            }

            int totalItems = await query.CountAsync();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<Portion>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems,
            };
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
