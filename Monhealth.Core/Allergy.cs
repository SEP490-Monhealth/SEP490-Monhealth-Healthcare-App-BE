using System.ComponentModel.DataAnnotations;
using Monhealth.Domain.Common;

namespace Monhealth.Core
{
    public class Allergy : TimeEntity
    {
        [Key]
        public Guid AllergyId { get; set; }
        public string AllergyName { get; set; } = string.Empty;
        public string AllergyDescription { get; set; } = string.Empty;

        public ICollection<FoodAllergy> foodAllergies { get; set; }
        public ICollection<UserAllergy> userAllergies { get; set; }
    }
}