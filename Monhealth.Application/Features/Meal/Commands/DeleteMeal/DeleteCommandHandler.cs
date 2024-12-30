using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Meal.Commands.DeleteMeal
{
    public class DeleteCommandHandler : IRequestHandler<DeleteMealCommand, bool>
    {
        private readonly IMealRepository _mealRepository;

        public DeleteCommandHandler(IMealRepository mealRepository)
        {
            _mealRepository = mealRepository;
        }

        public async Task<bool> Handle(DeleteMealCommand request, CancellationToken cancellationToken)
        {
            var meal = await _mealRepository.GetByIdAsync(request.MealId);
            if (meal == null) throw new Exception("Bữa ăn không tồn tại.");
            _mealRepository.Remove(meal);
            await _mealRepository.SaveChangeAsync();
            return true;

        }
    }
}