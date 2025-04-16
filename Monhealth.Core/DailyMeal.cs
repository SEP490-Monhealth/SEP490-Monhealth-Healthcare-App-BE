using Monhealth.Domain.Common;
using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class DailyMeal : TimeEntity
    {
        [Key]
        public Guid DailyMealId { get; set; }
        public Guid UserId { get; set; }
        public Guid GoalId { get; set; }
        public DateTime DailyMealDate { get; set; } 
        public float TotalCalories { get; set; }
        public float TotalProteins { get; set; }
        public float TotalCarbs { get; set; }
        public float TotalFats { get; set; }
        public float TotalFibers { get; set; }
        public float TotalSugars { get; set; }

        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; }
        [ForeignKey(nameof(GoalId))]
        public Goal Goal { get; set; }
        public ICollection<Meal> Meals { get; set; }
    }
}
