using Monhealth.Core;
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
                public string MealType { get; set; } = string.Empty;
                public string DishType { get; set; } = string.Empty;
                public string FoodName { get; set; } = string.Empty;
                public string FoodDescription { get; set; } = string.Empty;
                public int Views { get; set; } = 0;
                public bool Status { get; set; }
                public bool IsPublic { get; set; }
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