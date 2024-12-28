using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.MealFood.Commands.UpdateMealFood
{
    public class MealFoodCommandHandler : IRequestHandler<MealFoodCommand, bool>
    {
        IMealFoodRepository _mealFoodRepository;

        public MealFoodCommandHandler(IMealFoodRepository mealFoodRepository)
        {
            _mealFoodRepository = mealFoodRepository;
        }

        public async Task<bool> Handle(MealFoodCommand request, CancellationToken cancellationToken)
        {
            var mealFood = await _mealFoodRepository.GetByIdAsync(request.MealFoodId);
            if (mealFood == null) throw new Exception("MealFood không tồn tại.");
            mealFood.Quantity = request.Quantity;
            mealFood.UpdatedAt = DateTime.Now;
            _mealFoodRepository.Update(mealFood);
            await _mealFoodRepository.SaveChangeAsync();
            return true;
        }
    }
}