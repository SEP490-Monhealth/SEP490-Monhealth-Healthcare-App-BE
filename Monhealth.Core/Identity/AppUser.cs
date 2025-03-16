using Microsoft.AspNetCore.Identity;
using Monhealth.Core;
using Monhealth.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Identity.Models
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FullName { get; set; } = null!;
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
        public string? Avatar { get; set; }
        public bool Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        public ICollection<Metric> Metrics { get; set; }
        public ICollection<Goal> Goals { get; set; }
        public ICollection<Food> Foods { get; set; }
        public ICollection<WaterReminder> WaterReminders { get; set; }
        public ICollection<Exercise> Exercises { get; set; }
        public ICollection<Workout> Workouts { get; set; }
        public ICollection<UserAllergy> UserAllergies { get; set; }
        //public ICollection<Certificate> Certificates { get; set; }
        public ICollection<UserSubscription> UserSubscriptions { get; set; } = [];
        public ICollection<Schedule> Schedules { get; set; } = [];
        //public ICollection<Service> Services { get; set; }
        [InverseProperty(nameof(Booking.User))]
        public ICollection<Booking> UserBookings { get; set; } = [];
        // [InverseProperty(nameof(Booking.Consultant))]
        // public ICollection<Booking> ConsultantBookings { get; set; }
        public ICollection<Activity> Activities { get; set; } = [];
        public ICollection<DailyActivity> DailyActivities { get; set; } = [];
        public ICollection<DailyWaterIntake> DailyWaterIntakes { get; set; } = [];
        public ICollection<UserCategory> UserCategories { get; set; } = [];
        public ICollection<Payment> Payments { get; set; } = [];
        public ICollection<Review> Reviews { get; set; } = [];
    }
}
