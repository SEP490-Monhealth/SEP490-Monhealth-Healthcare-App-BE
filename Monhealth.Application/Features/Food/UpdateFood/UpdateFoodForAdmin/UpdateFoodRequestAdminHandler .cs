using MediatR;

namespace Monhealth.Application.Features.Food.UpdateFood.UpdateFoodForAdmin
{
    public class UpdateFoodRequestAdminHandler : IRequest<bool>
    {
        public Guid FoodId { get; }
        public UpdateFoodRequestAdmin RequestData { get; }

        public UpdateFoodRequestAdminHandler(Guid foodId, UpdateFoodRequestAdmin requestData)
        {
            FoodId = foodId;
            RequestData = requestData;
        }
    }
}