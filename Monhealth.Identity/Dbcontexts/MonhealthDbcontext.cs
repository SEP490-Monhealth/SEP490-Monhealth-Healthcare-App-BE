using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Monhealth.Core;
using Monhealth.Domain;
using Monhealth.Identity.Configurations;
using Monhealth.Identity.Models;

namespace Monhealth.Identity.Dbcontexts
{
    public class MonhealthDbcontext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public MonhealthDbcontext(DbContextOptions<MonhealthDbcontext> options) : base(options)
        {

        }

        public DbSet<Metric> Metrics { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<DailyMeal> DailyMeals { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Portion> Portions { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealFood> MealFoods { get; set; }
        public DbSet<Nutrition> Nutritions { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<FoodPortion> FoodPortions { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Allergy> Allergies { get; set; }
        public DbSet<UserAllergy> UserAllergies { get; set; }
        public DbSet<FoodAllergy> FoodAllergies { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<CertificateImage> CertificateImages { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<UserSubscription> UserSubscriptions { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<UserFood> UserFoods { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // builder.ApplyConfigurationsFromAssembly(typeof(MonhealthDbcontext).Assembly);
            builder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles")
         .HasKey(x => new { x.RoleId, x.UserId });



            // One-to-One relationship between Foods and Nutrition
            builder.Entity<Food>()
                .HasOne(f => f.Nutrition)
                .WithOne(n => n.Food)
                .HasForeignKey<Nutrition>(n => n.FoodId) // Nutrition.FoodId references Food.FoodId
                .OnDelete(DeleteBehavior.Restrict); // Avoid cascading delete

            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new FoodConfiguration());
            // builder.ApplyConfiguration(new FoodCategoryConfiguration());
            builder.ApplyConfiguration(new PortionConfiguration());
            builder.ApplyConfiguration(new NutritionConfiguration());
            builder.ApplyConfiguration(new FoodPortionConfiguration());
            builder.ApplyConfiguration(new AllergyConfiguration());
        }

    }
}
