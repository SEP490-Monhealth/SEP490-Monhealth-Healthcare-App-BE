using Microsoft.AspNetCore.Identity;
using Monhealth.Core;
using Monhealth.Domain;

namespace Monhealth.Identity.Models
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FullName { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
        public string? Avatar { get; set; }
        public bool Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        public ICollection<Reminder> Reminders { get; set; }
        public Consultant Consultant { get; set; } //one to one 
        public ICollection<Food> Foods { get; set; }
        public InterestFood InterestFood { get; set; } //one to one
        public ICollection<Metric> Metrics { get; set; }
        public ICollection<Goal> Goals { get; set; }
        public ICollection<UserAllergy> UserAllergies { get; set; }
    }
}
