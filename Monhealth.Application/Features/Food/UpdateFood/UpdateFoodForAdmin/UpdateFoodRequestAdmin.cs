using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Food.UpdateFood.UpdateFoodForAdmin
{
    public class UpdateFoodRequestAdmin : IRequest<bool>
    {
        public string Category { get; set; } = string.Empty;
        public string FoodName { get; set; } = string.Empty;
        public string FoodDescription { get; set; } = string.Empty;

    }

}