using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Core.Enum;

namespace Monhealth.Application.Features.Food.Queries.GetFoodById
{
    public class GetFoodByIdQueryHandler : IRequestHandler<GetFoodByIdQuery, GetFoodByIdDTO>
    {
        private readonly IFoodRepository _foodRepository;
        private readonly IMapper _mapper;

        public GetFoodByIdQueryHandler(IFoodRepository foodRepository,
        IMapper mapper)
        {
            _foodRepository = foodRepository;
            _mapper = mapper;
        }

        public async Task<GetFoodByIdDTO> Handle(GetFoodByIdQuery request, CancellationToken cancellationToken)
        {
            var gettingFood = await _foodRepository.GetFoodByIdAsync(request.FoodId);
            var result = new GetFoodByIdDTO
            {
                FoodId = gettingFood.FoodId,
                UserId = gettingFood.UserId,
                DishType = [..
                    gettingFood.DishTypeFoods?.Select(dtf => dtf.DishType.DishTypeName).ToList()
                    .Select(n=>(DishTypeEnum)Enum.Parse(typeof(DishTypeEnum),n)) ??[]
                    ],
                Category = gettingFood.CategoryFoods?.Select(x => x.Category.CategoryName).FirstOrDefault() ?? "",
                MealType = gettingFood.MealType, // Chuyển từ chuỗi sang danh sách
                FoodDescription = gettingFood.FoodDescription,
                Allergies = gettingFood.FoodAllergies?
               .Where(f => f.Allergy != null)
               .Select(f => f.Allergy.AllergyName).ToList() ?? [],
                FoodName = gettingFood.FoodName,
                ReferenceUrl = gettingFood.ReferenceUrl,
                IsPublic = gettingFood.IsPublic,
                Status = gettingFood.Status,
                CreatedAt = gettingFood.CreatedAt,
                UpdatedAt = gettingFood.UpdatedAt,
                CreatedBy = gettingFood.CreatedBy,
                UpdatedBy = gettingFood.UpdatedBy,
            };
            return result;
        }
    }
}