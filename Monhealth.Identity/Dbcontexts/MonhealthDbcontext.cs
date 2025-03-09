using System.Text.Json;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Logging;
using Monhealth.Core;
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
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<WorkoutExercise> WorkoutExercises { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<DailyActivity> DailyActivities { get; set; }
        public DbSet<DailyWaterIntake> DailyWaterIntakes { get; set; }
        public DbSet<Consultant> Consultants { get; set; }
        public DbSet<Expertise> Expertises { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ScheduleTimeSlot> ScheduleTimeSlots { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }
        public DbSet<ScheduleException> ScheduleExceptions { get; set; }
        public DbSet<CategoryFood> CategoryFoods { get; set; }
        public DbSet<UserCategory> UserCategories { get; set; }
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

            builder.Entity<DailyMeal>()
                .HasOne(d => d.Goal)
                .WithMany(g => g.DailyMeals)
                .HasForeignKey(d => d.GoalId)
                .OnDelete(DeleteBehavior.Restrict);

            // builder.Entity<UserFood>(entity =>
            // {
            //     entity.Property(e => e.Categories)
            //         .HasConversion(
            //           v => string.Join(',', v), // Chuyển từ List<string> thành chuỗi
            //           v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList() // Chuyển chuỗi thành List<string>
            //       );

            //     entity.Property(e => e.Allergies)
            //         .HasConversion(
            //             v => string.Join(',', v),
            //             v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList()
            //         );
            // });
            // Create Value Comparers for List<MealType> and List<DishType>

            var mealTypeComparer = new ValueComparer<List<MealType>>(
                (c1, c2) => c1.SequenceEqual(c2),
                c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                c => c.ToList()
            );

            var dishTypeComparer = new ValueComparer<List<DishType>>(
                (c1, c2) => c1.SequenceEqual(c2),
                c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                c => c.ToList()
            );

            builder.Entity<Food>(entity =>
            {
                entity.Property(e => e.FoodType)
                    .HasConversion(
                        v => string.Join(',', v.Select(x => x.ToString())), // Từ List<FoodType> -> string
                        v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                              .Select(x => Enum.Parse<FoodType>(x)) // Từ string -> List<FoodType>
                              .ToList()
                    );

                entity.Property(e => e.MealType)
                    .HasConversion(
                        v => string.Join(',', v.Select(x => x.ToString())),
                        v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                              .Select(x => Enum.Parse<MealType>(x))
                              .ToList()
                    )
                   .Metadata.SetValueComparer(mealTypeComparer);

                entity.Property(e => e.DishType)
                    .HasConversion(
                        v => string.Join(',', v.Select(x => x.ToString())),
                        v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                              .Select(x => Enum.Parse<DishType>(x))
                              .ToList()
                    )
                    .Metadata.SetValueComparer(dishTypeComparer);
            });
            //builder.Entity<ScheduleTimeSlot>()
            //    .HasOne(s => s.Status)
            //    .WithMany()
            //     .HasForeignKey(s => s.ScheduleTimeSlotId)
            //     .OnDelete(DeleteBehavior.NoAction); // Prevent cyclic delete paths

            builder.Entity<Food>(entity =>
            {
                // Configure FoodType as List<string> and log the configuration
                entity.Property(e => e.FoodType)
                    .HasConversion(
                        v => string.Join(',', v.Select(x => x.ToString())), // Convert List<FoodType> to string
                        v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => Enum.Parse<FoodType>(x)) // Convert string back to List<FoodType>
                            .ToList()
                    );

                // Configure MealType with ValueComparer and log the configuration
                entity.Property(e => e.MealType)
                    .HasConversion(
                        v => string.Join(',', v.Select(x => x.ToString())), // Convert List<MealType> to string
                        v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => Enum.Parse<MealType>(x)) // Convert string back to List<MealType>
                            .ToList()
                    )
                    .Metadata.SetValueComparer(mealTypeComparer); // Set ValueComparer

                // Configure DishType with ValueComparer and log the configuration
                entity.Property(e => e.DishType)
                    .HasConversion(
                        v => string.Join(',', v.Select(x => x.ToString())), // Convert List<DishType> to string
                        v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => Enum.Parse<DishType>(x)) // Convert string back to List<DishType>
                            .ToList()
                    )
                    .Metadata.SetValueComparer(dishTypeComparer); // Set ValueComparer
            });
            var stringListConverter = new ValueConverter<List<string>, string>(
        v => JsonSerializer.Serialize(v, (JsonSerializerOptions?)null),  // Convert List<string> -> string
        v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions?)null) ?? new List<string>() // Convert string -> List<string>
             );
            builder.Entity<Subscription>()
                .Property(s => s.Features)
                .HasConversion(stringListConverter)
                .Metadata.SetValueComparer(new ValueComparer<List<string>>(
                    (c1, c2) => c1.SequenceEqual(c2),
                    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                    c => c.ToList()
                ));
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
            builder.ApplyConfiguration(new FoodAllergyConfiguration());
            builder.ApplyConfiguration(new ExpertiseConfiguration());
            builder.ApplyConfiguration(new CategoryFoodConfiguration());
        }
    }
}
