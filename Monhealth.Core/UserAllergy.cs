using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Monhealth.Identity.Models;

namespace Monhealth.Core
{
    public class UserAllergy
    {
        [Key]
        public Guid UserAllergyId { get; set; }
        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public AppUser AppUser{get ;set;}
        public Guid AllergyId { get; set; }
        [ForeignKey(nameof(AllergyId))]
        public Allergy Allergy { get; set; }
    }
}