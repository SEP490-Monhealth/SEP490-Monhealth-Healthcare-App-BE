using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Monhealth.Domain;
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(MonhealthDbcontext).Assembly);
            CheckEntitiesForPrimaryKeys(builder);
        }
        private void CheckEntitiesForPrimaryKeys(ModelBuilder builder)
        {
            // Loop through all entity types and check if they have a primary key
            var entitiesWithoutKeys = builder.Model.GetEntityTypes()
                .Where(entityType => !entityType.FindPrimaryKey()?.Properties.Any() ?? true)
                .ToList();

            // If there are entities without primary keys, log or throw an exception
            if (entitiesWithoutKeys.Any())
            {
                foreach (var entityType in entitiesWithoutKeys)
                {
                    Console.WriteLine($"Entity '{entityType.Name}' does not have a primary key.");
                    // You can throw an exception or log this as necessary
                    // throw new InvalidOperationException($"Entity '{entityType.Name}' does not have a primary key.");
                }
            }
        }
    }
}
