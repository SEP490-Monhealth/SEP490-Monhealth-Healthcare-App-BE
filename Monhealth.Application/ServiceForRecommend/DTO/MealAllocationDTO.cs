namespace Monhealth.Application.ServiceForRecommend.DTO
{
    public class MealAllocationDTO
    {
        public float Calories { get; set; }
        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }
        public float Fiber { get; set; }
        public float Sugar { get; set; }
        public MealAllocationDTO()
        {
            Calories = 0;
            Protein = 0;
            Carbs = 0;
            Fat = 0;
            Fiber = 0;
            Sugar = 0;
        }
    }
}