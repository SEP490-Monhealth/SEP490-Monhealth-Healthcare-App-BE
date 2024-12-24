using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Food.Queries.GetFoodById
{
    public class GetFoodByIdDTO : BaseEntity
    {
        public string FoodName { get; set; }
        public string Category { get; set; }
        public string FoodDescription { get; set; } = string.Empty;
        public bool Status { get; set; }
    }
}