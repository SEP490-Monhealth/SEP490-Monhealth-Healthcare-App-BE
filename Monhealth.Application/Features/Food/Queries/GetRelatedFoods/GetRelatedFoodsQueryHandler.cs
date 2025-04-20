using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Food.Queries.GetAllFoods;
using Monhealth.Application.Models;
using Monhealth.Core.Enum;

namespace Monhealth.Application.Features.Food.Queries.GetRelatedFoods
{
    public class GetRelatedFoodsQuery : IRequest<PageResult<FoodDTO>>
    {
        public Guid FoodId { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
        public string? Search { get; set; }
        public bool? Status { get; set; }
        public GetRelatedFoodsQuery(Guid foodId, int page, int limit, string? search = null, bool? status = null)
        {
            FoodId = foodId;
            Page = page;
            Limit = limit;
            Search = search;
            Status = status;
        }
    }

    public class GetRelatedFoodsQueryHandler : IRequestHandler<GetRelatedFoodsQuery, PageResult<FoodDTO>>
    {
        private readonly IFoodRepository _foodRepository;

        public GetRelatedFoodsQueryHandler(IFoodRepository foodRepository, IMapper mapper)
        {
            _foodRepository = foodRepository;
        }

        public async Task<PageResult<FoodDTO>> Handle(GetRelatedFoodsQuery request, CancellationToken cancellationToken)
        {
            var foods = await _foodRepository.GetRelatedFoodBasedOnType(request.FoodId,request.Search, request.Status, request.Page, request.Limit );
            var foodDtoList = foods.Items.Select(food => new FoodDTO
            {
                FoodId = food.FoodId,
                UserId = food.UserId,
                FoodName = food.FoodName,
                MealType = food.MealType, // Chuyển từ chuỗi sang danh sách
                FoodDescription = food.FoodDescription,
                ReferenceUrl = food.ReferenceUrl,
                Allergies = food.FoodAllergies?
                           .Where(f => f.Allergy != null)
                           .Select(f => f.Allergy.AllergyName).ToList() ?? [],

                DishType = [..
                    food.DishTypeFoods?.Select(dtf => dtf.DishType.DishTypeName).ToList()
                    .Select(n=>(DishTypeEnum)Enum.Parse(typeof(DishTypeEnum),n)) ??[]
                                ],
                Category = food.CategoryFoods.Select(x => x.Category.CategoryName).FirstOrDefault() ?? "", // Nếu có quan hệ với Category
                Portion = food.FoodPortions.Select(fp => new GetPortionForGetAllFoodDTO
                {
                    PortionSize = fp.Portion.PortionSize,
                    PortionWeight = fp.Portion.PortionWeight,
                    MeasurementUnit = fp.Portion.MeasurementUnit
                }).FirstOrDefault() ?? null!,
                Nutrition = food.Nutrition != null
                     ? new GetNutritionForGetAllFoodDTO
                     {
                         Calories = food.Nutrition.Calories
                     }
                     : null!,
                Status = food.Status,
                IsPublic = food.IsPublic,
                CreatedAt = food.CreatedAt,
                UpdatedAt = food.UpdatedAt,
                UpdatedBy = food.UpdatedBy,
                CreatedBy = food.CreatedBy
            }).ToList();

            // Tạo kết quả phân trang
            return new PageResult<FoodDTO>()
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(foods.TotalCount / (double)request.Limit),
                TotalItems = foods.TotalCount,
                Items = foodDtoList
            };

        }
    }

}