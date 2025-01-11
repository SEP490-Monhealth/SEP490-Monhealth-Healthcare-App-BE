using System.ComponentModel.DataAnnotations;

namespace Monhealth.Core
{
    public class Allergy
    {
        [Key]
        public Guid AllergyId { get; set; }
        public string AllergyName { get; set; } = string.Empty;
        public string AllergyDescription { get; set; } = string.Empty;
        public ICollection<FoodAllergy> foodAllergies { get; set; }
        public ICollection<UserAllergy> userAllergies { get; set; }
    }
}