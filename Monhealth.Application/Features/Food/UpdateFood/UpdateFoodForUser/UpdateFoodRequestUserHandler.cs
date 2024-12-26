using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Food.UpdateFood.UpdateFoodForUser
{
    public class UpdateFoodRequestUserHandler : IRequest<bool>
    {
        public Guid FoodId { get; }
        public UpdateFoodRequestUser RequestData { get; }
        public UpdateFoodRequestUserHandler(Guid foodId, UpdateFoodRequestUser requestUser)
        {
            FoodId = foodId;
            RequestData = requestUser;
        }

    }
}