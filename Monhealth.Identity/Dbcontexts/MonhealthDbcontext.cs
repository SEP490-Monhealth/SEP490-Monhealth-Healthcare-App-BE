using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Monhealth.Core.Enum;
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
        public DbSet<WaterReminder> WaterReminders { get; set; }
        public DbSet<FoodPortion> FoodPortions { get; set; }
        public DbSet<Allergy> Allergies { get; set; }
        public DbSet<UserAllergy> UserAllergies { get; set; }
        public DbSet<FoodAllergy> FoodAllergies { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<UserSubscription> UserSubscriptions { get; set; }
        //public DbSet<Service> Services { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<UserFood> UserFoods { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<WorkoutExercise> WorkoutExercises { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<DailyActivity> DailyActivities { get; set; }
        public DbSet<DailyWaterIntake> DailyWaterIntakes { get; set; }
        public DbSet<Consultant> Consultants { get; set; }
        public DbSet<Expertise> Expertises { get; set; }
        //public DbSet<ConsultantExpertise> ConsultantExpertises { get; set; }

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

            builder.Entity<DailyActivity>()
                .HasOne(d => d.Goal)
                .WithMany(g => g.DailyActivities)
                .HasForeignKey(d => d.GoalId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<DailyWaterIntake>()
                .HasOne(dwi => dwi.Goal)
                .WithMany(g => g.DailyWaterIntakes)
                .HasForeignKey(dwi => dwi.GoalId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<WorkoutExercise>()
                .HasOne(we => we.Workout)
                .WithMany(w => w.WorkoutExercises)
                .HasForeignKey(we => we.WorkoutId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<WorkoutExercise>()
                .HasOne(we => we.Exercise)
                .WithMany(e => e.WorkoutExercises)
                .HasForeignKey(we => we.ExerciseId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<UserFood>(entity =>
            {
                entity.Property(e => e.Categories)
                    .HasConversion(
                      v => string.Join(',', v), // Chuyển từ List<string> thành chuỗi
                      v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList() // Chuyển chuỗi thành List<string>
                  );

                entity.Property(e => e.Allergies)
                    .HasConversion(
                        v => string.Join(',', v),
                        v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList()
                    );
            });
            builder.Entity<Food>(entity =>
            {
                entity.Property(e => e.MealType)
                    .HasConversion(
                        v => string.Join(',', v.Select(x => x.ToString())), // Từ List<MealType> -> string
                        v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                              .Select(x => Enum.Parse<MealType>(x)) // Từ string -> List<MealType>
                              .ToList()
                    );

                entity.Property(e => e.DishType)
                    .HasConversion(
                        v => string.Join(',', v.Select(x => x.ToString())), // Từ List<DishType> -> string
                        v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                              .Select(x => Enum.Parse<DishType>(x)) // Từ string -> List<DishType>
                              .ToList()
                    );
            });
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
            builder.ApplyConfiguration(new ExerciseConfiguration());
            // builder.ApplyConfiguration(new FoodAllergyConfiguration());
            builder.ApplyConfiguration(new WorkoutConfiguration());
            builder.ApplyConfiguration(new WorkoutExerciseConfiguration());
            builder.ApplyConfiguration(new SubscriptionConfiguration());
        }
    }
}
