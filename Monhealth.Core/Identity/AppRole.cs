using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Monhealth.Identity.Models
{
    public class AppRole : IdentityRole<Guid>
    {
        [Required, MaxLength(100)]
        public string DisplayName { get; set; }
    }
}
