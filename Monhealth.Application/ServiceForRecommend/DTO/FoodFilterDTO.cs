using System.Text.Json.Serialization;
using Monhealth.Core.Enum;
namespace Monhealth.Application.ServiceForRecommend
{
    public class FoodFilterDTO
    {
        public Guid FoodId { get; set; }
        public List<string> Category { get; set; } = [];
        public List<MealType> MealType { get; set; }
        public List<DishTypeEnum> DishType { get; set; }
        public List<FoodType> FoodType { get; set; } // 🛠 Thêm thuộc tính FoodType
        public float Calories { get; set; }
        [JsonPropertyName("name")]
        public string FoodName { get; set; } = string.Empty;
    }
}