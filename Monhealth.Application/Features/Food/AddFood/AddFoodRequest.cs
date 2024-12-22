using MediatR;

namespace Monhealth.Application.Features.Food.AddFood
{
    public class AddFoodRequest : IRequest<bool>
    {
        public Guid UserId { get; set; }
        public string FoodType { get; set; } = string.Empty;
        public List<string> CategoryName { get; set; } = new List<string>(); 
        public string FoodName { get; set; } = string.Empty;
        public string FoodDescription { get; set; } = string.Empty;
        public string PortionSize { get; set; } = string.Empty; 
        public float PortionWeight { get; set; }
        public string MeasurementUnit { get; set; } = string.Empty;
        public float Calories { get; set; } 
        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }
        public float Fiber { get; set; }
        public float Sugar { get; set; }
    }
}