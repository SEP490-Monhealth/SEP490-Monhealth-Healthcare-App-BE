using MediatR;
using Monhealth.Application.Contracts.Persistence;


namespace Monhealth.Application.Features.Food.ChangeStatus
{
    public class ChangeStatusByIdHandler : IRequestHandler<ChangeStatusByFoodIdQuery, bool>
    {
        private readonly IFoodRepository _foodRepository;

        public ChangeStatusByIdHandler(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }

        public async Task<bool> Handle(ChangeStatusByFoodIdQuery request, CancellationToken cancellationToken)
        {
            var food = await _foodRepository.GetByIdAsync(request.FoodId);
            if (food == null) throw new Exception("Thức ăn không tồn tại. ");
            food.Status = !food.Status;
            await _foodRepository.SaveChangesAsync();
            return true;
        }
    }
}