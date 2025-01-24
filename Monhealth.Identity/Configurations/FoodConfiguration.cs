using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Core.Enum;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class FoodConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData(

            #region Food 1
            new Food
            {
                FoodId = Guid.Parse("599cfc95-4108-4dcc-9c5a-077173251f8b"),
                CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Cơm",
                FoodDescription = "Gạo nấu chín, món ăn cơ bản trong bữa cơm hàng ngày của người Việt Nam",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 2
            new Food
            {
                FoodId = Guid.Parse("08b5c5da-4b0c-48f3-98fc-33420bdf8163"),
                CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Lunch],
                DishType = [DishType.MainDish, DishType.Snack],
                FoodName = "Bánh mì",
                FoodDescription = "Bánh vỏ giòn, ruột mềm, dùng kèm nhiều loại nhân như thịt, trứng, rau",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 3
            new Food
            {
                FoodId = Guid.Parse("a989c8db-7506-467f-8aba-dce042f68eea"),
                CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Snack],
                DishType = [DishType.Dessert, DishType.Snack],
                FoodName = "Chuối",
                FoodDescription = "Trái cây ngọt, giàu năng lượng và chất dinh dưỡng, dễ dàng mang theo",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 4
            new Food
            {
                FoodId = Guid.Parse("c42e7f00-ea31-430a-ac28-8d6e749b7eca"),
                CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish, DishType.Snack],
                FoodName = "Trứng gà luộc",
                FoodDescription = "Món ăn giàu protein, dễ chế biến, thường dùng trong bữa sáng hoặc ăn vặt",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 5
            new Food
            {
                FoodId = Guid.Parse("021b651c-bb01-4965-95bc-3532fbacad3d"),
                CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Snack],
                DishType = [DishType.Drink],
                FoodName = "Sữa tươi không đường",
                FoodDescription = "Thức uống giàu dinh dưỡng, bổ sung canxi, tốt cho sức khỏe xương và răng",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),

            },
            #endregion

            #region Food 6
            new Food
            {
                FoodId = Guid.Parse("8fa26c41-16b2-49f8-a284-856024a5f947"),
                CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Bún bò huế",
                FoodDescription = "Món bún nước đậm đà từ Huế, nổi bật với hương sả, ớt, thịt bò",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 7
            new Food
            {
                FoodId = Guid.Parse("1387c20d-27a6-495b-a3a0-efbb715f6430"),
                CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Snack],
                DishType = [DishType.Dessert, DishType.Snack],
                FoodName = "Táo",
                FoodDescription = "Trái cây giòn, ngọt, nhiều chất xơ và vitamin, tốt cho hệ tiêu hóa",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 8
            new Food
            {
                FoodId = Guid.Parse("ab2117f7-9940-44cb-b191-2dfabefac8c8"),
                CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Bún",
                FoodDescription = "Sợi bún mềm, thường dùng trong các món nước hoặc xào",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 9
            new Food
            {
                FoodId = Guid.Parse("455bb5ed-ed2c-4172-8831-2b8a08614198"),
                CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner, MealType.Snack],
                DishType = [DishType.SideDish, DishType.Snack],
                FoodName = "Dưa chuột",
                FoodDescription = "Rau quả mát, nhiều nước, thường ăn sống hoặc làm gỏi",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 10
            new Food
            {
                FoodId = Guid.Parse("1140212e-cdb4-4f25-92f6-9b9407a71163"),
                CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Dessert, DishType.Snack],
                FoodName = "Chuối tây",
                FoodDescription = "Chuối nhỏ, vị ngọt nhẹ, thường dùng làm món ăn nhẹ hoặc nấu chè",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 11
            new Food
            {
                FoodId = Guid.Parse("ff1bc1f2-3515-4dfe-b271-8cabf205bbcf"),
                CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Dessert, DishType.Snack],
                FoodName = "Chuối tiêu",
                FoodDescription = "Loại chuối phổ biến, vỏ vàng, thơm, ngọt, dùng làm món tráng miệng",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 12
            new Food
            {
                FoodId = Guid.Parse("fa0d83ce-d0d7-414f-bd85-e4bc6402c0db"),
                CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Dessert, DishType.Snack],
                FoodName = "Ổi",
                FoodDescription = "Trái cây nhiều vitamin C, giòn, ngọt hoặc chua nhẹ, ăn cả vỏ",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 13
            new Food
            {
                FoodId = Guid.Parse("77fe5e06-7fee-486d-a1a7-c031f2065490"),
                CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Cơm tấm sườn",
                FoodDescription = "Món cơm từ gạo tấm, ăn kèm sườn nướng, đồ chua, và nước mắm",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 14
            new Food
            {
                FoodId = Guid.Parse("86d88717-df08-4de6-b86d-870210864b46"),
                CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Dessert, DishType.Snack],
                FoodName = "Thanh long",
                FoodDescription = "Trái cây mọng nước, thịt trắng hoặc đỏ, vị ngọt thanh mát",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 15
            new Food
            {
                FoodId = Guid.Parse("a41a3bc6-0f34-409f-9045-0807fbb4469b"),
                CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Bún riêu cua",
                FoodDescription = "Món bún với nước lèo cua đồng, ăn kèm rau sống và mắm tôm",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 16
            new Food
            {
                FoodId = Guid.Parse("7378ca5f-f1a8-4c23-a019-50af3012526f"),
                CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Bánh bao",
                FoodDescription = "Bánh hấp có nhân thịt, trứng, hoặc rau củ, mềm và thơm",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 17
            new Food
            {
                FoodId = Guid.Parse("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"),
                CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Bún thịt nướng",
                FoodDescription = "Bún tươi kết hợp thịt nướng, rau sống, và nước mắm chua ngọt",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 18
            new Food
            {
                FoodId = Guid.Parse("42883b21-4cbd-40ce-850f-b0723f1766fe"),
                CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Cà chua",
                FoodDescription = "Loại quả đỏ mọng, thường dùng làm nước sốt, canh, hoặc ăn sống",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 19
            new Food
            {
                FoodId = Guid.Parse("f6cf96c8-adc3-43e0-af5a-8b19623fed94"),
                CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Xôi mặn",
                FoodDescription = "Món xôi từ gạo nếp, ăn kèm thịt, trứng, chả, và hành phi",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 20
            new Food
            {
                FoodId = Guid.Parse("f44fd111-2744-406a-a706-abc9c0494502"),
                CategoryId = Guid.Parse("78651ea5-2013-4e50-a55f-714de91a712d"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Snack],
                DishType = [DishType.Drink],
                FoodName = "Mật ong",
                FoodDescription = "Chất ngọt tự nhiên từ ong, có lợi cho sức khỏe và làm đẹp",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 21
            new Food
            {
                FoodId = Guid.Parse("eac10b91-8509-4986-b689-7ee3a3757a18"),
                CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Dessert, DishType.Snack],
                FoodName = "Dưa hấu",
                FoodDescription = "Trái cây nhiều nước, vị ngọt mát, thích hợp trong ngày nóng",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 22
            new Food
            {
                FoodId = Guid.Parse("dca16637-cf90-402f-921f-5c60e99e4bfa"),
                CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Snack],
                DishType = [DishType.SideDish, DishType.Snack],
                FoodName = "Chả lụa",
                FoodDescription = "Giò heo hấp chín, mềm, thơm, thường dùng trong bánh mì, bánh cuốn",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 23
            new Food
            {
                FoodId = Guid.Parse("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"),
                CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Snack],
                DishType = [DishType.MainDish],
                FoodName = "Cơm gạo lức",
                FoodDescription = "Cơm từ gạo lức, giàu chất xơ, tốt cho sức khỏe tim mạch",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 24
            new Food
            {
                FoodId = Guid.Parse("85822a08-7189-4e08-8f55-25c73698af92"),
                CategoryId = Guid.Parse("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish, DishType.Snack],
                FoodName = "Xúc xích",
                FoodDescription = "Món ăn nhanh từ thịt xay nhuyễn, thích hợp cho bữa ăn nhẹ",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 25
            new Food
            {
                FoodId = Guid.Parse("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"),
                CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Ức gà",
                FoodDescription = "Phần thịt gà trắng, giàu đạm, ít béo, tốt cho người tập gym",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 26
            new Food
            {
                FoodId = Guid.Parse("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"),
                CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Snack],
                FoodName = "Bắp luộc",
                FoodDescription = "Món bắp nấu chín, ngọt tự nhiên, thích hợp ăn sáng hoặc ăn vặt",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 27
            new Food
            {
                FoodId = Guid.Parse("a17722bf-899e-40e9-8e54-ae2fc8a34f44"),
                CategoryId = Guid.Parse("78651ea5-2013-4e50-a55f-714de91a712d"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Snack],
                DishType = [DishType.Dessert, DishType.Snack],
                FoodName = "Sữa chua",
                FoodDescription = "Món ăn lên men từ sữa, giúp hỗ trợ tiêu hóa và làm đẹp da",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 28
            new Food
            {
                FoodId = Guid.Parse("19bbab17-91c6-410f-b566-b509d067e76e"),
                CategoryId = Guid.Parse("fe3a3546-b294-4665-9c82-092d4ab5a187"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish, DishType.SideDish],
                FoodName = "Đậu hũ",
                FoodDescription = "Sản phẩm từ đậu nành, giàu protein thực vật, dùng trong nhiều món chay",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 29
            new Food
            {
                FoodId = Guid.Parse("21a4b410-e26d-444b-8b99-bf8b490e5dcf"),
                CategoryId = Guid.Parse("22ee062d-4904-4c64-a783-74b3e142aac7"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Snack],
                DishType = [DishType.MainDish],
                FoodName = "Bánh bao chay",
                FoodDescription = "Bánh bao không nhân thịt, nhân rau củ hoặc đậu xanh",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 30
            new Food
            {
                FoodId = Guid.Parse("de097440-db5c-4d91-bd55-76618d70599d"),
                CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Snack],
                DishType = [DishType.Drink],
                FoodName = "Nước cam",
                FoodDescription = "Thức uống tươi mát từ cam, cung cấp vitamin C tăng sức đề kháng",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 31
            new Food
            {
                FoodId = Guid.Parse("74181cd5-4b0b-48a9-9042-16d8789483d4"),
                CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Cà rốt",
                FoodDescription = "Rau củ màu cam, giàu vitamin A, tốt cho mắt và sức khỏe da",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 32
            new Food
            {
                FoodId = Guid.Parse("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"),
                CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Snack],
                DishType = [DishType.MainDish],
                FoodName = "Cháo lòng",
                FoodDescription = "Cháo gạo nấu với lòng heo, thơm béo, ăn kèm rau thơm",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 33
            new Food
            {
                FoodId = Guid.Parse("65c7b876-87e2-4307-ab76-c72ca277b78c"),
                CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Snack],
                DishType = [DishType.MainDish],
                FoodName = "Bánh mì sandwich",
                FoodDescription = "Bánh mì lát, dễ ăn, thích hợp cho bữa sáng nhanh",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 34
            new Food
            {
                FoodId = Guid.Parse("a47b1646-3576-46f0-a3b6-763a9c3f889b"),
                CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Snack],
                DishType = [DishType.Drink],
                FoodName = "Nước dừa",
                FoodDescription = "Thức uống giải khát tự nhiên, giàu khoáng chất",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 35
            new Food
            {
                FoodId = Guid.Parse("a3074169-6441-49cc-9ea7-79e240f6dda3"),
                CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Snack],
                FoodName = "Xoài",
                FoodDescription = "Trái cây nhiệt đới, thịt vàng, ngọt hoặc chua tùy giống",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 36
            new Food
            {
                FoodId = Guid.Parse("0a47589f-d177-46f9-8a10-63fd6da9b611"),
                CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Rau muống",
                FoodDescription = "Rau xanh thường luộc, xào hoặc làm gỏi, giàu chất xơ",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 37
            new Food
            {
                FoodId = Guid.Parse("48113ca0-a1e7-4181-85fa-be6538a70873"),
                CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Bún chả",
                FoodDescription = "Món bún ăn kèm thịt nướng, rau sống, và nước chấm chua ngọt",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 38
            new Food
            {
                FoodId = Guid.Parse("f77e03de-4ed3-41ca-8fa1-0a4947c67384"),
                CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Drink],
                FoodName = "Sữa hộp milo",
                FoodDescription = "Thức uống ca cao bổ dưỡng, thích hợp cho trẻ em",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 39
            new Food
            {
                FoodId = Guid.Parse("d4df84f2-2d79-41e6-b313-28e89e3785ba"),
                CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Bánh canh",
                FoodDescription = "Món ăn với sợi bánh dày, ăn cùng nước lèo đậm đà",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 40
            new Food
            {
                FoodId = Guid.Parse("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"),
                CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Hủ tíu",
                FoodDescription = "Món ăn miền Nam với sợi hủ tíu mềm, nước lèo thanh ngọt",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 41
            new Food
            {
                FoodId = Guid.Parse("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"),
                CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Snack],
                DishType = [DishType.Drink],
                FoodName = "Cà phê",
                FoodDescription = "Thức uống đậm đà, kích thích tinh thần, uống nóng hoặc đá",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 42
            new Food
            {
                FoodId = Guid.Parse("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"),
                CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Drink],
                FoodName = "Cà phê sữa",
                FoodDescription = "Cà phê kết hợp sữa đặc, vị ngọt béo hấp dẫn",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 43
            new Food
            {
                FoodId = Guid.Parse("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"),
                CategoryId = Guid.Parse("22ee062d-4904-4c64-a783-74b3e142aac7"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Snack],
                DishType = [DishType.Drink],
                FoodName = "Sữa đậu nành",
                FoodDescription = "Thức uống từ đậu nành, ít ngọt, tốt cho sức khỏe",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 44
            new Food
            {
                FoodId = Guid.Parse("83e6e455-3ae1-4f5c-8e44-9a5ae79ee31b"),
                CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Thịt kho tiêu",
                FoodDescription = "Món thịt heo nấu tiêu, nước mắm, thơm nồng, đậm đà",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 45
            new Food
            {
                FoodId = Guid.Parse("77243d82-a633-4fe8-84c9-61a4b6cd4428"),
                CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Bún xào",
                FoodDescription = "Món bún xào cùng rau củ và thịt, thơm ngon, dễ ăn",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 46
            new Food
            {
                FoodId = Guid.Parse("3222413a-e385-4a0b-9d07-2af7b0cb4276"),
                CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Cải thìa",
                FoodDescription = "Loại rau xanh thường dùng trong món xào hoặc luộc",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 47
            new Food
            {
                FoodId = Guid.Parse("e0eec003-8384-412c-a307-b0185afdb0c7"),
                CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Snack],
                DishType = [DishType.MainDish],
                FoodName = "Xôi bắp",
                FoodDescription = "Xôi gạo nếp kết hợp bắp vàng ngọt, ăn kèm hành phi thơm",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 48
            new Food
            {
                FoodId = Guid.Parse("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"),
                CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Phở bò tái",
                FoodDescription = "Món phở với nước dùng đậm đà, thịt bò tái mềm ngon",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 49
            new Food
            {
                FoodId = Guid.Parse("da89578e-9470-4b18-af4f-0bdcc011882f"),
                CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Phở gà",
                FoodDescription = "Phở nước lèo thanh ngọt, ăn kèm thịt gà và rau thơm",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 50
            new Food
            {
                FoodId = Guid.Parse("27dd8629-4564-478a-b049-6c4b81ee3cf1"),
                CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Snack],
                FoodName = "Trứng vịt lộn",
                FoodDescription = "Trứng vịt luộc, chứa phôi phát triển, ăn kèm rau răm và muối tiêu",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 51
            new Food
            {
                FoodId = Guid.Parse("37a66f5c-437f-4520-90ec-4376e0093061"),
                CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Drink],
                FoodName = "Nước chanh",
                FoodDescription = "Thức uống giải khát, làm từ chanh tươi, cung cấp nhiều vitamin C",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 52
            new Food
            {
                FoodId = Guid.Parse("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"),
                CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast],
                DishType = [DishType.MainDish],
                FoodName = "Bánh mì thịt trứng",
                FoodDescription = "Bánh mì giòn kẹp thịt, trứng và rau, ăn sáng nhanh tiện lợi",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 53
            new Food
            {
                FoodId = Guid.Parse("d9fa8f03-5825-4e83-88d3-1a7c49e39a7d"),
                CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Snack],
                DishType = [DishType.MainDish],
                FoodName = "Bánh chưng",
                FoodDescription = "Món bánh truyền thống từ gạo nếp, thịt mỡ, đậu xanh",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 54
            new Food
            {
                FoodId = Guid.Parse("16bf44f2-711d-4b64-a409-995c6b0c13ce"),
                CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Dessert, DishType.Snack],
                FoodName = "Quả quýt",
                FoodDescription = "Trái cây nhỏ, vị ngọt thanh, dễ bóc vỏ, giàu vitamin C",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 55
            new Food
            {
                FoodId = Guid.Parse("fa445aa4-7b0d-4d47-8ba7-f919dd123637"),
                CategoryId = Guid.Parse("78651ea5-2013-4e50-a55f-714de91a712d"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Dessert, DishType.Snack],
                FoodName = "Sữa chua nha đam",
                FoodDescription = "Sữa chua mịn kết hợp nha đam giòn, tốt cho tiêu hóa",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 56
            new Food
            {
                FoodId = Guid.Parse("f412d88d-ce7e-4006-bc11-75af61438491"),
                CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Snack],
                FoodName = "Bánh tiêu",
                FoodDescription = "Loại bánh chiên phồng, thơm mùi mè, ngọt nhẹ",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 57
            new Food
            {
                FoodId = Guid.Parse("05cfce09-72b4-482d-adcd-c0718015be3d"),
                CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Bánh xèo",
                FoodDescription = "Món bánh bột vàng giòn, nhân thịt, tôm, ăn kèm rau sống",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 58
            new Food
            {
                FoodId = Guid.Parse("58fe08ca-5c52-4847-800e-b9970c3782f0"),
                CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Ớt chuông",
                FoodDescription = "Rau quả màu sắc, giòn ngọt, giàu vitamin, thường dùng làm salad",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 59
            new Food
            {
                FoodId = Guid.Parse("1d0feb2f-0735-4333-87ce-09e22304ad0d"),
                CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Nấm kim châm",
                FoodDescription = "Loại nấm nhỏ dài, thơm ngon, thường dùng trong lẩu hoặc xào",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 60
            new Food
            {
                FoodId = Guid.Parse("a782e478-d5c5-4da6-b809-180b48ad08c3"),
                CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Lòng đỏ trứng gà",
                FoodDescription = "Phần trứng vàng, giàu dinh dưỡng và chất béo",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 61
            new Food
            {
                FoodId = Guid.Parse("f41484a3-c7df-4530-b7d2-060390103985"),
                CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Lòng trắng trứng gà",
                FoodDescription = "Phần trứng trắng, ít béo, giàu protein, thích hợp cho người ăn kiêng",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 62
            new Food
            {
                FoodId = Guid.Parse("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"),
                CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Hoành thánh",
                FoodDescription = "Món bột mỏng nhân thịt, hấp hoặc chiên, thường ăn kèm nước lèo",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 63
            new Food
            {
                FoodId = Guid.Parse("e7468877-17ed-4bb9-9956-5e3cf6a58bde"),
                CategoryId = Guid.Parse("ee39be57-cf88-4420-8e19-606b2ed4dc6d"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Tôm",
                FoodDescription = "Hải sản giàu đạm, chế biến đa dạng: hấp, chiên, xào, hoặc nướng",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 64
            new Food
            {
                FoodId = Guid.Parse("40f03f23-9341-4343-9bf8-fdfdb3b9f236"),
                CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Đậu bắp",
                FoodDescription = "Rau quả giòn, nhiều nhớt, thường dùng nấu canh hoặc luộc",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 65
            new Food
            {
                FoodId = Guid.Parse("dfa879e8-d77d-4199-b07b-16b37f1cbde1"),
                CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Bánh canh cua",
                FoodDescription = "Món bánh canh với thịt cua, nước lèo đậm đà",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 66
            new Food
            {
                FoodId = Guid.Parse("a84ec8cd-f9d8-4723-8b9e-4ff4eee1685e"),
                CategoryId = Guid.Parse("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Snack],
                FoodName = "Cá viên chiên",
                FoodDescription = "Món ăn vặt từ cá xay, chiên giòn, chấm kèm tương ớt",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 67
            new Food
            {
                FoodId = Guid.Parse("46b9f487-dc6d-4c1d-9729-9f707ac28202"),
                CategoryId = Guid.Parse("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast],
                DishType = [DishType.MainDish],
                FoodName = "Hamburger",
                FoodDescription = "Bánh mì tròn kẹp thịt, phô mai, rau, và nước sốt",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 68
            new Food
            {
                FoodId = Guid.Parse("c16aac77-64ee-476d-a646-a3029da83e41"),
                CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast],
                DishType = [DishType.MainDish],
                FoodName = "Bánh bèo",
                FoodDescription = "Món bánh bột gạo nhỏ, ăn kèm tôm cháy và nước mắm",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 69
            new Food
            {
                FoodId = Guid.Parse("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"),
                CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Bún mắm",
                FoodDescription = "Món bún với nước lèo mắm cá, đậm đà, ăn kèm hải sản và rau",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 70
            new Food
            {
                FoodId = Guid.Parse("244e7e03-baaa-4dc4-aa10-d9d0dac410fe"),
                CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Cải thảo",
                FoodDescription = "Rau xanh giòn, thường dùng làm kim chi hoặc xào",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 71
            new Food
            {
                FoodId = Guid.Parse("51061170-597d-4289-a021-1e7dde88331f"),
                CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Thịt vịt",
                FoodDescription = "Loại thịt mềm, ngọt, chế biến thành món quay, hấp, hoặc nấu cháo",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 72
            new Food
            {
                FoodId = Guid.Parse("c137f014-34c2-4f0a-be52-7c2a5c64abae"),
                CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Thịt gà",
                FoodDescription = "Thịt gia cầm phổ biến, dùng trong nhiều món nướng, luộc, hầm",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 73
            new Food
            {
                FoodId = Guid.Parse("5ff26461-880d-4b94-bfd0-e8badc77fe33"),
                CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Thịt kho trứng",
                FoodDescription = "Món thịt nấu cùng trứng và nước mắm, vị ngọt mặn hấp dẫn",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 74
            new Food
            {
                FoodId = Guid.Parse("73016f70-ebb4-4583-aa12-7f3f4633ada4"),
                CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Sườn non",
                FoodDescription = "Phần sườn heo mềm, ngon, thích hợp nấu canh hoặc kho",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 75
            new Food
            {
                FoodId = Guid.Parse("0455b535-2662-43aa-bca2-3e75595fb181"),
                CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Thịt heo bằm",
                FoodDescription = "Thịt heo xay nhuyễn, dùng nấu canh, xào, hoặc làm nhân",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 76
            new Food
            {
                FoodId = Guid.Parse("d30f804f-c59b-4a59-bf4c-5196b302d1ed"),
                CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Cơm chiên trứng",
                FoodDescription = "Cơm chiên vàng với trứng gà, thêm hành phi thơm ngon",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 77
            new Food
            {
                FoodId = Guid.Parse("3965d7c0-e550-497d-9b41-ea382c2bb83e"),
                CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Drink],
                FoodName = "Sting",
                FoodDescription = "Nước tăng lực vị dâu, ngọt và kích thích tinh thần",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 78
            new Food
            {
                FoodId = Guid.Parse("c60b8720-2ced-426c-b39b-606757200893"),
                CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Drink],
                FoodName = "Pepsi",
                FoodDescription = "Nước ngọt có ga, vị cola đặc trưng, dùng kèm bữa ăn nhanh",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 79
            new Food
            {
                FoodId = Guid.Parse("dc49c7a4-cf6a-4b85-a5e0-5f923730464a"),
                CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Drink],
                FoodName = "Coca cola",
                FoodDescription = "Thức uống giải khát có ga, vị ngọt thanh",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 80
            new Food
            {
                FoodId = Guid.Parse("6e12f6cb-6695-4c7a-bfb0-cd4936ee1782"),
                CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast],
                DishType = [DishType.MainDish],
                FoodName = "Cháo sườn",
                FoodDescription = "Cháo gạo trắng nấu nhuyễn, thêm sườn heo mềm ngọt",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 81
            new Food
            {
                FoodId = Guid.Parse("81af247b-f112-4b7c-981c-d1ba1c3a3644"),
                CategoryId = Guid.Parse("fc7f66aa-8c09-46db-a679-be440e3ed91f"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Kim chi",
                FoodDescription = "Rau cải thảo lên men, cay nồng, thường ăn kèm món nướng",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 82
            new Food
            {
                FoodId = Guid.Parse("face3a50-e5e6-41e3-83e8-f96e7c8c98d4"),
                CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Snack],
                FoodName = "Bánh đúc",
                FoodDescription = "Bánh bột gạo mềm, ăn kèm mắm tôm, thịt bằm",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 83
            new Food
            {
                FoodId = Guid.Parse("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"),
                CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.MainDish, DishType.Snack],
                FoodName = "Bánh bột lọc",
                FoodDescription = "Món bánh trong suốt, nhân tôm thịt, thường hấp hoặc luộc",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 84
            new Food
            {
                FoodId = Guid.Parse("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"),
                CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Snack],
                DishType = [DishType.MainDish],
                FoodName = "Bánh bao xá xíu",
                FoodDescription = "Bánh hấp nhân thịt xá xíu, mềm, thơm ngọt",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 85
            new Food
            {
                FoodId = Guid.Parse("faf19891-525a-4308-9222-992e83de7ce7"),
                CategoryId = Guid.Parse("ee39be57-cf88-4420-8e19-606b2ed4dc6d"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Cá hồi",
                FoodDescription = "Loại cá béo, giàu omega-3, thường ăn sống hoặc nướng",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 86
            new Food
            {
                FoodId = Guid.Parse("30355638-a0e2-4126-93ae-beb7aa9b5758"),
                CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Snack],
                DishType = [DishType.Snack],
                FoodName = "Khoai lang",
                FoodDescription = "Loại củ ngọt tự nhiên, dùng luộc, nướng hoặc chiên",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 87
            new Food
            {
                FoodId = Guid.Parse("8893c58d-06fd-4c34-9e77-2f50779642dd"),
                CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Khoai tây",
                FoodDescription = "Loại củ mềm, dùng làm khoai chiên, nghiền hoặc hầm",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 88
            new Food
            {
                FoodId = Guid.Parse("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"),
                CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Hành tây",
                FoodDescription = "Loại rau củ thơm, thường dùng làm gia vị hoặc ăn sống",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 89
            new Food
            {
                FoodId = Guid.Parse("80ba2672-d26a-4703-98f0-d246a50f92f1"),
                CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Bầu",
                FoodDescription = "Loại quả dài, xanh, dùng nấu canh hoặc xào",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 90
            new Food
            {
                FoodId = Guid.Parse("c5822776-96df-4208-82b2-02f22594063b"),
                CategoryId = Guid.Parse("78651ea5-2013-4e50-a55f-714de91a712d"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Dessert, DishType.Snack],
                FoodName = "Bánh cam",
                FoodDescription = "Bánh tròn chiên giòn, nhân đậu xanh, ngọt thanh",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 91
            new Food
            {
                FoodId = Guid.Parse("a53672e7-8593-4779-bd02-9f02ae81f915"),
                CategoryId = Guid.Parse("ee39be57-cf88-4420-8e19-606b2ed4dc6d"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Mực",
                FoodDescription = "Hải sản giòn, ngọt, chế biến nướng, hấp, hoặc chiên",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 92
            new Food
            {
                FoodId = Guid.Parse("ede931f5-092e-4e41-8ce1-5a95bff2772a"),
                CategoryId = Guid.Parse("ee39be57-cf88-4420-8e19-606b2ed4dc6d"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Cua",
                FoodDescription = "Hải sản vỏ cứng, thịt ngọt, thường hấp hoặc nấu lẩu",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 93
            new Food
            {
                FoodId = Guid.Parse("98006e54-c44e-4a81-aa99-d4bb95bfb89d"),
                CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Đậu que",
                FoodDescription = "Rau xanh giòn, thích hợp luộc, xào hoặc nấu canh",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 94
            new Food
            {
                FoodId = Guid.Parse("fb7d87aa-2bb8-4065-bd31-b54239057405"),
                CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast],
                DishType = [DishType.MainDish],
                FoodName = "Bánh ướt",
                FoodDescription = "Bánh bột gạo tráng mỏng, ăn kèm chả, nước mắm",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 95
            new Food
            {
                FoodId = Guid.Parse("f0132626-5535-4f30-9af4-7e89e086aaaf"),
                CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast],
                DishType = [DishType.MainDish],
                FoodName = "Bánh cuốn",
                FoodDescription = "Bánh tráng mỏng cuộn nhân thịt, mộc nhĩ, ăn kèm nước mắm",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 96
            new Food
            {
                FoodId = Guid.Parse("7268b449-cb54-4f3d-9709-f42b9966d707"),
                CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Lunch],
                DishType = [DishType.MainDish],
                FoodName = "Canh bún",
                FoodDescription = "Món bún nước dùng từ cua đồng, ăn kèm rau muống",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 97
            new Food
            {
                FoodId = Guid.Parse("7b8500af-d730-4138-9617-cba352faed4a"),
                CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Dessert, DishType.Snack],
                FoodName = "Vải",
                FoodDescription = "Trái cây nhỏ, ngọt, mọng nước, vỏ đỏ, hạt to",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 98
            new Food
            {
                FoodId = Guid.Parse("dd1482e7-b3dd-4b17-80f6-5618a640c671"),
                CategoryId = Guid.Parse("ee39be57-cf88-4420-8e19-606b2ed4dc6d"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Cá khô",
                FoodDescription = "Cá phơi khô, dùng nướng, chiên hoặc làm gỏi",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 99
            new Food
            {
                FoodId = Guid.Parse("628d87df-0bde-417d-b8b5-5f8f5536410b"),
                CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Nấm đùi gà",
                FoodDescription = "Loại nấm to, thơm ngon, thích hợp xào hoặc nấu canh",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 100
            new Food
            {
                FoodId = Guid.Parse("fc85f2de-9aae-4ff4-a829-e01662a42976"),
                CategoryId = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Mướp",
                FoodDescription = "Loại quả xanh, mềm, thường nấu canh hoặc xào",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 101
            new Food
            {
                FoodId = Guid.Parse("ef8b0ee3-a4d5-4883-af63-33c83d102bea"),
                CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast],
                DishType = [DishType.MainDish],
                FoodName = "Bánh bao trứng cút",
                FoodDescription = "Bánh hấp nhân thịt, trứng cút, ăn sáng tiện lợi",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 102
            new Food
            {
                FoodId = Guid.Parse("9122357a-179f-45f4-9106-67eea24d48ab"),
                CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Drink],
                FoodName = "Trà tắc",
                FoodDescription = "Nước trà kết hợp tắc, vị chua ngọt, giải khát",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 103
            new Food
            {
                FoodId = Guid.Parse("22d1cbad-a884-400c-b681-30b17d98bf1c"),
                CategoryId = Guid.Parse("fe3a3546-b294-4665-9c82-092d4ab5a187"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Đậu hũ non",
                FoodDescription = "Đậu hũ mềm mịn, thường dùng làm canh hoặc món tráng miệng",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 104
            new Food
            {
                FoodId = Guid.Parse("c81a404a-ec10-428e-acec-dd56ec1d3607"),
                CategoryId = Guid.Parse("fc7f66aa-8c09-46db-a679-be440e3ed91f"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.SideDish],
                FoodName = "Nem chua",
                FoodDescription = "Thịt chua lên men, thường ăn kèm lá ổi và tương ớt",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 105
            new Food
            {
                FoodId = Guid.Parse("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"),
                CategoryId = Guid.Parse("ee39be57-cf88-4420-8e19-606b2ed4dc6d"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Cá ngừ",
                FoodDescription = "Loại cá giàu dinh dưỡng, thường làm salad hoặc áp chảo",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 106
            new Food
            {
                FoodId = Guid.Parse("01708b02-6cc1-41f6-ae4a-95c4085e1839"),
                CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.MainDish],
                FoodName = "Gỏi cuốn",
                FoodDescription = "Cuốn bánh tráng với thịt, tôm, rau, chấm nước mắm chua ngọt",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 107
            new Food
            {
                FoodId = Guid.Parse("436d8364-15fd-47a2-9b72-c3841db0da2e"),
                CategoryId = Guid.Parse("78651ea5-2013-4e50-a55f-714de91a712d"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.MainDish],
                FoodName = "Bông lan trứng muối",
                FoodDescription = "Bánh bông lan mềm, nhân trứng muối và chà bông",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 108
            new Food
            {
                FoodId = Guid.Parse("87225215-43af-49f2-a40b-a5ebb087d27b"),
                CategoryId = Guid.Parse("5c899b0d-5d6a-4366-a4fd-797ab5b2168e"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Phở bò viên",
                FoodDescription = "Phở bò kết hợp bò viên dai ngon, nước lèo đậm đà",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 109
            new Food
            {
                FoodId = Guid.Parse("23443efa-dc06-4e7a-949c-5c823ee6e575"),
                CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Snack],
                DishType = [DishType.Snack],
                FoodName = "Khoai lang luộc",
                FoodDescription = "Khoai lang luộc chín, ngọt bùi, giàu chất xơ",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 110
            new Food
            {
                FoodId = Guid.Parse("afe0a180-0077-4fdf-89e8-9513c6132f92"),
                CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Dessert, DishType.Snack],
                FoodName = "Đu đủ",
                FoodDescription = "Trái cây ngọt mềm, màu cam, giàu vitamin A và chất xơ",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 111
            new Food
            {
                FoodId = Guid.Parse("16066b9b-e61f-4354-803b-e2f9c9f5a5db"),
                CategoryId = Guid.Parse("78651ea5-2013-4e50-a55f-714de91a712d"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast],
                DishType = [DishType.MainDish],
                FoodName = "Cháo đậu đỏ",
                FoodDescription = "Cháo từ đậu đỏ, ngọt dịu, bổ máu và mát gan",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 112
            new Food
            {
                FoodId = Guid.Parse("8ebd5a6e-b0af-42b6-af58-b681fceac1ef"),
                CategoryId = Guid.Parse("78651ea5-2013-4e50-a55f-714de91a712d"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Dessert, DishType.Snack],
                FoodName = "Chè đậu đen",
                FoodDescription = "Món chè ngọt làm từ đậu đen nấu mềm, nước cốt dừa thơm",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 113
            new Food
            {
                FoodId = Guid.Parse("da85064b-e528-4bfa-8a64-1fbe704f9af5"),
                CategoryId = Guid.Parse("fc7f66aa-8c09-46db-a679-be440e3ed91f"),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Dưa cải chua",
                FoodDescription = "Rau cải muối lên men, chua nhẹ, ăn kèm món kho",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 114
            new Food
            {
                FoodId = Guid.Parse("86bcbac3-fc75-46ed-8d0e-18c8c4860692"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Ức gà nướng",
                FoodDescription = "Giàu protein, ít béo, phù hợp chế độ giảm cân",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 115
            new Food
            {
                FoodId = Guid.Parse("a6ce6816-c6e1-4512-aeb6-d5d647815c1d"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Thịt bò nạc",
                FoodDescription = "Thịt đỏ mềm, giàu dinh dưỡng, giúp phát triển cơ bắp",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 116
            new Food
            {
                FoodId = Guid.Parse("edb9d5d0-01f3-4607-a406-9e04bbff85fb"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Cá hồi nướng",
                FoodDescription = "Omega-3 dồi dào, tốt cho tim mạch và làn da khỏe mạnh",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 117
            new Food
            {
                FoodId = Guid.Parse("4d640470-857a-4765-905f-e49e98a281a1"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Tôm hấp",
                FoodDescription = "Món hải sản ít calo, bổ sung protein và khoáng chất",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 118
            new Food
            {
                FoodId = Guid.Parse("a7c3c838-acdb-4cce-b4c4-d46058b10ad1"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Dessert, DishType.Snack],
                FoodName = "Phô mai Parmesan",
                FoodDescription = "Vị đậm đà, giàu canxi, dùng kèm salad hoặc pasta",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 119
            new Food
            {
                FoodId = Guid.Parse("d3a1c73d-ca5a-45ea-a7fa-d582f1253b79"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Thịt lợn nạc",
                FoodDescription = "Thịt trắng mềm, nguồn cung cấp sắt và protein",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 120
            new Food
            {
                FoodId = Guid.Parse("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Cá thu nướng",
                FoodDescription = "Giàu omega-3, tốt cho trí não và sức khỏe tim mạch",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 121
            new Food
            {
                FoodId = Guid.Parse("3fa8cf38-d835-4279-a113-a8f44cd013e6"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Snack],
                DishType = [DishType.SideDish, DishType.Snack],
                FoodName = "Đậu nành luộc",
                FoodDescription = "Thực phẩm chay bổ dưỡng, giàu protein thực vật",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 122
            new Food
            {
                FoodId = Guid.Parse("d3392e5d-a48f-4b5a-968d-31b98bd47835"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Snack],
                DishType = [DishType.Dessert, DishType.Snack, DishType.Drink],
                FoodName = "Sữa chua Hy Lạp",
                FoodDescription = "Giàu lợi khuẩn, hỗ trợ tiêu hóa và làm đẹp da",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 123
            new Food
            {
                FoodId = Guid.Parse("ad6a860f-4a4a-4cb7-90fa-21c8f36c91ce"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Ức vịt nướng",
                FoodDescription = "Món giàu sắt, thích hợp cho bữa tiệc thịnh soạn",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 124
            new Food
            {
                FoodId = Guid.Parse("5ebbc839-81e6-496f-9e4d-8d90d732a906"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner, MealType.Snack],
                DishType = [DishType.MainDish, DishType.SideDish],
                FoodName = "Cá ngừ đóng hộp",
                FoodDescription = "Tiện lợi, giàu dinh dưỡng, dễ chế biến nhiều món",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 125
            new Food
            {
                FoodId = Guid.Parse("2da12ed2-3082-4374-807e-795372dfd1de"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Cá bơn nướng",
                FoodDescription = "Thịt cá mềm, thơm, bổ sung dưỡng chất thiết yếu",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 126
            new Food
            {
                FoodId = Guid.Parse("50c0adac-c878-4a21-8b5f-01478e7e4852"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner, MealType.Snack],
                DishType = [DishType.SideDish, DishType.Snack],
                FoodName = "Đậu hũ chiên",
                FoodDescription = "Món chay giàu protein, dễ chế biến với nhiều gia vị",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 127
            new Food
            {
                FoodId = Guid.Parse("431b7ee6-7c63-43ac-ae7e-be93f7fb6647"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Thịt nai nướng",
                FoodDescription = "Món đặc sản, thịt ngọt, giàu sắt và năng lượng",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 128
            new Food
            {
                FoodId = Guid.Parse("016d6e20-bf8b-4b0e-9e0c-a1d6199f73d4"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Cua hấp",
                FoodDescription = "Hải sản ngọt tự nhiên, cung cấp canxi và kẽm",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 129
            new Food
            {
                FoodId = Guid.Parse("c027a073-e154-4c78-821e-3588fcb4df03"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Snack],
                DishType = [DishType.Snack, DishType.Dessert],
                FoodName = "Hạt chia ngâm",
                FoodDescription = "Siêu thực phẩm, giàu chất xơ và omega-3",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 130
            new Food
            {
                FoodId = Guid.Parse("341c53c9-7894-410c-ab04-0dca11ff6a80"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Cá tuyết hấp",
                FoodDescription = "Thịt trắng thơm ngọt, giàu dinh dưỡng, dễ tiêu hóa",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 131
            new Food
            {
                FoodId = Guid.Parse("55bd2b96-0e5f-4be4-acae-25f5e3e25244"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Bò bít tết",
                FoodDescription = "Thịt bò mềm, hấp dẫn, thích hợp cho bữa tối cao cấp",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 132
            new Food
            {
                FoodId = Guid.Parse("02aad946-ee2f-45f8-8ce5-8ebc476ba631"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                FoodName = "Ức gà tây",
                FoodDescription = "Giàu protein, ít béo, giúp xây dựng cơ bắp hiệu quả",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 133
            new Food
            {
                FoodId = Guid.Parse("a23f6c85-1a80-4255-a9a1-d08c1d60e753"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                FoodName = "Cá hồi hun khói",
                FoodDescription = "Hương vị đậm đà, tiện lợi, tốt cho sức khỏe tim",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 134
            new Food
            {
                FoodId = Guid.Parse("c7e5ccea-ca0e-4c25-be0b-509bb51b38a2"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                FoodName = "Cá basa chiên",
                FoodDescription = "Món cá vàng giòn, giàu omega-3, dễ chế biến",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 135
            new Food
            {
                FoodId = Guid.Parse("b0f051be-5972-4e7a-a77d-47ec28d58993"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                FoodName = "Hạt hạnh nhân",
                FoodDescription = "Thực phẩm nhẹ, cung cấp năng lượng và vitamin E",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 136
            new Food
            {
                FoodId = Guid.Parse("a6b8e6e4-1e44-4626-a7d0-1cefefc4f613"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                FoodName = "Cá chình nướng",
                FoodDescription = "Thịt ngọt, mềm, bổ dưỡng, tốt cho sức khỏe",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 137
            new Food
            {
                FoodId = Guid.Parse("6dfafffc-d4f7-4402-b585-37a1c8994663"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                FoodName = "Cà ri gà",
                FoodDescription = "Món cay hấp dẫn, giàu hương vị, hợp khẩu vị Việt",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 138
            new Food
            {
                FoodId = Guid.Parse("55cb9711-56aa-4efb-b31f-d034134cb1b8"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                FoodName = "Cá trích muối",
                FoodDescription = "Hải sản đậm đà, thích hợp ăn kèm bánh mì",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 139
            new Food
            {
                FoodId = Guid.Parse("304376d6-f9c5-48f0-985c-06080347b173"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                FoodName = "Cá hồi sốt chanh",
                FoodDescription = "Món thanh nhẹ, chua ngọt, giàu omega-3",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 140
            new Food
            {
                FoodId = Guid.Parse("8da16f72-42a9-4da2-b217-811903e340c4"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                FoodName = "Đậu hũ sốt cà",
                FoodDescription = "Món chay đơn giản, ngon miệng, giàu protein",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 141
            new Food
            {
                FoodId = Guid.Parse("a5d484c6-9cc8-4d6e-a53c-5c8a2c20999b"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                FoodName = "Thịt lợn xông khói",
                FoodDescription = "Vị mặn đậm, dùng làm topping hoặc ăn sáng",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 142
            new Food
            {
                FoodId = Guid.Parse("56bb5be7-3a7f-4942-89c6-3c6af934adf3"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                FoodName = "Cá chim trắng nướng",
                FoodDescription = "Cá biển thơm ngon, giàu dinh dưỡng tự nhiên",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 143
            new Food
            {
                FoodId = Guid.Parse("59988378-901f-4ec4-bd6c-9fdc28ca97a1"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                FoodName = "Hạt bí ngô",
                FoodDescription = "Giàu kẽm, ăn nhẹ tốt cho sức khỏe và làn da",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 144
            new Food
            {
                FoodId = Guid.Parse("b29dc622-e8ae-4471-8e22-5676aa5fa909"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                FoodName = "Đậu hà lan luộc",
                FoodDescription = "Rau củ giàu vitamin, hỗ trợ hệ miễn dịch",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 145
            new Food
            {
                FoodId = Guid.Parse("6007962d-9bd0-43ce-8a83-6b5f9bed4156"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                FoodName = "Cua biển sốt me",
                FoodDescription = "Món ăn đậm đà, chua ngọt, hợp khẩu vị mọi người",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 146
            new Food
            {
                FoodId = Guid.Parse("189dadbe-caf2-4d83-bb01-5ffa8776fa20"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                FoodName = "Đậu phộng rang",
                FoodDescription = "Món ăn nhẹ phổ biến, giàu năng lượng và chất béo",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 147
            new Food
            {
                FoodId = Guid.Parse("db3cd633-2350-4143-ae1f-ccc853583755"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                FoodName = "Sò điệp hấp",
                FoodDescription = "Hải sản cao cấp, thơm ngọt, giàu dinh dưỡng",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 148
            new Food
            {
                FoodId = Guid.Parse("0f7f47a1-f122-4f58-9e24-40ece9323520"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Thịt gà quay",
                FoodDescription = "Thịt gà vàng giòn, hương vị hấp dẫn, dễ ăn",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 149
            new Food
            {
                FoodId = Guid.Parse("98b3945a-9169-4581-b1a5-da82f2ebd8d4"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast],
                DishType = [DishType.MainDish],
                FoodName = "Sữa bò tươi",
                FoodDescription = "Nguồn canxi tự nhiên, tốt cho xương và cơ thể",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 150
            new Food
            {
                FoodId = Guid.Parse("d675513e-3be1-4c47-b0d2-0718f02ae93b"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Snack],
                FoodName = "Hạt mè",
                FoodDescription = "Nhỏ gọn, giàu dưỡng chất, dùng trong món ăn châu Á",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 151
            new Food
            {
                FoodId = Guid.Parse("8bcd1ea8-cf17-4457-bc32-65033e43e311"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Snack],
                FoodName = "Cá mòi hộp dầu",
                FoodDescription = "Tiện lợi, giàu omega-3, bổ sung bữa ăn nhanh",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 152
            new Food
            {
                FoodId = Guid.Parse("7f55881d-f8f4-43aa-b4b6-5d56fd56cfde"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Cá lóc hấp",
                FoodDescription = "Cá đồng ngon ngọt, giàu chất dinh dưỡng",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 153
            new Food
            {
                FoodId = Guid.Parse("98b3945a-9169-4581-b1a5-da82f2ebd8d4"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                FoodName = "Sữa bò tươi",
                FoodDescription = "Nguồn canxi tự nhiên, tốt cho xương và cơ thể",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 154
            new Food
            {
                FoodId = Guid.Parse("d675513e-3be1-4c47-b0d2-0718f02ae93b"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                FoodName = "Hạt mè",
                FoodDescription = "Nhỏ gọn, giàu dưỡng chất, dùng trong món ăn châu Á",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 155
            new Food
            {
                FoodId = Guid.Parse("7f55881d-f8f4-43aa-b4b6-5d56fd56cfde"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                FoodName = "Cá lóc hấp",
                FoodDescription = "Cá đồng ngon ngọt, giàu chất dinh dưỡng",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 156
            new Food
            {
                FoodId = Guid.Parse("bbd19c8e-c1b4-497f-aadb-ca584820c465"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Snack],
                FoodName = "Hạt diêm mạch",
                FoodDescription = "Siêu thực phẩm, giàu protein và chất xơ",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 157
            new Food
            {
                FoodId = Guid.Parse("da3b2de7-bfd2-4c5e-9958-f8a8368b158a"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Cá trắm hấp",
                FoodDescription = "Món cá đồng thơm ngon, dễ chế biến cho mọi nhà",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 158
            new Food
            {
                FoodId = Guid.Parse("c46676b3-cbcc-49e9-ad44-7d450a481a19"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast],
                DishType = [DishType.Snack],
                FoodName = "Yến mạch",
                FoodDescription = "Giàu chất xơ, hỗ trợ tiêu hóa và tốt cho tim mạch",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 159
            new Food
            {
                FoodId = Guid.Parse("597a11b3-31a0-4e70-8d2f-95465ee03e8b"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Cải bó xôi",
                FoodDescription = "Rau lá xanh, chứa nhiều sắt và vitamin K",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 160
            new Food
            {
                FoodId = Guid.Parse("628fe894-0d9c-416f-866b-eb77f763ee62"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Snack],
                DishType = [DishType.Snack],
                FoodName = "Bơ",
                FoodDescription = "Giàu chất béo tốt, giúp nuôi dưỡng làn da và tóc",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 161
            new Food
            {
                FoodId = Guid.Parse("4e46f955-4413-496f-97b4-968a38ee3e11"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Snack],
                FoodName = "Hạt hướng dương",
                FoodDescription = "Thực phẩm ăn nhẹ, giàu vitamin E và khoáng chất",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 162
            new Food
            {
                FoodId = Guid.Parse("0d3e0ef5-afcc-418a-a3f6-f2a24cfd3166"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Snack],
                DishType = [DishType.Snack],
                FoodName = "Hạt óc chó",
                FoodDescription = "Giàu omega-3, hỗ trợ trí não và sức khỏe tim mạch",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 163
            new Food
            {
                FoodId = Guid.Parse("644f32b3-897e-45b1-b4d7-aa8b9585a262"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Rau mồng tơi",
                FoodDescription = "Rau xanh giúp bổ máu, hỗ trợ tiêu hóa tốt",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 164
            new Food
            {
                FoodId = Guid.Parse("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.Dessert],
                FoodName = "Lê",
                FoodDescription = "Trái cây mọng nước, giàu chất xơ và vitamin C",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 165
            new Food
            {
                FoodId = Guid.Parse("2e641c82-56f7-480d-b216-63723b5a5e7d"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.Dessert],
                FoodName = "Dâu tây",
                FoodDescription = "Quả ngọt mọng, giàu chất chống oxy hóa và tốt cho da",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 166
            new Food
            {
                FoodId = Guid.Parse("a8de2767-4b0a-41db-b33b-2523f5be2e0c"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.Dessert],
                FoodName = "Mâm xôi",
                FoodDescription = "Siêu thực phẩm mọng nước, giàu chất xơ và vitamin",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 167
            new Food
            {
                FoodId = Guid.Parse("00333cd3-f43b-40af-855e-95aa8a636e4a"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Snack],
                DishType = [DishType.Snack],
                FoodName = "Bí đỏ",
                FoodDescription = "Nguồn cung cấp beta-carotene tốt cho mắt và da",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 168
            new Food
            {
                FoodId = Guid.Parse("8d95f2a5-cdd0-4c79-8cd0-99ff05cad567"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast],
                DishType = [DishType.Snack],
                FoodName = "Khoai môn",
                FoodDescription = "Thực phẩm bổ dưỡng, giàu tinh bột và khoáng chất",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 169
            new Food
            {
                FoodId = Guid.Parse("37d1bd46-54c4-40ef-a1f0-7bd0883ad818"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Snack],
                FoodName = "Hạt dẻ",
                FoodDescription = "Thực phẩm ăn nhẹ, cung cấp năng lượng và dưỡng chất",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 170
            new Food
            {
                FoodId = Guid.Parse("7afe5fe6-3bcb-4354-86ea-e8d6a81aa9a2"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Măng tây",
                FoodDescription = "Rau xanh giàu folate, tốt cho phụ nữ mang thai",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 171
            new Food
            {
                FoodId = Guid.Parse("ff348fc8-cd36-41c4-984f-a5884171f367"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Bắp cải tím",
                FoodDescription = "Màu sắc hấp dẫn, giàu chất chống oxy hóa",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 172
            new Food
            {
                FoodId = Guid.Parse("e8a16fb6-33a9-4a5a-85f8-ffa5a1465885"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Snack],
                FoodName = "Đậu phộng",
                FoodDescription = "Thực phẩm ăn nhẹ quen thuộc, giàu năng lượng",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 173
            new Food
            {
                FoodId = Guid.Parse("7b3216ff-858e-423e-b8db-a85571aa5488"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.Dessert],
                FoodName = "Kiwi",
                FoodDescription = "Trái cây chua ngọt, giàu vitamin C và chất chống oxy hóa",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 174
            new Food
            {
                FoodId = Guid.Parse("68c8c4c4-e5d6-4e15-ad60-1c18f0c1cb4d"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.Dessert],
                FoodName = "Hạt kê",
                FoodDescription = "Thực phẩm giàu protein thực vật, hỗ trợ tiêu hóa",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 175
            new Food
            {
                FoodId = Guid.Parse("67f6b055-1abc-4a48-97ce-63aea2e5ef7b"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.Dessert],
                FoodName = "Hạt lúa mì",
                FoodDescription = "Nguồn năng lượng dồi dào, bổ sung nhiều vitamin",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 176
            new Food
            {
                FoodId = Guid.Parse("35cad577-0748-469f-8909-7dc013cf1c55"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                FoodName = "Măng khô",
                FoodDescription = "Rau củ khô giàu chất xơ, tiện lợi cho nhiều món ăn",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 177
            new Food
            {
                FoodId = Guid.Parse("575e8bca-57e3-4d16-b380-545a046c9a4e"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Snack],
                FoodName = "Rong biển khô",
                FoodDescription = "Hải sản khô giàu iod, tốt cho chức năng tuyến giáp",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 178
            new Food
            {
                FoodId = Guid.Parse("830df1fb-09f6-4e6e-95c3-e39051e3b2d8"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Bông cải xanh",
                FoodDescription = "Rau xanh giàu vitamin C và chất chống oxy hóa",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 179
            new Food
            {
                FoodId = Guid.Parse("9b98036c-2047-4700-bb13-b34a432bb999"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.Dessert],
                FoodName = "Gạo lứt",
                FoodDescription = "Giàu chất xơ và vitamin, tốt cho sức khỏe tim mạch",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 180
            new Food
            {
                FoodId = Guid.Parse("77b9e248-971c-4292-8cd7-fd7ec55cf643"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.Dessert],
                FoodName = "Đậu lăng",
                FoodDescription = "Nguồn protein thực vật, bổ sung năng lượng bền vững",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 181
            new Food
            {
                FoodId = Guid.Parse("4d773186-20f8-42c2-839b-1ce1601280fa"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.Dessert],
                FoodName = "Xoài",
                FoodDescription = "Trái cây nhiệt đới ngọt, giàu vitamin C và chất xơ",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 182
            new Food
            {
                FoodId = Guid.Parse("1aa49363-ab95-4565-9e27-1855702197fd"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.Dessert],
                FoodName = "Nho",
                FoodDescription = "Trái cây mọng nước, giàu chất chống oxy hóa và kali",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 183
            new Food
            {
                FoodId = Guid.Parse("98c908b5-dad8-4db4-8d60-c6157c53d2c0"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.Dessert],
                FoodName = "Rau cải bó xôi",
                FoodDescription = "Rau xanh chứa nhiều sắt, giúp bổ máu và tăng sức khỏe",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 184
            new Food
            {
                FoodId = Guid.Parse("9349fefa-ecbc-4afc-89f4-62c2f67eb441"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.Dessert],
                FoodName = "Đậu đen",
                FoodDescription = "Nguồn protein thực vật, giàu chất xơ và khoáng chất",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 185
            new Food
            {
                FoodId = Guid.Parse("857b3565-b170-4162-a97b-c0184c4258aa"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.Dessert],
                FoodName = "Củ cải đường",
                FoodDescription = "Củ đỏ giàu dưỡng chất, hỗ trợ chức năng gan và máu",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 186
            new Food
            {
                FoodId = Guid.Parse("7cd76708-7312-445e-a392-14f0e806a786"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.Dessert],
                FoodName = "Đậu Hà Lan",
                FoodDescription = "Rau củ ngọt tự nhiên, giàu vitamin và chất xơ",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 187
            new Food
            {
                FoodId = Guid.Parse("642480b4-22c9-4350-a6ce-c052f99e60e3"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.Dessert],
                FoodName = "Lúa mạch",
                FoodDescription = "Ngũ cốc giàu năng lượng, tốt cho tim mạch và tiêu hóa",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 188
            new Food
            {
                FoodId = Guid.Parse("10869d8c-14b9-4464-85ca-bf76fc4bf91d"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Rau dền đỏ",
                FoodDescription = "Rau củ màu đỏ, giàu sắt và hỗ trợ tuần hoàn máu",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 189
            new Food
            {
                FoodId = Guid.Parse("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Mì gạo lứt",
                FoodDescription = "Mì giàu chất xơ, lựa chọn lành mạnh thay thế mì trắng",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 190
            new Food
            {
                FoodId = Guid.Parse("9979963d-5c37-4fa9-955c-d1ecb5814607"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Rau chân vịt",
                FoodDescription = "Rau xanh giàu folate, tốt cho hệ miễn dịch và máu",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 191
            new Food
            {
                FoodId = Guid.Parse("cf0fce11-3569-435b-8942-9c0ceb23d6dc"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Cá hồi áp chảo",
                FoodDescription = "Cá biển giàu omega-3, hỗ trợ trí não và sức khỏe tim",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 192
            new Food
            {
                FoodId = Guid.Parse("c3480e21-940b-4190-b07c-f3208ae96367"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Snack],
                DishType = [DishType.MainDish, DishType.SideDish],
                FoodName = "Ngũ cốc nguyên hạt",
                FoodDescription = "Thực phẩm nguyên hạt, bổ sung dinh dưỡng toàn diện",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 193
            new Food
            {
                FoodId = Guid.Parse("845454d0-967a-4e48-aef3-bd8458775500"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish],
                FoodName = "Củ cải trắng",
                FoodDescription = "Củ ngọt, ít calo, giúp làm mát cơ thể hiệu quả",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 194
            new Food
            {
                FoodId = Guid.Parse("6a88b8cb-dc82-4751-a2e4-23e5516d850b"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Lunch, MealType.Dinner],
                DishType = [DishType.SideDish, DishType.Drink],
                FoodName = "Rau má",
                FoodDescription = "Rau xanh giàu chất chống oxy hóa, hỗ trợ thải độc",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 195
            new Food
            {
                FoodId = Guid.Parse("7729551a-e475-4079-aaa0-07c02efde2a5"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Snack],
                FoodName = "Hạt lanh",
                FoodDescription = "Giàu omega-3, tốt cho hệ tim mạch và não bộ",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 196
            new Food
            {
                FoodId = Guid.Parse("404a286a-90c5-4c54-8e27-3ddeba55ada3"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Snack],
                FoodName = "Hạt dẻ cười",
                FoodDescription = "Giàu chất xơ và vitamin, tốt cho hệ tiêu hóa",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 197
            new Food
            {
                FoodId = Guid.Parse("49601ef1-2131-478f-a1de-f2e444602be3"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Drink],
                FoodName = "Dừa tươi",
                FoodDescription = "Trái cây mọng nước, cung cấp hydrat và chất điện giải",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 198
            new Food
            {
                FoodId = Guid.Parse("1100703a-e393-4082-887a-c090b3cc16fb"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Dessert, DishType.Snack],
                FoodName = "Hồ đào",
                FoodDescription = "Hạt giàu chất béo tốt, hỗ trợ sức khỏe tim mạch",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 199
            new Food
            {
                FoodId = Guid.Parse("d3c360a2-441e-4700-a6ec-4310b5976901"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Cá thu",
                FoodDescription = "Cá biển giàu omega-3, tăng cường sức khỏe tim mạch",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 200
            new Food
            {
                FoodId = Guid.Parse("0dbbf1e0-031a-4342-bfde-c127644ebddf"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Breakfast, MealType.Snack],
                DishType = [DishType.Snack],
                FoodName = "Bơ đậu phộng",
                FoodDescription = "Ngọt béo tự nhiên, giàu năng lượng cho bữa sáng",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 201
            new Food
            {
                FoodId = Guid.Parse("731974ef-495e-4c08-ba95-20589d60c20c"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Snack],
                FoodName = "Hạt mắc ca",
                FoodDescription = "Hạt thơm ngon, bổ sung dinh dưỡng và năng lượng",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 202
            new Food
            {
                FoodId = Guid.Parse("cb693182-b5ff-4f2b-9a47-44ab84841843"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.Dessert],
                FoodName = "Quả hồng xiêm",
                FoodDescription = "Trái cây nhiệt đới ngọt, giàu chất xơ và vitamin A",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 203 
            new Food
            {
                FoodId = Guid.Parse("f70172ed-7784-47ec-8aa2-a862ee56a13a"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack, MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish, DishType.Snack],
                FoodName = "Cá trích",
                FoodDescription = "Cá biển thơm ngon, tốt cho trí não và tuần hoàn máu",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 204
            new Food
            {
                FoodId = Guid.Parse("d8216f25-d01e-48c6-a44f-0a1672862f53"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Snack],
                FoodName = "Hạt hồ đào",
                FoodDescription = "Hạt giàu chất béo không bão hòa, giúp kiểm soát cholesterol",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 205
            new Food
            {
                FoodId = Guid.Parse("7aee65aa-860d-48c2-ad47-2614e5e04998"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Lunch, MealType.Dinner],
                DishType = [DishType.MainDish],
                FoodName = "Cá chép",
                FoodDescription = "Cá nước ngọt giàu protein và khoáng chất thiết yếu",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            },
            #endregion

            #region Food 206
            new Food
            {
                FoodId = Guid.Parse("aaeb8b86-48b3-454c-a299-ec5a627f7047"),
                CategoryId = Guid.Parse(""),
                UserId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                MealType = [MealType.Snack],
                DishType = [DishType.Dessert],
                FoodName = "Lựu",
                FoodDescription = "Trái cây giàu chất chống oxy hóa, tốt cho tim mạch",
                IsPublic = true,
                Status = true,
                CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
                UpdatedBy = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6"),
            });
            #endregion
        }
    }
}