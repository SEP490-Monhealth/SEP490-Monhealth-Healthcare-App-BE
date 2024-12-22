using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Food.DeleteFood
{

    public class DeleteFoodRequest : IRequest<bool>
    {
        public Guid FoodId { get; set; }
        public DeleteFoodRequest(Guid foodId)
        {
            FoodId = foodId;
        }

    }
}