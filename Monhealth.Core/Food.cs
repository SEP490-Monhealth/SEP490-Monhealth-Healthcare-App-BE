using Monhealth.Core;
using Monhealth.Core.Enum;
using Monhealth.Domain.Common;
using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
        public class Food : BaseEntity
        {
                [Key]
                public Guid FoodId { get; set; }
                public Guid UserId { get; set; }
                public Guid? CategoryId { get; set; }
                public List<FoodType> FoodType { get; set; } = new List<FoodType>();
                public List<MealType> MealType { get; set; } = new List<MealType>();
                public List<DishType> DishType { get; set; } = new List<DishType>();
                public string FoodName { get; set; } = string.Empty;
                public string FoodDescription { get; set; } = string.Empty;
                // public bool IsRecommended { get; set; } = false;
                public int Views { get; set; } = 0;
                public bool IsPublic { get; set; }
                public bool Status { get; set; }
                [ForeignKey(nameof(CategoryId))]
                public Category Category { get; set; }
                [ForeignKey(nameof(UserId))]
                public AppUser AppUser { get; set; }
                public Nutrition Nutrition { get; set; }
                public ICollection<FoodPortion> FoodPortions { get; set; }
                public ICollection<MealFood> MealFoods { get; set; }
                public ICollection<FoodAllergy> FoodAllergies { get; set; }
        }
}