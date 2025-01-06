using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.MealFood.Commands.UpdateStatusMealFood
{
    public class ChangeStatusMealFoodHandler : IRequestHandler<ChangeStatusMealFoodQuery, bool>
    {
        private readonly IMealFoodRepository _mealFoodRepository;

        public ChangeStatusMealFoodHandler(IMealFoodRepository mealFoodRepository)
        {
            _mealFoodRepository = mealFoodRepository;
        }

        public async Task<bool> Handle(ChangeStatusMealFoodQuery request, CancellationToken cancellationToken)
        {
             var mealFood = await _mealFoodRepository.GetByIdAsync(request.MealFoodId);
             mealFood.Status = !mealFood.Status;
             _mealFoodRepository.Update(mealFood);
             await _mealFoodRepository.SaveChangeAsync();
             return true;
        }
    }
}