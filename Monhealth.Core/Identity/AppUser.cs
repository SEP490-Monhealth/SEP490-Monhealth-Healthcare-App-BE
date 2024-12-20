using Microsoft.AspNetCore.Identity;
using Monhealth.Domain;

namespace Monhealth.Identity.Models
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FullName { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
        public string? Address { get; set; }
        public string? Avatar { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? VipStartDate { get; set; }
        public DateTime? VipExpireDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public string? Gender { get; set; }
        public bool Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }


        public Consultant Consultant { get; set; } //one to one 
        public ICollection<Food> Foods { get; set; }
        public InterestFood InterestFood { get; set; } //one to one
        public ICollection<Vital> Vitals { get; set; }
        public ICollection<Metric> Metrics { get; set; }
        public ICollection<Goal> Goals { get; set; }

    }
}
