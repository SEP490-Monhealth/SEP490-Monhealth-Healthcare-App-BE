using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Meal.NewClassForMeal
{
    public class NutritionTotals
    {

        public float Calories { get; set; }
        public float Proteins { get; set; }
        public float Carbs { get; set; }
        public float Fats { get; set; }
        public float Fibers { get; set; }
        public float Sugars { get; set; }
        public NutritionTotals()
        {
            Calories = 0;
            Proteins = 0;
            Carbs = 0;
            Fats = 0;
            Fibers = 0;
            Sugars = 0;
        }
        public void Add(NutritionTotals other)
        {
            if (other == null) return;

            Calories += other.Calories;
            Proteins += other.Proteins;
            Carbs += other.Carbs;
            Fats += other.Fats;
            Fibers += other.Fibers;
            Sugars += other.Sugars;
        }
    }
}