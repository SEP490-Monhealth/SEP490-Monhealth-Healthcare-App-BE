using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Food.Queries.GetFoodById
{
    public class GetFoodByIdDTO
    {
        public string FoodName { get; set; }
        public List<string> Category { get; set; }
        public bool Status { get; set; }
    }
}