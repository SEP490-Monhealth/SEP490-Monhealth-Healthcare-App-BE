using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Monhealth.Identity.Configurations
{
    public class DishTypeConfiguration : IEntityTypeConfiguration<Domain.DishType>
    {

        public void Configure(EntityTypeBuilder<Domain.DishType> builder)
        {
            builder.HasData(
            new Domain.DishType()
            {
                DishTypeId = Guid.Parse("640474cb-2135-4648-b921-fca3a9219533"),
                DishTypeName = "MainDish",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            },
            new Domain.DishType()
            {
                DishTypeId = Guid.Parse("a8a61860-12ee-4216-b185-1b8b6703c24d"),
                DishTypeName = "SideDish",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            },
            new Domain.DishType()
            {
                DishTypeId = Guid.Parse("c5791b20-5d7f-439c-9db6-418a7b18b457"),
                DishTypeName = "Soup",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            },
            new Domain.DishType()
            {
                DishTypeId = Guid.Parse("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36"),
                DishTypeName = "Dessert",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            },
            new Domain.DishType()
            {
                DishTypeId = Guid.Parse("5bc13328-01b0-4f09-a32b-5c2f3384c98c"),
                DishTypeName = "Snack",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            },
            new Domain.DishType()
            {
                DishTypeId = Guid.Parse("c76a8736-de8a-417a-864a-68e64ee2b2eb"),
                DishTypeName = "Drink",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            });
        }
    }
}