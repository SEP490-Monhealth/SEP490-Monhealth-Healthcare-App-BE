using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class FoodConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData(
                new Food
                {
                    FoodId = Guid.Parse("eac10b91-8509-4986-b689-7ee3a3757a18"),
                    CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                    FoodName = "Dưa hấu",
                    FoodDescription = "Trái cây nhiều nước, vị ngọt mát, thích hợp trong ngày nóng",
                    CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                    UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                },
                  new Food
                  {
                      FoodId = Guid.Parse("dca16637-cf90-402f-921f-5c60e99e4bfa"),
                      CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                      FoodName = "Chả lụa",
                      FoodDescription = "Giò heo hấp chín, mềm, thơm, thường dùng trong bánh mì, bánh cuốn",
                      CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                      UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                  },
                  new Food
                  {
                      FoodId = Guid.Parse("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"),
                      CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                      FoodName = "Cơm gạo lức",
                      FoodDescription = "Cơm từ gạo lức, giàu chất xơ, tốt cho sức khỏe tim mạch",
                      CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                      UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                  },
                  new Food
                  {
                      FoodId = Guid.Parse("85822a08-7189-4e08-8f55-25c73698af92"),
                      CategoryId = Guid.Parse("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"),
                      FoodName = "Xúc xích",
                      FoodDescription = "Món ăn nhanh từ thịt xay nhuyễn, thích hợp cho bữa ăn nhẹ",
                      CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                      UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                  },
              
                  new Food
                  {
                      FoodId = Guid.Parse("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"),
                      CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                      FoodName = "Ức gà",
                      FoodDescription = "Phần thịt gà trắng, giàu đạm, ít béo, tốt cho người tập gym",
                      CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                      UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                  },
                  new Food
                  {
                      FoodId = Guid.Parse("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"),
                      CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                      FoodName = "Bắp luộc",
                      FoodDescription = "Món bắp nấu chín, ngọt tự nhiên, thích hợp ăn sáng hoặc ăn vặt",
                      CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                      UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                  },
                  new Food
                  {
                      FoodId = Guid.Parse("a17722bf-899e-40e9-8e54-ae2fc8a34f44"),
                      CategoryId = Guid.Parse("78651ea5-2013-4e50-a55f-714de91a712d"),
                      FoodName = "Sữa chua",
                      FoodDescription = "Món ăn lên men từ sữa, giúp hỗ trợ tiêu hóa và làm đẹp da",
                      CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                      UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                  },
                  new Food
                  {
                      FoodId = Guid.Parse("19bbab17-91c6-410f-b566-b509d067e76e"),
                      CategoryId = Guid.Parse("fe3a3546-b294-4665-9c82-092d4ab5a187"),
                      FoodName = "Đậu hũ",
                      FoodDescription = "Sản phẩm từ đậu nành, giàu protein thực vật, dùng trong nhiều món chay",
                      CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                      UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                  },
                  new Food
                  {
                      FoodId = Guid.Parse("21a4b410-e26d-444b-8b99-bf8b490e5dcf"),
                      CategoryId = Guid.Parse("22ee062d-4904-4c64-a783-74b3e142aac7"),
                      FoodName = "Bánh bao chay",
                      FoodDescription = "Bánh bao không nhân thịt, nhân rau củ hoặc đậu xanh",
                      CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                      UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                  },
                  new Food
                  {
                      FoodId = Guid.Parse("de097440-db5c-4d91-bd55-76618d70599d"),
                      CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                      FoodName = "Nước cam",
                      FoodDescription = "Thức uống tươi mát từ cam, cung cấp vitamin C tăng sức đề kháng",
                      CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                      UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                  },
                  new Food
                  {
                      FoodId = Guid.Parse("74181cd5-4b0b-48a9-9042-16d8789483d4"),
                      CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                      FoodName = "Cà rốt",
                      FoodDescription = "Rau củ màu cam, giàu vitamin A, tốt cho mắt và sức khỏe da",
                      CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                      UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                  },
                  new Food
                  {
                      FoodId = Guid.Parse("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"),
                      CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                      FoodName = "Cháo lòng",
                      FoodDescription = "Cháo gạo nấu với lòng heo, thơm béo, ăn kèm rau thơm",
                      CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                      UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                  },
                  new Food
                  {
                      FoodId = Guid.Parse("65c7b876-87e2-4307-ab76-c72ca277b78c"),
                      CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                      FoodName = "Bánh mì sandwich",
                      FoodDescription = "Bánh mì lát, dễ ăn, thích hợp cho bữa sáng nhanh",
                      CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                      UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                  },
                  new Food
                  {
                      FoodId = Guid.Parse("a47b1646-3576-46f0-a3b6-763a9c3f889b"),
                      CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                      FoodName = "Nước dừa",
                      FoodDescription = "Thức uống giải khát tự nhiên, giàu khoáng chất",
                      CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                      UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                  },
                  new Food
                  {
                      FoodId = Guid.Parse("a3074169-6441-49cc-9ea7-79e240f6dda3"),
                      CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                      FoodName = "Xoài",
                      FoodDescription = "Trái cây nhiệt đới, thịt vàng, ngọt hoặc chua tùy giống",
                      CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                      UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                  },
                  new Food
                  {
                      FoodId = Guid.Parse("0a47589f-d177-46f9-8a10-63fd6da9b611"),
                      CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                      FoodName = "Rau muống",
                      FoodDescription = "Rau xanh thường luộc, xào hoặc làm gỏi, giàu chất xơ",
                      CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                      UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                  },
                  new Food
                  {
                      FoodId = Guid.Parse("48113ca0-a1e7-4181-85fa-be6538a70873"),
                      CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                      FoodName = "Bún chả",
                      FoodDescription = "Món bún ăn kèm thịt nướng, rau sống, và nước chấm chua ngọt",
                      CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                      UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                  },
                  new Food
                  {
                      FoodId = Guid.Parse("f77e03de-4ed3-41ca-8fa1-0a4947c67384"),
                      CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                      FoodName = "Sữa hộp milo",
                      FoodDescription = "Thức uống ca cao bổ dưỡng, thích hợp cho trẻ em",
                      CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                      UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                  },
                  new Food
                  {
                      FoodId = Guid.Parse("d4df84f2-2d79-41e6-b313-28e89e3785ba"),
                      CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                      FoodName = "Bánh canh",
                      FoodDescription = "Món ăn với sợi bánh dày, ăn cùng nước lèo đậm đà",
                      CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                      UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                  }

            );
        }
    }
}