using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Food.Queries.GetAllFoods
{
    public class FoodDTO : BaseEntity
    {
        public Guid FoodId { get; set; }
        public Guid UserId { get; set; }
        public string FoodType { get; set; } = string.Empty;
        public List<string> Category { get; set; }
        public string FoodName { get; set; } = string.Empty;
        public string FoodDescription { get; set; } = string.Empty;
        public bool Status { get; set; }
        public GetPortionForGetAllFoodDTO Portion { get; set; }
        public GetNutritionForGetAllFoodDTO Nutrition { get; set; }

    }
    public class GetPortionForGetAllFoodDTO
    {
        public string PortionSize { get; set; } = string.Empty;
        public float PortionWeight { get; set; }
        public string MeasurementUnit { get; set; } = string.Empty;
    }
    public class GetNutritionForGetAllFoodDTO
    {
        public float Calories { get; set; }
    }
}
