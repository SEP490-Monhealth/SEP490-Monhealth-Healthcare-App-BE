using Monhealth.Domain.Common;
using Monhealth.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class UserFood : TimeEntity
    {
        [Key]

        public Guid UserFoodId { get; set; }
        public Guid UserId { get; set; }
        public string Categories { get; set; }
        public string Allergies { get; set; }
        [ForeignKey(nameof(UserId))]
        public AppUser User { get; set; }
    }
}
