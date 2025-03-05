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
                public List<FoodType> FoodType { get; set; } = [];
                public List<MealType> MealType { get; set; } = [];
                public List<DishType> DishType { get; set; } = [];
                public string FoodName { get; set; } = string.Empty;
                public string FoodDescription { get; set; } = string.Empty;
                public int Views { get; set; } = 0;
                public bool IsPublic { get; set; }
                public bool Status { get; set; }

                [ForeignKey(nameof(UserId))]
                public AppUser AppUser { get; set; } = null!;
                public Nutrition Nutrition { get; set; } = null!;
                public ICollection<CategoryFood> CategoryFoods { get; set; } = [];
                public ICollection<FoodPortion> FoodPortions { get; set; } = [];
                public ICollection<MealFood> MealFoods { get; set; } = [];
                public ICollection<FoodAllergy> FoodAllergies { get; set; } = [];
        }
}