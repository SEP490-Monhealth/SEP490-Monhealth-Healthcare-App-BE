﻿using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;


namespace Monhealth.Identity.Repositories
{
    public class FoodRepository : GenericRepository<Food, Guid>, IFoodRepository
    {
        public FoodRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<PaginatedResult<Food>> GetAllFoodAsync(int page, int limit, string? search, bool? status, string categoryName, string foodType)
        {
            search = search?.Trim();
            IQueryable<Food> query = _context.Foods.Include(f => f.Category).
            Include(f => f.Nutrition).Include(f => f.FoodPortions).ThenInclude(f => f.Portion).AsQueryable();

            // filter search
            if (!string.IsNullOrEmpty(search))
            {
                // cho phep search khong dau
                query = query.Where(s => EF.Functions.Collate(s.FoodName, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower()) ||
                    s.FoodId.ToString().ToLower().Contains(search.ToLower()));
            }
            if (!string.IsNullOrEmpty(categoryName))
                query = query.Where(f => f.Category.CategoryName == categoryName);
            //filter FoodType
            if (!string.IsNullOrEmpty(foodType))
                query = query.Where(f => f.FoodType == foodType);
            // filter status
            if (status.HasValue)
            {
                query = query.Where(s => s.Status == status.Value);
            }
            int totalItems = await query.CountAsync();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<Food>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }

        public async Task<List<Food>> GetByIdsAsync(IEnumerable<Guid> foodIds)
        {
            return await _context.Foods
                         .Include(f => f.FoodPortions)
                         .Where(f => foodIds.Contains(f.FoodId))
                         .ToListAsync();
        }

        public async Task<Food> GetByIdWithCategoriesAsync(Guid foodId)
        {
            return await _context.Foods
        .Include(f => f.Category)
        .Include(f => f.FoodPortions)
        .FirstOrDefaultAsync(f => f.FoodId == foodId);
        }

        public async Task<List<Food>> GetFoodByCategoryName(string categoryName)
        {
            return await _context.Foods.Where(f => f.Category.CategoryName == categoryName)
            .ToListAsync();
        }
        public async Task<Food> GetFoodByIdAsync(Guid foodId)
        {
            return await _context.Foods.
            Include(fc => fc.Category).Include(fc => fc.Nutrition)
            .Include(fc => fc.FoodPortions).ThenInclude(fc => fc.Portion)
            .FirstOrDefaultAsync(f => f.FoodId == foodId);
        }

        public async Task<Food> GetFoodByNameAsync(string foodName)
        {
            return await _context.Foods.FirstOrDefaultAsync(f => f.FoodName == foodName);
        }

        public async Task<PaginatedResult<Food>> GetFoodByUserId(int page, int limit, Guid userId)
        {
            // Truy vấn dữ liệu cơ bản
            IQueryable<Food> query = _context.Foods
                .Where(f => f.UserId == userId)
                .Include(f => f.Category)
                .Include(f => f.Nutrition)
                .Include(f => f.FoodPortions).ThenInclude(fp => fp.Portion);

            // Tính tổng số lượng bản ghi
            int totalItems = await query.CountAsync();

            // Tăng số lượt xem (Views) bằng SQL trực tiếp
            await _context.Database.ExecuteSqlRawAsync(
                "UPDATE Foods SET Views = Views + 1 WHERE UserId = {0}", userId);

            // Áp dụng phân trang
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }

            // Trả về kết quả phân trang
            return new PaginatedResult<Food>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }


        public async Task<List<Food>> GetFoodListByFoodType(string foodType)
        {
            return await _context.Foods.Where(f => f.FoodType == foodType)
            .Include(f => f.Category).Include(f => f.Nutrition).
            Include(f => f.FoodPortions).ThenInclude(f => f.Portion).ToListAsync();

        }

        public async Task<List<Food>> GetFoodsByCategoryNameAsync(string[] categoryNames)
        {
            return await _context.Foods.Where(f => categoryNames.Contains(f.Category.CategoryName)).
               Include(f => f.Nutrition).Include(f => f.FoodPortions).ThenInclude(f => f.Portion).ToListAsync();

        }

        // public void RemoveFoodCategories(Guid foodId)
        // {
        //     var categoriesToRemove = _context.FoodCategories.Where(fc => fc.FoodId == foodId);
        //     _context.FoodCategories.RemoveRange(categoriesToRemove);
        // }

        public void RemoveFoodPortions(Guid foodId)
        {
            var portionsToRemove = _context.FoodPortions.Where(fp => fp.FoodId == foodId);
            _context.FoodPortions.RemoveRange(portionsToRemove);
        }



        // public async Task<List<Food>> GetFoodListByUser(Guid userId)
        // {
        //     var isCustomer = await _context.Roles.Where(role => role.Name == "Customer")
        //                         .Join(_context.UserRoles,
        //                               role => role.Id,
        //                               userRole => userRole.RoleId,
        //                               (role, userRole) => userRole.UserId)
        //                         .Distinct()
        //                         .ToListAsync();
        //     if (isCustomer == null)
        //     {

        //         return new List<Food>();
        //     }


        //     var foods = await _context.Foods
        //         .Where(f => f.UserId == userId)
        //         .ToListAsync();

        //     return foods;
        // }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
