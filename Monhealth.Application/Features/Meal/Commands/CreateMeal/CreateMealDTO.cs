using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Meal.Commands.CreateMeal
{
    public class CreateMealDTO
    {
        public Guid UserId { get; set; }
        [JsonPropertyName("type")]
        public string MealType { get; set; } = string.Empty;
        public ICollection<MealFoodsDTO> MealItems { get; set; }
    }
    public class MealFoodsDTO
    {
        public Guid FoodId { get; set; }
        public string PortionSize { get; set; } = string.Empty;
        public int Quantity { get; set; }
    }
}