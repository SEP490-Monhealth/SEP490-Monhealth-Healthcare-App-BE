using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Meal.Commands.CreateMeal
{
    public class CreateMealCommandHandler : IRequestHandler<CreateMealCommand, Unit>
    {
        private readonly IMealRepository _mealRepository;
        private readonly IMealFoodRepository _mealFoodRepository;
        public CreateMealCommandHandler(IMealRepository mealRepository
        , IMealFoodRepository mealFoodRepository)
        {
            _mealRepository = mealRepository;
            _mealFoodRepository = mealFoodRepository;

        }

        public async Task<Unit> Handle(CreateMealCommand request, CancellationToken cancellationToken)
        {
            var existingMeal = await _mealRepository.GetByUserIdAndMealType(request.CreateMeal.UserId, request.CreateMeal.MealType);
            Monhealth.Domain.Meal model;
            if (request.CreateMeal.MealType != "Breakfast" && request.CreateMeal.MealType != "Lunch"
            && request.CreateMeal.MealType != "Dinner" && request.CreateMeal.MealType != "Snack")

                throw new Exception("MealType phải nhập đúng.");
            if (existingMeal != null)
            {
                model = existingMeal;
            }
            else
            {
                model = new Monhealth.Domain.Meal
                {
                    UserId = request.CreateMeal.UserId,
                    MealType = request.CreateMeal.MealType,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };
                _mealRepository.Add(model);
            }

            foreach (var item in request.CreateMeal.MealItems)
            {
                if (item.Quantity <= 0)
                    throw new Exception("Quantity phải lớn hơn hoặc bằng không");
                var existingMealItem = await _mealFoodRepository.GetByMealIdAndFoodId(model.MealId, item.FoodId);
                if (existingMealItem != null)
                {
                    existingMealItem.Quantity += item.Quantity;
                }
                else
                {
                    var MealFood = new Monhealth.Domain.MealFood
                    {
                        MealId = model.MealId,
                        FoodId = item.FoodId,
                        Quantity = item.Quantity,
                        PortionSize = item.PortionSize,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    };
                    _mealFoodRepository.Add(MealFood);
                }
            }
            await _mealRepository.SaveChangeAsync();
            return Unit.Value;
        }
    }
}