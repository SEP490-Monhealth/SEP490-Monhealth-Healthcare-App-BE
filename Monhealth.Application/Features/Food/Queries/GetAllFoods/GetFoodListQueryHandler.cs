using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Food.Queries.GetAllFoods
{
    public class GetFoodListQueryHandler : IRequestHandler<GetFoodListQuery, PageResult<FoodDTO>>
    {
        private readonly IFoodRepository _foodRepository;
        private readonly IMapper _mapper;

        public GetFoodListQueryHandler(IFoodRepository foodRepository, IMapper mapper)
        {
            _foodRepository = foodRepository;
            _mapper = mapper;
        }

        public async Task<PageResult<FoodDTO>> Handle(GetFoodListQuery request, CancellationToken cancellationToken)
        {
            var paginatedFood = await _foodRepository.GetAllFoodAsync(request.Page, request.Limit, request.Search, request.Status, request.CategoryName, request.Popular, request.IsPublic);
            var foodDtoList = paginatedFood.Items.Select(food => new FoodDTO
            {
                FoodId = food.FoodId,
                UserId = food.UserId,
                FoodName = food.FoodName,
                MealType = food.MealType?.Split(',').ToList() ?? new List<string>(), // Chuyển từ chuỗi sang danh sách
                DishType = food.DishType?.Split(',').ToList() ?? new List<string>(), // Chuyển từ chuỗi sang danh sách
                FoodDescription = food.FoodDescription,
                Category = food.Category?.CategoryName, // Nếu có quan hệ với Category
                Portion = food.FoodPortions.Select(fp => new GetPortionForGetAllFoodDTO
                {
                    PortionSize = fp.Portion.PortionSize,
                    PortionWeight = fp.Portion.PortionWeight,
                    MeasurementUnit = fp.Portion.MeasurementUnit
                }).FirstOrDefault(),
                Nutrition = food.Nutrition != null
         ? new GetNutritionForGetAllFoodDTO
         {
             Calories = food.Nutrition.Calories
         }
         : null,
                Status = food.Status,
                IsPublic = food.IsPublic,
                CreatedAt = food.CreatedAt,
                UpdatedAt = food.UpdatedAt
            }).ToList();

            // Tạo kết quả phân trang
            return new PageResult<FoodDTO>()
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(paginatedFood.TotalCount / (double)request.Limit),
                TotalItems = paginatedFood.TotalCount,
                Items = foodDtoList
            };
        }
    }
}