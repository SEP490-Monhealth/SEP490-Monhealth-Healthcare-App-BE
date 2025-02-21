using System.Text.Json.Serialization;
using Monhealth.Core.Enum;

namespace Monhealth.Application.ServiceForRecommend
{
    public class FoodFilterDTO
    {
        public Guid FoodId { get; set; }
        public string Category { get; set; } = string.Empty;
        public List<MealType> MealType { get; set; }
        public List<DishType> DishType { get; set; }
        public List<FoodType> FoodType { get; set; } // 🛠 Thêm thuộc tính FoodType
        public float Calories { get; set; }
        [JsonPropertyName("name")]
        public string FoodName { get; set; } = string.Empty;
    }
}