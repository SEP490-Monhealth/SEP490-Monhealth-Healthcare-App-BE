using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Monhealth.Core;
using Monhealth.Core.Enum;
using Monhealth.Domain;
using Monhealth.Domain.CommonKey;
using Monhealth.Identity.Configurations;
using Monhealth.Identity.Models;
using System.Text.Json;
using DishType = Monhealth.Domain.DishType;

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
        public DbSet<Nutrition> Nutrition { get; set; }
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
        public DbSet<Expertise> Expertise { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ScheduleTimeSlot> ScheduleTimeSlots { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }
        public DbSet<ScheduleException> ScheduleExceptions { get; set; }
        public DbSet<CategoryFood> CategoryFoods { get; set; }
        public DbSet<UserCategory> UserCategories { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        //public DbSet<ConsultantExpertise> ConsultantExpertises { get; set; }
        public DbSet<DishType> DishTypes { get; set; }
        public DbSet<DishTypeFood> DishTypeFoods { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }

        public DbSet<Bank> Banks { get; set; }
        public DbSet<ConsultantBank> ConsultantBanks { get; set; }

        public DbSet<WithdrawalRequest> WithdrawalRequests { get; set; }

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
                .OnDelete(DeleteBehavior.Cascade);

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

            builder.Entity<Message>()
              .HasOne<Chat>(m => m.Chat)
                 .WithMany()
                 .HasForeignKey(m => m.ChatId);

            builder.Entity<Message>()
                .HasOne<ISender>(m => m.Sender)
                .WithMany()
                .HasForeignKey(m => m.SenderId)
                .OnDelete(DeleteBehavior.Restrict); // prevent cascade

            builder.Entity<Message>()
                .HasOne<ISender>(m => m.Receiver)
                .WithMany()
                .HasForeignKey(m => m.ReceiverId)
                .OnDelete(DeleteBehavior.Restrict); // prevent cascade
            var mealTypeComparer = new ValueComparer<List<MealType>>(
                   (c1, c2) => c1.SequenceEqual(c2),
                   c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                   c => c.ToList()
               );


            builder.Entity<Food>(entity =>
            {
                entity.Property(e => e.MealType)
                                 .HasConversion(
                                     v => string.Join(',', v.Select(x => x.ToString())),
                                     v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                                           .Select(x => Enum.Parse<MealType>(x))
                                           .ToList()
                                 )
                                .Metadata.SetValueComparer(mealTypeComparer);
            });
            //builder.Entity<Payment>()
            //.HasOne(p => p.UserSubscription)
            // .WithMany()
            // .HasForeignKey(p => p.UserSubscriptionId)
            //.OnDelete(DeleteBehavior.Restrict); // Hoặc .NoAction

            builder.Entity<Food>(entity =>
            {

                entity.Property(e => e.MealType)
                    .HasConversion(
                        v => string.Join(',', v.Select(x => x.ToString())), // Convert List<MealType> to string
                        v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => Enum.Parse<MealType>(x)) // Convert string back to List<MealType>
                            .ToList()
                    )
                    .Metadata.SetValueComparer(mealTypeComparer); // Set ValueComparer


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
            builder.ApplyConfiguration(new CategoryFoodConfiguration());

            builder.ApplyConfiguration(new DishTypeConfiguration());
            builder.ApplyConfiguration(new DishTypeFoodConfiguration());
            builder.ApplyConfiguration(new CertificateConfiguration());


            builder.ApplyConfiguration(new ConsultantConfiguration());
            builder.ApplyConfiguration(new ExpertiseConfiguration());

            builder.ApplyConfiguration(new ScheduleConfiguration());
            builder.ApplyConfiguration(new TimeSlotConfiguration());
            builder.ApplyConfiguration(new ScheduleTimeSlotConfiguration());

            builder.ApplyConfiguration(new WalletConfiguration());

            builder.ApplyConfiguration(new BankConfiguration());
            builder.ApplyConfiguration(new ConsultantBankConfiguration());
        }
    }
}
