using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;

namespace Monhealth.Application.Features.Meal.Commands.CreateMeal
{
    public class CreateMealCommandHandler : IRequestHandler<CreateMealCommand, Unit>
    {
        private readonly IMealRepository _mealRepository;
        private readonly IMealFoodRepository _mealFoodRepository;
        private readonly IPortionRepository _portionRepository;
        private readonly IFoodPortionRepository _foodPortionRepository;
        public CreateMealCommandHandler(IMealRepository mealRepository
        , IMealFoodRepository mealFoodRepository,
        IPortionRepository portionRepository,
        IFoodPortionRepository foodPortionRepository)
        {
            _mealRepository = mealRepository;
            _mealFoodRepository = mealFoodRepository;
            _portionRepository = portionRepository;
            _foodPortionRepository = foodPortionRepository;

        }

        public async Task<Unit> Handle(CreateMealCommand request, CancellationToken cancellationToken)
        {
            var existingMeal = await _mealRepository.GetByUserIdAndMealType(request.CreateMeal.UserId, request.CreateMeal.MealType);
            Monhealth.Domain.Meal model;
            var validMealTypes = new HashSet<string> { "Breakfast", "Lunch", "Dinner", "Snack" };
            if (!validMealTypes.Contains(request.CreateMeal.MealType))
                throw new ArgumentException("MealType phải là một trong các giá trị: Breakfast, Lunch, Dinner, Snack.");
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
                if (item.Quantity <= 0) throw new Exception("Quantity phải lớn hơn hoặc bằng 0.");
                var existingPortion = await _portionRepository.GetPortionAsync(item.MeasurementUnit,
                item.PortionSize, item.PortionWeight);
                Portion portion;
                if (existingPortion != null)
                {
                    portion = existingPortion;
                }
                else
                {
                    portion = new Portion
                    {

                        MeasurementUnit = item.MeasurementUnit,
                        PortionSize = item.PortionSize,
                        PortionWeight = item.PortionWeight,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    };
                    _portionRepository.Add(portion);
                    _foodPortionRepository.Add(new FoodPortion
                    {
                        FoodId = item.FoodId,
                        PortionId = portion.PortionId
                    });
                }


                var existingMealItem = await _mealFoodRepository.GetByMealIdAndFoodId(model.MealId, item.FoodId);
                if (existingMealItem != null)
                {
                    existingMealItem.Quantity += item.Quantity;
                    existingMealItem.UpdatedAt = DateTime.Now;
                }
                else
                {
                    var MealFood = new Monhealth.Domain.MealFood
                    {
                        MealId = model.MealId,
                        FoodId = item.FoodId,
                        Quantity = item.Quantity,
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