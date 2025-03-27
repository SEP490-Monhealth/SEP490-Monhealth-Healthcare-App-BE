using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class CategoryFoodConfiguration : IEntityTypeConfiguration<CategoryFood>
    {
        public void Configure(EntityTypeBuilder<CategoryFood> builder)
        {
            var today = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null);

            // Category GUIDs
            var seafood = Guid.Parse("ee39be57-cf88-4420-8e19-606b2ed4dc6d");
            var meat = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2");
            var vegetables = Guid.Parse("6d3beea0-5f00-4a8a-ab52-d5774e3c5770");
            var cereal = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92");
            var grains = Guid.Parse("fe3a3546-b294-4665-9c82-092d4ab5a187");
            var vegetarian = Guid.Parse("22ee062d-4904-4c64-a783-74b3e142aac7");
            var sweets = Guid.Parse("78651ea5-2013-4e50-a55f-714de91a712d");
            var drinks = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26");
            var fermented = Guid.Parse("fc7f66aa-8c09-46db-a679-be440e3ed91f");
            var fruits = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a");
            var fastFood = Guid.Parse("bd21fd3f-8b19-4756-9da8-8ea32fc646d6");

            #region CategoryFood 1
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Cơm - Category: Cereal
                FoodId = Guid.Parse("599cfc95-4108-4dcc-9c5a-077173251f8b"),  // Cơm
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 2
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Bánh mì - Category: Cereal
                FoodId = Guid.Parse("08b5c5da-4b0c-48f3-98fc-33420bdf8163"),  // Bánh mì
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 3
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fruits,  // Chuối - Category: Fruits
                FoodId = Guid.Parse("a989c8db-7506-467f-8aba-dce042f68eea"),  // Chuối
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 4
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Trứng gà luộc - Category: Meat
                FoodId = Guid.Parse("c42e7f00-ea31-430a-ac28-8d6e749b7eca"),  // Trứng gà luộc
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 5
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = sweets,  // Sữa tươi không đường - Category: Sweets
                FoodId = Guid.Parse("021b651c-bb01-4965-95bc-3532fbacad3d"),  // Sữa tươi không đường
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 6
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Bún bò huế - Category: Meat
                FoodId = Guid.Parse("8fa26c41-16b2-49f8-a284-856024a5f947"),  // Bún bò huế
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 7
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fruits,  // Táo - Category: Fruits
                FoodId = Guid.Parse("1387c20d-27a6-495b-a3a0-efbb715f6430"),  // Táo
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 8
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Bún - Category: Cereal
                FoodId = Guid.Parse("ab2117f7-9940-44cb-b191-2dfabefac8c8"),  // Bún
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 9
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Dưa chuột - Category: Vegetables
                FoodId = Guid.Parse("455bb5ed-ed2c-4172-8831-2b8a08614198"),  // Dưa chuột
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 10
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fruits,  // Chuối tây - Category: Fruits
                FoodId = Guid.Parse("1140212e-cdb4-4f25-92f6-9b9407a71163"),  // Chuối tây
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 11
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fruits,  // Chuối tiêu - Category: Fruits
                FoodId = Guid.Parse("ff1bc1f2-3515-4dfe-b271-8cabf205bbcf"),  // Chuối tiêu
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 12
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fruits,  // Ổi - Category: Fruits
                FoodId = Guid.Parse("fa0d83ce-d0d7-414f-bd85-e4bc6402c0db"),  // Ổi
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 13
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Cơm tấm sườn - Category: Cereal
                FoodId = Guid.Parse("77fe5e06-7fee-486d-a1a7-c031f2065490"),  // Cơm tấm sườn
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 14
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fruits,  // Thanh long - Category: Fruits
                FoodId = Guid.Parse("86d88717-df08-4de6-b86d-870210864b46"),  // Thanh long
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 15
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Bún riêu cua - Category: Meat
                FoodId = Guid.Parse("a41a3bc6-0f34-409f-9045-0807fbb4469b"),  // Bún riêu cua
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 16
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Bánh bao - Category: Cereal
                FoodId = Guid.Parse("7378ca5f-f1a8-4c23-a019-50af3012526f"),  // Bánh bao
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 17
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Bún thịt nướng - Category: Meat
                FoodId = Guid.Parse("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"),  // Bún thịt nướng
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 18
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Cà chua - Category: Vegetables
                FoodId = Guid.Parse("42883b21-4cbd-40ce-850f-b0723f1766fe"),  // Cà chua
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 19
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Xôi mặn - Category: Cereal
                FoodId = Guid.Parse("f6cf96c8-adc3-43e0-af5a-8b19623fed94"),  // Xôi mặn
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 20
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fruits,  // Dưa hấu - Category: Fruits
                FoodId = Guid.Parse("eac10b91-8509-4986-b689-7ee3a3757a18"),  // Dưa hấu
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 21
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Chả lụa - Category: Meat
                FoodId = Guid.Parse("dca16637-cf90-402f-921f-5c60e99e4bfa"),  // Chả lụa
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 22
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Cơm gạo lức - Category: Cereal
                FoodId = Guid.Parse("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"),  // Cơm gạo lức
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 23
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Xúc xích - Category: Meat
                FoodId = Guid.Parse("85822a08-7189-4e08-8f55-25c73698af92"),  // Xúc xích
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 24
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Ức gà - Category: Meat
                FoodId = Guid.Parse("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"),  // Ức gà
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 25
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Bắp luộc - Category: Cereal
                FoodId = Guid.Parse("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"),  // Bắp luộc
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 26
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fermented,  // Sữa chua - Category: Fermented
                FoodId = Guid.Parse("a17722bf-899e-40e9-8e54-ae2fc8a34f44"),  // Sữa chua
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 27
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = grains,  // Đậu hũ - Category: Grains
                FoodId = Guid.Parse("19bbab17-91c6-410f-b566-b509d067e76e"),  // Đậu hũ
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 28
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetarian,  // Bánh bao chay - Category: Vegetarian
                FoodId = Guid.Parse("21a4b410-e26d-444b-8b99-bf8b490e5dcf"),  // Bánh bao chay
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 29
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = drinks,  // Nước cam - Category: Drinks
                FoodId = Guid.Parse("de097440-db5c-4d91-bd55-76618d70599d"),  // Nước cam
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 30
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Cà rốt - Category: Vegetables
                FoodId = Guid.Parse("74181cd5-4b0b-48a9-9042-16d8789483d4"),  // Cà rốt
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 31
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Cháo lòng - Category: Cereal
                FoodId = Guid.Parse("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"),  // Cháo lòng
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 32
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fastFood,  // Bánh mì sandwich - Category: FastFood
                FoodId = Guid.Parse("65c7b876-87e2-4307-ab76-c72ca277b78c"),  // Bánh mì sandwich
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 33
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = drinks,  // Nước dừa - Category: Drinks
                FoodId = Guid.Parse("a47b1646-3576-46f0-a3b6-763a9c3f889b"),  // Nước dừa
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 34
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fruits,  // Xoài - Category: Fruits
                FoodId = Guid.Parse("a3074169-6441-49cc-9ea7-79e240f6dda3"),  // Xoài
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 35
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Rau muống - Category: Vegetables
                FoodId = Guid.Parse("0a47589f-d177-46f9-8a10-63fd6da9b611"),  // Rau muống
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 36
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Bún chả - Category: Meat
                FoodId = Guid.Parse("48113ca0-a1e7-4181-85fa-be6538a70873"),  // Bún chả
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 37
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = drinks,  // Sữa hộp milo - Category: Drinks
                FoodId = Guid.Parse("f77e03de-4ed3-41ca-8fa1-0a4947c67384"),  // Sữa hộp milo
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 38
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Bánh canh - Category: Meat
                FoodId = Guid.Parse("d4df84f2-2d79-41e6-b313-28e89e3785ba"),  // Bánh canh
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 39
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Hủ tíu - Category: Meat
                FoodId = Guid.Parse("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"),  // Hủ tíu
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 40
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = drinks,  // Cà phê - Category: Drinks
                FoodId = Guid.Parse("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"),  // Cà phê
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 41
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = drinks,  // Cà phê sữa - Category: Drinks
                FoodId = Guid.Parse("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"),  // Cà phê sữa
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 42
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = drinks,  // Sữa đậu nành - Category: Drinks
                FoodId = Guid.Parse("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"),  // Sữa đậu nành
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 43
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Thịt kho tiêu - Category: Meat
                FoodId = Guid.Parse("83e6e455-3ae1-4f5c-8e44-9a5ae79ee31b"),  // Thịt kho tiêu
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 44
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Bún xào - Category: Meat
                FoodId = Guid.Parse("77243d82-a633-4fe8-84c9-61a4b6cd4428"),  // Bún xào
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 45
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Cải thìa - Category: Vegetables
                FoodId = Guid.Parse("3222413a-e385-4a0b-9d07-2af7b0cb4276"),  // Cải thìa
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 46
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Xôi bắp - Category: Cereal
                FoodId = Guid.Parse("e0eec003-8384-412c-a307-b0185afdb0c7"),  // Xôi bắp
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 47
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Phở bò tái - Category: Meat
                FoodId = Guid.Parse("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"),  // Phở bò tái
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 48
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Phở gà - Category: Meat
                FoodId = Guid.Parse("da89578e-9470-4b18-af4f-0bdcc011882f"),  // Phở gà
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 49
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = drinks,  // Nước chanh - Category: Drinks
                FoodId = Guid.Parse("37a66f5c-437f-4520-90ec-4376e0093061"),  // Nước chanh
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 50
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Bánh mì thịt trứng - Category: Cereal
                FoodId = Guid.Parse("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"),  // Bánh mì thịt trứng
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 51
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fruits,  // Quýt - Category: Fruits
                FoodId = Guid.Parse("16bf44f2-711d-4b64-a409-995c6b0c13ce"),  // Quýt
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 52
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = sweets,  // Sữa chua nha đam - Category: Sweets
                FoodId = Guid.Parse("fa445aa4-7b0d-4d47-8ba7-f919dd123637"),  // Sữa chua nha đam
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            // #region CategoryFood 53
            // builder.HasData(
            // new CategoryFood
            // {
            //     CategoryFoodId = Guid.NewGuid(),
            //     CategoryId = meat,  // Bánh xèo - Category: Meat
            //     FoodId = Guid.Parse("05cfce09-72b4-482d-adcd-c0718015be3d"),  // Bánh xèo
            //     CreatedAt = today,
            //     UpdatedAt = today
            // });
            // #endregion

            #region CategoryFood 54
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Ớt chuông - Category: Vegetables
                FoodId = Guid.Parse("58fe08ca-5c52-4847-800e-b9970c3782f0"),  // Ớt chuông
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 55
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Nấm kim châm - Category: Vegetables
                FoodId = Guid.Parse("1d0feb2f-0735-4333-87ce-09e22304ad0d"),  // Nấm kim châm
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            // #region CategoryFood 56
            // builder.HasData(
            // new CategoryFood
            // {
            //     CategoryFoodId = Guid.NewGuid(),
            //     CategoryId = meat,  // Lòng đỏ trứng gà - Category: Meat
            //     FoodId = Guid.Parse("a782e478-d5c5-4da6-b809-180b48ad08c3"),  // Lòng đỏ trứng gà
            //     CreatedAt = today,
            //     UpdatedAt = today
            // });
            // #endregion

            // #region CategoryFood 57
            // builder.HasData(
            // new CategoryFood
            // {
            //     CategoryFoodId = Guid.NewGuid(),
            //     CategoryId = meat,  // Lòng trắng trứng gà - Category: Meat
            //     FoodId = Guid.Parse("f41484a3-c7df-4530-b7d2-060390103985"),  // Lòng trắng trứng gà
            //     CreatedAt = today,
            //     UpdatedAt = today
            // });
            // #endregion

            #region CategoryFood 58
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Hoành thánh - Category: Meat
                FoodId = Guid.Parse("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"),  // Hoành thánh
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 59
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = seafood,  // Tôm - Category: Seafood
                FoodId = Guid.Parse("e7468877-17ed-4bb9-9956-5e3cf6a58bde"),  // Tôm
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 60
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Đậu bắp - Category: Vegetables
                FoodId = Guid.Parse("40f03f23-9341-4343-9bf8-fdfdb3b9f236"),  // Đậu bắp
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 61
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Bánh canh cua - Category: Meat
                FoodId = Guid.Parse("dfa879e8-d77d-4199-b07b-16b37f1cbde1"),  // Bánh canh cua
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 62
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Bánh bèo - Category: Cereal
                FoodId = Guid.Parse("c16aac77-64ee-476d-a646-a3029da83e41"),  // Bánh bèo
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 63
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Bún mắm - Category: Meat
                FoodId = Guid.Parse("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"),  // Bún mắm
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion
            #region CategoryFood 64
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Cải thảo - Category: Vegetables
                FoodId = Guid.Parse("244e7e03-baaa-4dc4-aa10-d9d0dac410fe"),  // Cải thảo
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 65
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Thịt vịt - Category: Meat
                FoodId = Guid.Parse("51061170-597d-4289-a021-1e7dde88331f"),  // Thịt vịt
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 66
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Thịt gà - Category: Meat
                FoodId = Guid.Parse("c137f014-34c2-4f0a-be52-7c2a5c64abae"),  // Thịt gà
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 67
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Thịt kho trứng - Category: Meat
                FoodId = Guid.Parse("5ff26461-880d-4b94-bfd0-e8badc77fe33"),  // Thịt kho trứng
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 68
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Sườn non - Category: Meat
                FoodId = Guid.Parse("73016f70-ebb4-4583-aa12-7f3f4633ada4"),  // Sườn non
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 69
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Thịt heo bằm - Category: Meat
                FoodId = Guid.Parse("0455b535-2662-43aa-bca2-3e75595fb181"),  // Thịt heo bằm
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 70
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Cơm chiên trứng - Category: Cereal
                FoodId = Guid.Parse("d30f804f-c59b-4a59-bf4c-5196b302d1ed"),  // Cơm chiên trứng
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 71
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Cháo sườn - Category: Meat
                FoodId = Guid.Parse("6e12f6cb-6695-4c7a-bfb0-cd4936ee1782"),  // Cháo sườn
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 72
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Bánh bột lọc - Category: Cereal
                FoodId = Guid.Parse("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"),  // Bánh bột lọc
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 73
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Bánh bao xá xíu - Category: Cereal
                FoodId = Guid.Parse("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"),  // Bánh bao xá xíu
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 74
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = seafood,  // Cá hồi - Category: Seafood
                FoodId = Guid.Parse("faf19891-525a-4308-9222-992e83de7ce7"),  // Cá hồi
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion
            #region CategoryFood 75
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Khoai lang - Category: Vegetables
                FoodId = Guid.Parse("30355638-a0e2-4126-93ae-beb7aa9b5758"),  // Khoai lang
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 76
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Khoai tây - Category: Vegetables
                FoodId = Guid.Parse("8893c58d-06fd-4c34-9e77-2f50779642dd"),  // Khoai tây
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 77
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Hành tây - Category: Vegetables
                FoodId = Guid.Parse("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"),  // Hành tây
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 78
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Bầu - Category: Vegetables
                FoodId = Guid.Parse("80ba2672-d26a-4703-98f0-d246a50f92f1"),  // Bầu
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 79
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = seafood,  // Mực - Category: Seafood
                FoodId = Guid.Parse("a53672e7-8593-4779-bd02-9f02ae81f915"),  // Mực
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 80
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Đậu que - Category: Vegetables
                FoodId = Guid.Parse("98006e54-c44e-4a81-aa99-d4bb95bfb89d"),  // Đậu que
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 81
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Bánh ướt - Category: Cereal
                FoodId = Guid.Parse("fb7d87aa-2bb8-4065-bd31-b54239057405"),  // Bánh ướt
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 82
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Bánh cuốn - Category: Cereal
                FoodId = Guid.Parse("f0132626-5535-4f30-9af4-7e89e086aaaf"),  // Bánh cuốn
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 83
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Canh bún - Category: Meat
                FoodId = Guid.Parse("7268b449-cb54-4f3d-9709-f42b9966d707"),  // Canh bún
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 84
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fruits,  // Vải - Category: Fruits
                FoodId = Guid.Parse("7b8500af-d730-4138-9617-cba352faed4a"),  // Vải
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion
            #region CategoryFood 85
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = seafood,  // Cá khô - Category: Seafood
                FoodId = Guid.Parse("dd1482e7-b3dd-4b17-80f6-5618a640c671"),  // Cá khô
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 86
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Nấm đùi gà - Category: Vegetables
                FoodId = Guid.Parse("628d87df-0bde-417d-b8b5-5f8f5536410b"),  // Nấm đùi gà
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 87
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Mướp - Category: Vegetables
                FoodId = Guid.Parse("fc85f2de-9aae-4ff4-a829-e01662a42976"),  // Mướp
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 88
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Bánh bao trứng cút - Category: Cereal
                FoodId = Guid.Parse("ef8b0ee3-a4d5-4883-af63-33c83d102bea"),  // Bánh bao trứng cút
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 89
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = drinks,  // Trà tắc - Category: Drinks
                FoodId = Guid.Parse("9122357a-179f-45f4-9106-67eea24d48ab"),  // Trà tắc
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 90
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = grains,  // Đậu hũ non - Category: Grains
                FoodId = Guid.Parse("22d1cbad-a884-400c-b681-30b17d98bf1c"),  // Đậu hũ non
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            // #region CategoryFood 91
            // builder.HasData(
            // new CategoryFood
            // {
            //     CategoryFoodId = Guid.NewGuid(),
            //     CategoryId = fermented,  // Nem chua - Category: Fermented
            //     FoodId = Guid.Parse("c81a404a-ec10-428e-acec-dd56ec1d3607"),  // Nem chua
            //     CreatedAt = today,
            //     UpdatedAt = today
            // });
            // #endregion

            #region CategoryFood 92
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = seafood,  // Cá ngừ - Category: Seafood
                FoodId = Guid.Parse("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"),  // Cá ngừ
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 93
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Phở bò viên - Category: Meat
                FoodId = Guid.Parse("87225215-43af-49f2-a40b-a5ebb087d27b"),  // Phở bò viên
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 94
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Khoai lang luộc - Category: Cereal
                FoodId = Guid.Parse("23443efa-dc06-4e7a-949c-5c823ee6e575"),  // Khoai lang luộc
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 95
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fruits,  // Đu đủ - Category: Fruits
                FoodId = Guid.Parse("afe0a180-0077-4fdf-89e8-9513c6132f92"),  // Đu đủ
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 96
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Cháo đậu đỏ - Category: Cereal
                FoodId = Guid.Parse("16066b9b-e61f-4354-803b-e2f9c9f5a5db"),  // Cháo đậu đỏ
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            // #region CategoryFood 97
            // builder.HasData(
            // new CategoryFood
            // {
            //     CategoryFoodId = Guid.NewGuid(),
            //     CategoryId = sweets,  // Chè đậu đen - Category: Sweets
            //     FoodId = Guid.Parse("8ebd5a6e-b0af-42b6-af58-b681fceac1ef"),  // Chè đậu đen
            //     CreatedAt = today,
            //     UpdatedAt = today
            // });
            // #endregion

            #region CategoryFood 98
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fermented,  // Dưa cải chua - Category: Fermented
                FoodId = Guid.Parse("da85064b-e528-4bfa-8a64-1fbe704f9af5"),  // Dưa cải chua
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 99
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Ức gà nướng - Category: Meat
                FoodId = Guid.Parse("86bcbac3-fc75-46ed-8d0e-18c8c4860692"),  // Ức gà nướng
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 100
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Thịt bò nạc - Category: Meat
                FoodId = Guid.Parse("a6ce6816-c6e1-4512-aeb6-d5d647815c1d"),  // Thịt bò nạc
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 101
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = seafood,  // Cá hồi nướng - Category: Seafood
                FoodId = Guid.Parse("edb9d5d0-01f3-4607-a406-9e04bbff85fb"),  // Cá hồi nướng
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 102
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = seafood,  // Tôm hấp - Category: Seafood
                FoodId = Guid.Parse("4d640470-857a-4765-905f-e49e98a281a1"),  // Tôm hấp
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 103
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Thịt lợn nạc - Category: Meat
                FoodId = Guid.Parse("d3a1c73d-ca5a-45ea-a7fa-d582f1253b79"),  // Thịt lợn nạc
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 104
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = seafood,  // Cá thu nướng - Category: Seafood
                FoodId = Guid.Parse("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"),  // Cá thu nướng
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 105
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = grains,  // Đậu nành luộc - Category: Grains
                FoodId = Guid.Parse("3fa8cf38-d835-4279-a113-a8f44cd013e6"),  // Đậu nành luộc
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 106
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = sweets,  // Sữa chua Hy Lạp - Category: Sweets
                FoodId = Guid.Parse("d3392e5d-a48f-4b5a-968d-31b98bd47835"),  // Sữa chua Hy Lạp
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 107
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Ức vịt nướng - Category: Meat
                FoodId = Guid.Parse("ad6a860f-4a4a-4cb7-90fa-21c8f36c91ce"),  // Ức vịt nướng
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 108
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = seafood,  // Cá ngừ đóng hộp - Category: Seafood
                FoodId = Guid.Parse("5ebbc839-81e6-496f-9e4d-8d90d732a906"),  // Cá ngừ đóng hộp
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 109
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetarian,  // Đậu hũ chiên - Category: Vegetarian
                FoodId = Guid.Parse("50c0adac-c878-4a21-8b5f-01478e7e4852"),  // Đậu hũ chiên
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 110
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Bò bít tết - Category: Meat
                FoodId = Guid.Parse("55bd2b96-0e5f-4be4-acae-25f5e3e25244"),  // Bò bít tết
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 111
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = seafood,  // Cá hồi hun khói - Category: Seafood
                FoodId = Guid.Parse("a23f6c85-1a80-4255-a9a1-d08c1d60e753"),  // Cá hồi hun khói
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            // #region CategoryFood 112
            // builder.HasData(
            // new CategoryFood
            // {
            //     CategoryFoodId = Guid.NewGuid(),
            //     CategoryId = grains,  // Hạt hạnh nhân - Category: Grains
            //     FoodId = Guid.Parse("b0f051be-5972-4e7a-a77d-47ec28d58993"),  // Hạt hạnh nhân
            //     CreatedAt = today,
            //     UpdatedAt = today
            // });
            // #endregion

            #region CategoryFood 113
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = grains,  // Đậu hũ sốt cà - Category: Grains
                FoodId = Guid.Parse("8da16f72-42a9-4da2-b217-811903e340c4"),  // Đậu hũ sốt cà
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 114
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Thịt lợn xông khói - Category: Meat
                FoodId = Guid.Parse("a5d484c6-9cc8-4d6e-a53c-5c8a2c20999b"),  // Thịt lợn xông khói
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            // #region CategoryFood 115
            // builder.HasData(
            // new CategoryFood
            // {
            //     CategoryFoodId = Guid.NewGuid(),
            //     CategoryId = grains,  // Hạt bí ngô - Category: Grains
            //     FoodId = Guid.Parse("59988378-901f-4ec4-bd6c-9fdc28ca97a1"),  // Hạt bí ngô
            //     CreatedAt = today,
            //     UpdatedAt = today
            // });
            // #endregion

            #region CategoryFood 116
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = grains,  // Đậu Hà Lan luộc - Category: Grains
                FoodId = Guid.Parse("b29dc622-e8ae-4471-8e22-5676aa5fa909"),  // Đậu Hà Lan luộc
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 117
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Thịt gà quay - Category: Meat
                FoodId = Guid.Parse("0f7f47a1-f122-4f58-9e24-40ece9323520"),  // Thịt gà quay
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 118
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = drinks,  // Sữa bò tươi - Category: Drinks
                FoodId = Guid.Parse("98b3945a-9169-4581-b1a5-da82f2ebd8d4"),  // Sữa bò tươi
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 119
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Yến mạch - Category: Cereal
                FoodId = Guid.Parse("c46676b3-cbcc-49e9-ad44-7d450a481a19"),  // Yến mạch
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 120
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Cải bó xôi - Category: Vegetables
                FoodId = Guid.Parse("597a11b3-31a0-4e70-8d2f-95465ee03e8b"),  // Cải bó xôi
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            // #region CategoryFood 121
            // builder.HasData(
            // new CategoryFood
            // {
            //     CategoryFoodId = Guid.NewGuid(),
            //     CategoryId = grains,  // Hạt hướng dương - Category: Grains
            //     FoodId = Guid.Parse("4e46f955-4413-496f-97b4-968a38ee3e11"),  // Hạt hướng dương
            //     CreatedAt = today,
            //     UpdatedAt = today
            // });
            // #endregion

            #region CategoryFood 122
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Rau mồng tơi - Category: Vegetables
                FoodId = Guid.Parse("644f32b3-897e-45b1-b4d7-aa8b9585a262"),  // Rau mồng tơi
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 123
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fruits,  // Lê - Category: Fruits
                FoodId = Guid.Parse("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"),  // Lê
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 124
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fruits,  // Dâu tây - Category: Fruits
                FoodId = Guid.Parse("2e641c82-56f7-480d-b216-63723b5a5e7d"),  // Dâu tây
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 125
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fruits,  // Mâm xôi - Category: Fruits
                FoodId = Guid.Parse("a8de2767-4b0a-41db-b33b-2523f5be2e0c"),  // Mâm xôi
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 126
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Bí đỏ - Category: Vegetables
                FoodId = Guid.Parse("00333cd3-f43b-40af-855e-95aa8a636e4a"),  // Bí đỏ
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 127
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Khoai môn - Category: Vegetables
                FoodId = Guid.Parse("8d95f2a5-cdd0-4c79-8cd0-99ff05cad567"),  // Khoai môn
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 128
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Măng tây - Category: Vegetables
                FoodId = Guid.Parse("7afe5fe6-3bcb-4354-86ea-e8d6a81aa9a2"),  // Măng tây
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 129
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Bắp cải tím - Category: Vegetables
                FoodId = Guid.Parse("ff348fc8-cd36-41c4-984f-a5884171f367"),  // Bắp cải tím
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 130
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fruits,  // Kiwi - Category: Fruits
                FoodId = Guid.Parse("7b3216ff-858e-423e-b8db-a85571aa5488"),  // Kiwi
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            // #region CategoryFood 131
            // builder.HasData(
            // new CategoryFood
            // {
            //     CategoryFoodId = Guid.NewGuid(),
            //     CategoryId = grains,  // Hạt kê - Category: Grains
            //     FoodId = Guid.Parse("68c8c4c4-e5d6-4e15-ad60-1c18f0c1cb4d"),  // Hạt kê
            //     CreatedAt = today,
            //     UpdatedAt = today
            // });
            // #endregion

            #region CategoryFood 132
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Măng khô - Category: Vegetables
                FoodId = Guid.Parse("35cad577-0748-469f-8909-7dc013cf1c55"),  // Măng khô
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 133
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fermented,  // Rong biển khô - Category: Fermented
                FoodId = Guid.Parse("575e8bca-57e3-4d16-b380-545a046c9a4e"),  // Rong biển khô
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 134
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Bông cải xanh - Category: Vegetables
                FoodId = Guid.Parse("830df1fb-09f6-4e6e-95c3-e39051e3b2d8"),  // Bông cải xanh
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 135
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Gạo lứt - Category: Cereal
                FoodId = Guid.Parse("9b98036c-2047-4700-bb13-b34a432bb999"),  // Gạo lứt
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 136
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fruits,  // Nho - Category: Fruits
                FoodId = Guid.Parse("1aa49363-ab95-4565-9e27-1855702197fd"),  // Nho
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion
            #region CategoryFood 137
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Rau cải bó xôi - Category: Vegetables
                FoodId = Guid.Parse("98c908b5-dad8-4db4-8d60-c6157c53d2c0"),  // Rau cải bó xôi
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            // #region CategoryFood 138
            // builder.HasData(
            // new CategoryFood
            // {
            //     CategoryFoodId = Guid.NewGuid(),
            //     CategoryId = grains,  // Đậu đen - Category: Grains
            //     FoodId = Guid.Parse("9349fefa-ecbc-4afc-89f4-62c2f67eb441"),  // Đậu đen
            //     CreatedAt = today,
            //     UpdatedAt = today
            // });
            // #endregion

            #region CategoryFood 139
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Củ cải đường - Category: Vegetables
                FoodId = Guid.Parse("857b3565-b170-4162-a97b-c0184c4258aa"),  // Củ cải đường
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 140
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Đậu Hà Lan - Category: Vegetables
                FoodId = Guid.Parse("7cd76708-7312-445e-a392-14f0e806a786"),  // Đậu Hà Lan
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            // #region CategoryFood 141
            // builder.HasData(
            // new CategoryFood
            // {
            //     CategoryFoodId = Guid.NewGuid(),
            //     CategoryId = cereal,  // Lúa mạch - Category: Cereal
            //     FoodId = Guid.Parse("642480b4-22c9-4350-a6ce-c052f99e60e3"),  // Lúa mạch
            //     CreatedAt = today,
            //     UpdatedAt = today
            // });
            // #endregion

            #region CategoryFood 142
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Rau dền đỏ - Category: Vegetables
                FoodId = Guid.Parse("10869d8c-14b9-4464-85ca-bf76fc4bf91d"),  // Rau dền đỏ
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 143
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Mì gạo lứt - Category: Cereal
                FoodId = Guid.Parse("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"),  // Mì gạo lứt
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 144
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Rau chân vịt - Category: Vegetables
                FoodId = Guid.Parse("9979963d-5c37-4fa9-955c-d1ecb5814607"),  // Rau chân vịt
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 145
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Củ cải trắng - Category: Vegetables
                FoodId = Guid.Parse("6a88b8cb-dc82-4751-a2e4-23e5516d850b"),  // Củ cải trắng
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            // #region CategoryFood 146
            // builder.HasData(
            // new CategoryFood
            // {
            //     CategoryFoodId = Guid.NewGuid(),
            //     CategoryId = vegetables,  // Rau má - Category: Vegetables
            //     FoodId = Guid.Parse("7729551a-e475-4079-aaa0-07c02efde2a5"),  // Rau má
            //     CreatedAt = today,
            //     UpdatedAt = today
            // });
            // #endregion

            // #region CategoryFood 147
            // builder.HasData(
            // new CategoryFood
            // {
            //     CategoryFoodId = Guid.NewGuid(),
            //     CategoryId = grains,  // Hạt lanh - Category: Grains
            //     FoodId = Guid.Parse("404a286a-90c5-4c54-8e27-3ddeba55ada3"),  // Hạt lanh
            //     CreatedAt = today,
            //     UpdatedAt = today
            // });
            // #endregion

            #region CategoryFood 148
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = grains,  // Hạt dẻ cười - Category: Grains
                FoodId = Guid.Parse("845454d0-967a-4e48-aef3-bd8458775500"),  // Hạt dẻ cười
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 149
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = drinks,  // Dừa tươi - Category: Drinks
                FoodId = Guid.Parse("49601ef1-2131-478f-a1de-f2e444602be3"),  // Dừa tươi
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 150
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = seafood,  // Cá thu - Category: Seafood
                FoodId = Guid.Parse("d3c360a2-441e-4700-a6ec-4310b5976901"),  // Cá thu
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            // #region CategoryFood 151
            // builder.HasData(
            // new CategoryFood
            // {
            //     CategoryFoodId = Guid.NewGuid(),
            //     CategoryId = grains,  // Hạt mắc ca - Category: Grains
            //     FoodId = Guid.Parse("731974ef-495e-4c08-ba95-20589d60c20c"),  // Hạt mắc ca
            //     CreatedAt = today,
            //     UpdatedAt = today
            // });
            // #endregion

            #region CategoryFood 152
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fruits,  // Hồng xiêm - Category: Fruits
                FoodId = Guid.Parse("cb693182-b5ff-4f2b-9a47-44ab84841843"),  // Hồng xiêm
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 153
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fruits,  // Đào - Category: Fruits
                FoodId = Guid.Parse("aaeb8b86-48b3-454c-a299-ec5a627f7047"),  // Đào
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 154
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fruits,  // Lựu - Category: Fruits
                FoodId = Guid.Parse("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"),  // Lựu
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 155
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = seafood,  // Súp cua - Category: Seafood
                FoodId = Guid.Parse("5f848972-c5ae-45fc-8ba2-103b24d8a23a"),  // Súp cua
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 156
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Canh bí đỏ - Category: Vegetables
                FoodId = Guid.Parse("2ae82bfd-34db-4928-bfee-b60f4aec4460"),  // Canh bí đỏ
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 157
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Canh rau củ - Category: Vegetables
                FoodId = Guid.Parse("c69f3300-4f1b-45ce-bdc3-ae45fec848a7"),  // Canh rau củ
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 158
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Canh bí đao - Category: Vegetables
                FoodId = Guid.Parse("6487a532-ff5e-4b77-b408-46c789608de9"),  // Canh bí đao
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 159
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Canh cua mồng tơi - Category: Vegetables
                FoodId = Guid.Parse("63045676-0e70-425f-aa96-e348a4e88c3a"),  // Canh cua mồng tơi
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 160
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Canh nấm - Category: Vegetables
                FoodId = Guid.Parse("827829bf-71cd-4865-80af-1457e0091456"),  // Canh nấm
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 161
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Cháo gà - Category: Meat
                FoodId = Guid.Parse("c5e3e4ed-0164-4917-a1ce-99679b971a22"),  // Cháo gà
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 162
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Cháo sườn non - Category: Meat
                FoodId = Guid.Parse("e7d4d8d6-6e9a-4c38-95f2-e9790f5bd2c2"),  // Cháo sườn non
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 163
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Cháo thịt bằm - Category: Meat
                FoodId = Guid.Parse("fa1f0dc9-270a-4e77-881f-acb53ac1c91d"),  // Cháo thịt bằm
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 164
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = seafood,  // Bún chả cá - Category: Seafood
                FoodId = Guid.Parse("0ece5f0f-9fec-4f74-b948-90dce7ce6ce3"),  // Bún chả cá
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 165
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Bún gà - Category: Meat
                FoodId = Guid.Parse("7167f942-dc89-4f29-8022-588373aef45e"),  // Bún gà
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 166
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = seafood,  // Bún hải sản - Category: Seafood
                FoodId = Guid.Parse("d65c7826-78c0-4991-b3b6-1e2b25437f61"),  // Bún hải sản
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 167
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = seafood,  // Bún ốc - Category: Seafood
                FoodId = Guid.Parse("90099162-15e0-4ef0-b93e-59d409678b63"),  // Bún ốc
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 168
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Cháo vịt - Category: Meat
                FoodId = Guid.Parse("e1a6ae3e-bbb3-4e7f-9d92-55bd38e6fa2f"),  // Cháo vịt
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 169
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Bánh mì chả cá - Category: Meat
                FoodId = Guid.Parse("9669cdf4-c133-476f-b2bd-f3c091346c52"),  // Bánh mì chả cá
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 170
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Mì Quảng - Category: Cereal
                FoodId = Guid.Parse("61b2c4d9-6de2-4fb2-af3b-fe9fabee0bd4"),  // Mì Quảng
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 171
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Miến gà - Category: Meat
                FoodId = Guid.Parse("af036922-79f3-45a7-b562-a6279520c0e6"),  // Miến gà
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 172
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Súp rau củ - Category: Vegetables
                FoodId = Guid.Parse("00bc33fe-4cd5-47df-bd94-15ac9f93648c"),  // Súp rau củ
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 173
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Súp bò hầm - Category: Meat
                FoodId = Guid.Parse("7b3935fa-e426-4dcd-b59f-2dbe8960956b"),  // Súp bò hầm
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 174
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Súp gà nấm - Category: Meat
                FoodId = Guid.Parse("3426c7e8-055b-414f-84a3-eb9afdb1d33e"),  // Súp gà nấm
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 175
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = seafood,  // Súp hải sản - Category: Seafood
                FoodId = Guid.Parse("ea63d4c3-41f7-4f89-bf33-e8a16c5d6956"),  // Súp hải sản
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 176
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Rau xào - Category: Vegetables
                FoodId = Guid.Parse("b42e9ba6-8aa7-419a-907f-ec7e21cb9337"),  // Rau xào
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 177
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Rau luộc - Category: Vegetables
                FoodId = Guid.Parse("99ec20c3-f2a7-4727-9d12-a30f92d256cd"),  // Rau luộc
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 178
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Cơm gà xối mỡ - Category: Meat
                FoodId = Guid.Parse("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"),  // Cơm gà xối mỡ
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 179
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Salad rau - Category: Vegetables
                FoodId = Guid.Parse("2c990331-b6ca-4642-893a-be68f0d398d5"),  // Salad rau
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 180
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Rau muống luộc - Category: Vegetables
                FoodId = Guid.Parse("f0e4a066-b920-4540-a035-1a5504ff1358"),  // Rau muống luộc
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 181
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = seafood,  // Canh chua cá - Category: Seafood
                FoodId = Guid.Parse("c9cb635f-b21e-4b04-9ac9-84d01f2ef42b"),  // Canh chua cá
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 182
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Bánh mì ốp la - Category: Cereal
                FoodId = Guid.Parse("2d821db4-3e99-4877-b979-bc82d34b3b01"),  // Bánh mì ốp la
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 183
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Bò kho - Category: Meat
                FoodId = Guid.Parse("29dfb5da-8818-40ff-bf66-7553521c2161"),  // Bò kho
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 184
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Canh rau ngót - Category: Vegetables
                FoodId = Guid.Parse("64e0dca1-abd5-4886-b124-ef0f4a44d0a6"),  // Canh rau ngót
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 185
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Canh cải xanh - Category: Vegetables
                FoodId = Guid.Parse("881ae045-1c9a-4e20-9160-0e8c14486be5"),  // Canh cải xanh
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 186
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Canh củ quả - Category: Vegetables
                FoodId = Guid.Parse("0292d477-d63b-4904-a83b-2cd8cac39c14"),  // Canh củ quả
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 187
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Thịt heo kho - Category: Meat
                FoodId = Guid.Parse("b80c562a-e1d4-4117-a317-c06b5bae8950"),  // Thịt heo kho
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 188
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Rau muống xào tỏi - Category: Vegetables
                FoodId = Guid.Parse("3dc2fa80-ab87-4e26-907b-3516611371b8"),  // Rau muống xào tỏi
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 189
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Canh bầu - Category: Vegetables
                FoodId = Guid.Parse("2c990331-b6ca-4642-893a-be68f0d398d5"),  // Canh bầu
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 190
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Cải ngọt luộc - Category: Vegetables
                FoodId = Guid.Parse("9acdf58c-c37d-4026-a3f9-40fda186184b"),  // Cải ngọt luộc
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 191
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fruits,  // Mận - Category: Fruits
                FoodId = Guid.Parse("f0e4a066-b920-4540-a035-1a5504ff1358"),  // Mận
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 192
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fruits,  // Chôm chôm - Category: Fruits
                FoodId = Guid.Parse("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"),  // Chôm chôm
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 193
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Canh cải ngọt - Category: Vegetables
                FoodId = Guid.Parse("7b3935fa-e426-4dcd-b59f-2dbe8960956b"),  // Canh cải ngọt
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 194
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Thịt gà kho - Category: Meat
                FoodId = Guid.Parse("4edcae53-7e30-42bb-8526-7686355f2268"),  // Thịt gà kho
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 195
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Bắp cải luộc - Category: Vegetables
                FoodId = Guid.Parse("8ed85dc2-7654-4c48-81f9-19946a73f71d"),  // Bắp cải luộc
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 196
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Canh mùng tơi mướp - Category: Vegetables
                FoodId = Guid.Parse("881ae045-1c9a-4e20-9160-0e8c14486be5"),  // Canh mùng tơi mướp
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 197
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Canh rau dền - Category: Vegetables
                FoodId = Guid.Parse("b80c562a-e1d4-4117-a317-c06b5bae8950"),  // Canh rau dền
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 198
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Cơm chiên - Category: Cereal
                FoodId = Guid.Parse("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"),  // Cơm chiên
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 199
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Canh mướp - Category: Vegetables
                FoodId = Guid.Parse("2c990331-b6ca-4642-893a-be68f0d398d5"),  // Canh mướp
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 200
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Cải ngọt luộc - Category: Vegetables
                FoodId = Guid.Parse("9acdf58c-c37d-4026-a3f9-40fda186184b"),  // Cải ngọt luộc
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 201
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = seafood,  // Cá kho - Category: Seafood
                FoodId = Guid.Parse("b79878e6-36d9-4efc-b3ff-a3c45b35ff21"),  // Cá kho
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 202
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Bánh mì chả lụa - Category: Cereal
                FoodId = Guid.Parse("8382816f-1beb-4804-9698-3b486798b20a"),  // Bánh mì chả lụa
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 203
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Cơm chiên dương châu - Category: Cereal
                FoodId = Guid.Parse("2405ffc3-524e-4331-9e68-47a411d7b9b8"),  // Cơm chiên dương châu
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            // #region CategoryFood 204
            // builder.HasData(
            // new CategoryFood
            // {
            //     CategoryFoodId = Guid.NewGuid(),
            //     CategoryId = cereal,  // Cơm rang - Category: Cereal
            //     FoodId = Guid.Parse("a1ff09f1-9d02-40a8-84de-8da9aad67c58"),  // Cơm rang
            //     CreatedAt = today,
            //     UpdatedAt = today
            // });
            // #endregion

            #region CategoryFood 205
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Cháo đậu xanh - Category: Sweets
                FoodId = Guid.Parse("2146faae-2e7c-4460-8d81-38f5d313012c"),  // Cháo đậu xanh
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            // #region CategoryFood 206
            // builder.HasData(
            // new CategoryFood
            // {
            //     CategoryFoodId = Guid.NewGuid(),
            //     CategoryId = cereal,  // Mì xào thập cẩm - Category: Cereal
            //     FoodId = Guid.Parse("7a253877-3c54-4fcf-bb05-d9f4e14d5b64"),  // Mì xào thập cẩm
            //     CreatedAt = today,
            //     UpdatedAt = today
            // });
            // #endregion

            #region CategoryFood 207
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Súp khoai tây - Category: Vegetables
                FoodId = Guid.Parse("a950000c-9837-4d1b-b1ae-b9db230f8f1f"),  // Súp khoai tây
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            // #region CategoryFood 208
            // builder.HasData(
            // new CategoryFood
            // {
            //     CategoryFoodId = Guid.NewGuid(),
            //     CategoryId = cereal,  // Bánh cuốn thịt bằm - Category: Cereal
            //     FoodId = Guid.Parse("30f9d9dc-1653-495c-99b7-b649c49f7930"),  // Bánh cuốn thịt bằm
            //     CreatedAt = today,
            //     UpdatedAt = today
            // });
            // #endregion

            #region CategoryFood 209
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Bò xào rau củ - Category: Meat
                FoodId = Guid.Parse("a364353c-d589-4a94-9c3b-3038113ea249"),  // Bò xào rau củ
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            // #region CategoryFood 210
            // builder.HasData(
            // new CategoryFood
            // {
            //     CategoryFoodId = Guid.NewGuid(),
            //     CategoryId = meat,  // Cơm gà - Category: Meat
            //     FoodId = Guid.Parse("cf9ab10f-2094-496b-9018-96b9d2e1af76"),  // Cơm gà
            //     CreatedAt = today,
            //     UpdatedAt = today
            // });
            // #endregion

            #region CategoryFood 211
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = cereal,  // Bánh hỏi - Category: Cereal
                FoodId = Guid.Parse("8c9e1c76-2616-43a4-8c80-3e2e23b8ac4f"),  // Bánh hỏi
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 212
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = vegetables,  // Canh bí đỏ nấu tôm - Category: Vegetables
                FoodId = Guid.Parse("87cdf191-876c-4270-92f9-4bb1fc2a7fe9"),  // Canh bí đỏ nấu tôm
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 213
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fruits,  // Măng cụt - Category: Fruits
                FoodId = Guid.Parse("3d19d971-88d0-4108-a335-24ac9e1dec50"),  // Măng cụt
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 214
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fruits,  // Nhãn - Category: Fruits
                FoodId = Guid.Parse("a504d882-4f38-413e-bb28-fae1f2787150"),  // Nhãn
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 215
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = fruits,  // Cam - Category: Fruits
                FoodId = Guid.Parse("9f624258-a4ee-4879-a23f-b3d0479f2b1b"),  // Cam
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 216
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = seafood,  // Canh hẹ tôm - Category: Seafood
                FoodId = Guid.Parse("d034b7e9-b5a2-42d7-95b7-c0c30207293d"),  // Canh hẹ tôm
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion

            #region CategoryFood 217
            builder.HasData(
            new CategoryFood
            {
                CategoryFoodId = Guid.NewGuid(),
                CategoryId = meat,  // Canh thịt bò hầm - Category: Meat
                FoodId = Guid.Parse("85e621ed-0e0c-4d20-8891-51d311cea4a3"),  // Canh thịt bò hầm
                CreatedAt = today,
                UpdatedAt = today
            });
            #endregion







        }
    }
}









