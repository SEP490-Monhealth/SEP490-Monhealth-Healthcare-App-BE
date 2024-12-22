using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Food.UpdateFood.UpdateFoodForAdmin
{
    public class UpdateFoodRequestAdmin : IRequest<bool>
    {
      
        public string FoodType { get; set; } = string.Empty;
        public List<string> Category { get; set; } = new List<string>();
        public string FoodName { get; set; } = string.Empty;
        public string FoodDescription { get; set; } = string.Empty;
      
    }
   
}