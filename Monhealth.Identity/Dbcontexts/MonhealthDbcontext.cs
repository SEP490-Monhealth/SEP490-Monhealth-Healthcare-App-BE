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

        public DbSet<Vital> Vitals { get; set; }
        public DbSet<Target> Targets { get; set; }
        public DbSet<Metric> Metrics { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Consultant> Consultants { get; set; }
        public DbSet<DailyMeal> DailyMeals { get; set; }
        public DbSet<DailyStat> DailyStats { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodPortion> FoodPortions { get; set; }
        public DbSet<InterestFood> InterestFoods { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealFood> MealFoods { get; set; }
        public DbSet<MealUserFood> MealUserFoods { get; set; }
        public DbSet<Nutrition> Nutritions { get; set; }
        public DbSet<UserFood> UserFoods { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // builder.ApplyConfigurationsFromAssembly(typeof(MonhealthDbcontext).Assembly);
            builder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles")
         .HasKey(x => new { x.RoleId, x.UserId });


            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new FoodConfiguration());
        }

    }
}
