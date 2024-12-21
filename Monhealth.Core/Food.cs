﻿using Monhealth.Core;
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
        // Foreign Key
        public Guid UserId { get; set; }
        public string FoodType { get; set; } = string.Empty;
        public string FoodDescription { get; set; } = string.Empty;
        public string FoodName { get; set; } = string.Empty;
        public bool Status { get; set; }
        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; } // One-to-one with AppUser

        public Nutrition Nutrition { get; set; } // One-to-one with Nutrition

        public ICollection<FoodCategory> FoodCategories { get; set; }
        public ICollection<FoodPortion> FoodPortions { get; set; }
        public ICollection<MealFood> MealFoods { get; set; }
    }
}
