﻿using Monhealth.Core.Enum;
using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Meal : TimeEntity
    {
        [Key]
        public Guid MealId { get; set; }
        public Guid UserId { get; set; }
        public Guid? DailyMealId { get; set; }
        public MealType MealType { get; set; }
        public DateTime MealDate { get; set; }
        [ForeignKey(nameof(DailyMealId))]
        public DailyMeal DailyMeal { get; set; }
        public ICollection<MealFood> MealFoods { get; set; }
    }
}
