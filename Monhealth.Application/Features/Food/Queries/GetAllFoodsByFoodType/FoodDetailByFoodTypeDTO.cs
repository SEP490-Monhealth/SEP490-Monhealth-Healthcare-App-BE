using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Food.Queries.GetAllFoodsByFoodType
{
    public class FoodDetailByFoodTypeDTO : BaseEntity
    {
        public Guid FoodId { get; set; }
        public Guid UserId { get; set; }
        public string FoodType { get; set; } = string.Empty;
        public List<string> CategoryName { get; set; }
        public string FoodName { get; set; } = string.Empty;
        public string FoodDescription { get; set; } = string.Empty;
        public bool Status { get; set; }
    }
}