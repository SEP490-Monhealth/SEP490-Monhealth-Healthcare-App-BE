using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class DishTypeFoodConfiguration
        : IEntityTypeConfiguration<DishTypeFood>
    {
        public void Configure(EntityTypeBuilder<DishTypeFood> builder)
        {
            var mainDish = Guid.Parse("640474cb-2135-4648-b921-fca3a9219533");
            var sideDish = Guid.Parse("a8a61860-12ee-4216-b185-1b8b6703c24d");
            var soup = Guid.Parse("c5791b20-5d7f-439c-9db6-418a7b18b457");
            var snack = Guid.Parse("5bc13328-01b0-4f09-a32b-5c2f3384c98c");
            var dessert = Guid.Parse("e59c6c9e-cd2b-4b10-bbe1-d9632a938f36");
            var drink = Guid.Parse("c76a8736-de8a-417a-864a-68e64ee2b2eb");

            builder.HasData(
                // Cơm
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("599cfc95-4108-4dcc-9c5a-077173251f8b"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bánh mì
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("08b5c5da-4b0c-48f3-98fc-33420bdf8163"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("08b5c5da-4b0c-48f3-98fc-33420bdf8163"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Chuối
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dessert,
                    FoodId = Guid.Parse("a989c8db-7506-467f-8aba-dce042f68eea"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Trứng gà luộc
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("c42e7f00-ea31-430a-ac28-8d6e749b7eca"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("c42e7f00-ea31-430a-ac28-8d6e749b7eca"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Sữa tươi không đường
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = drink,
                    FoodId = Guid.Parse("021b651c-bb01-4965-95bc-3532fbacad3d"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bún bò huế
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("8fa26c41-16b2-49f8-a284-856024a5f947"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Táo
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dessert,
                    FoodId = Guid.Parse("1387c20d-27a6-495b-a3a0-efbb715f6430"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bún
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("ab2117f7-9940-44cb-b191-2dfabefac8c8"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("ab2117f7-9940-44cb-b191-2dfabefac8c8"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Dưa chuột
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("455bb5ed-ed2c-4172-8831-2b8a08614198"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Chuối tây
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dessert,
                    FoodId = Guid.Parse("1140212e-cdb4-4f25-92f6-9b9407a71163"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Chuối tiêu
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dessert,
                    FoodId = Guid.Parse("ff1bc1f2-3515-4dfe-b271-8cabf205bbcf"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Ổi
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dessert,
                    FoodId = Guid.Parse("fa0d83ce-d0d7-414f-bd85-e4bc6402c0db"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cơm tấm sườn
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("77fe5e06-7fee-486d-a1a7-c031f2065490"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Thanh long
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dessert,
                    FoodId = Guid.Parse("86d88717-df08-4de6-b86d-870210864b46"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bún riêu cua
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("a41a3bc6-0f34-409f-9045-0807fbb4469b"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bánh bao   
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("7378ca5f-f1a8-4c23-a019-50af3012526f"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bún thịt nướng
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cà chua
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("42883b21-4cbd-40ce-850f-b0723f1766fe"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Xôi mặn
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("f6cf96c8-adc3-43e0-af5a-8b19623fed94"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Dưa hấu
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dessert,
                    FoodId = Guid.Parse("eac10b91-8509-4986-b689-7ee3a3757a18"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Chả lụa
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("dca16637-cf90-402f-921f-5c60e99e4bfa"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cơm gạo lức
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Xúc xích
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("85822a08-7189-4e08-8f55-25c73698af92"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Ức gà
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bắp luộc
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Sữa chua
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dessert,
                    FoodId = Guid.Parse("a17722bf-899e-40e9-8e54-ae2fc8a34f44"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Đậu hũ
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("19bbab17-91c6-410f-b566-b509d067e76e"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("19bbab17-91c6-410f-b566-b509d067e76e"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bánh bao chay
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("21a4b410-e26d-444b-8b99-bf8b490e5dcf"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Nước cam
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = drink,
                    FoodId = Guid.Parse("de097440-db5c-4d91-bd55-76618d70599d"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cà rốt
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("74181cd5-4b0b-48a9-9042-16d8789483d4"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cháo lòng
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bánh mì sandwich
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("65c7b876-87e2-4307-ab76-c72ca277b78c"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("65c7b876-87e2-4307-ab76-c72ca277b78c"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Nước dừa
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = drink,
                    FoodId = Guid.Parse("a47b1646-3576-46f0-a3b6-763a9c3f889b"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Xoài
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dessert,
                    FoodId = Guid.Parse("a3074169-6441-49cc-9ea7-79e240f6dda3"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Rau muống   
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("0a47589f-d177-46f9-8a10-63fd6da9b611"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bún chả
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("48113ca0-a1e7-4181-85fa-be6538a70873"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Sữa hộp milo
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = drink,
                    FoodId = Guid.Parse("f77e03de-4ed3-41ca-8fa1-0a4947c67384"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bánh canh
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("d4df84f2-2d79-41e6-b313-28e89e3785ba"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Hủ tíu
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cà phê
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = drink,
                    FoodId = Guid.Parse("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cà phê sữa
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = drink,
                    FoodId = Guid.Parse("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Sữa đậu nành
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = drink,
                    FoodId = Guid.Parse("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Thịt kho tiêu
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("83e6e455-3ae1-4f5c-8e44-9a5ae79ee31b"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bún xào
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("77243d82-a633-4fe8-84c9-61a4b6cd4428"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cải thìa
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("3222413a-e385-4a0b-9d07-2af7b0cb4276"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Xôi bắp
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("e0eec003-8384-412c-a307-b0185afdb0c7"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Phở bò tái
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Phở gà
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("da89578e-9470-4b18-af4f-0bdcc011882f"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Nước chanh
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = drink,
                    FoodId = Guid.Parse("37a66f5c-437f-4520-90ec-4376e0093061"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bánh mì thịt trứng
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Quýt
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dessert,
                    FoodId = Guid.Parse("16bf44f2-711d-4b64-a409-995c6b0c13ce"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Sữa chua nha đam
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dessert,
                    FoodId = Guid.Parse("fa445aa4-7b0d-4d47-8ba7-f919dd123637"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bánh xèo
                // new DishTypeFood()
                // {
                //     DishTypeFoodId = Guid.NewGuid(),
                //     DishTypeId = mainDish,
                //     FoodId = Guid.Parse("05cfce09-72b4-482d-adcd-c0718015be3d"),
                //     CreatedAt = DateTime.UtcNow,
                //     UpdatedAt = DateTime.UtcNow,
                // },

                // Ớt chuông
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("58fe08ca-5c52-4847-800e-b9970c3782f0"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Nấm kim châm
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("1d0feb2f-0735-4333-87ce-09e22304ad0d"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Hoành thánh
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Tôm
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("e7468877-17ed-4bb9-9956-5e3cf6a58bde"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("e7468877-17ed-4bb9-9956-5e3cf6a58bde"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Đậu bắp
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("40f03f23-9341-4343-9bf8-fdfdb3b9f236"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bánh canh cua
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("dfa879e8-d77d-4199-b07b-16b37f1cbde1"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bánh bèo
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("c16aac77-64ee-476d-a646-a3029da83e41"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bún mắm
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cải thảo
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("244e7e03-baaa-4dc4-aa10-d9d0dac410fe"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Thịt vịt
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("51061170-597d-4289-a021-1e7dde88331f"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Thịt gà
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("c137f014-34c2-4f0a-be52-7c2a5c64abae"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Thịt kho trứng
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("5ff26461-880d-4b94-bfd0-e8badc77fe33"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Sườn non
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("73016f70-ebb4-4583-aa12-7f3f4633ada4"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Thịt heo bằm
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("0455b535-2662-43aa-bca2-3e75595fb181"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("0455b535-2662-43aa-bca2-3e75595fb181"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cơm chiên trứng
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("d30f804f-c59b-4a59-bf4c-5196b302d1ed"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cháo sườn
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("6e12f6cb-6695-4c7a-bfb0-cd4936ee1782"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bánh bột lọc
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bánh bao xá xíu
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cá hồi
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("faf19891-525a-4308-9222-992e83de7ce7"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("faf19891-525a-4308-9222-992e83de7ce7"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Khoai lang
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("30355638-a0e2-4126-93ae-beb7aa9b5758"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Khoai tây
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("8893c58d-06fd-4c34-9e77-2f50779642dd"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Hành tây
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bầu
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("80ba2672-d26a-4703-98f0-d246a50f92f1"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Mực
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("a53672e7-8593-4779-bd02-9f02ae81f915"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("a53672e7-8593-4779-bd02-9f02ae81f915"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Đậu que
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("98006e54-c44e-4a81-aa99-d4bb95bfb89d"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bánh ướt
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("fb7d87aa-2bb8-4065-bd31-b54239057405"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bánh cuốn
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("f0132626-5535-4f30-9af4-7e89e086aaaf"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Canh bún
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),

                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("7268b449-cb54-4f3d-9709-f42b9966d707"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Vải
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dessert,
                    FoodId = Guid.Parse("7b8500af-d730-4138-9617-cba352faed4a"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cá khô
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("dd1482e7-b3dd-4b17-80f6-5618a640c671"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Nấm đùi gà
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("628d87df-0bde-417d-b8b5-5f8f5536410b"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Mướp
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("fc85f2de-9aae-4ff4-a829-e01662a42976"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bánh bao trứng cút
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("ef8b0ee3-a4d5-4883-af63-33c83d102bea"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Trà tắc
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = drink,
                    FoodId = Guid.Parse("9122357a-179f-45f4-9106-67eea24d48ab"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Đậu hũ non
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("22d1cbad-a884-400c-b681-30b17d98bf1c"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("22d1cbad-a884-400c-b681-30b17d98bf1c"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cá ngừ
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Phở bò viên
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("87225215-43af-49f2-a40b-a5ebb087d27b"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Khoai lang luộc
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("23443efa-dc06-4e7a-949c-5c823ee6e575"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Đu đủ
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dessert,
                    FoodId = Guid.Parse("afe0a180-0077-4fdf-89e8-9513c6132f92"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cháo đậu đỏ
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("16066b9b-e61f-4354-803b-e2f9c9f5a5db"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Chè đậu đen
                // new DishTypeFood()
                // {
                //     DishTypeFoodId = Guid.NewGuid(),
                //     DishTypeId = dessert,
                //     FoodId = Guid.Parse("8ebd5a6e-b0af-42b6-af58-b681fceac1ef"),
                //     CreatedAt = DateTime.UtcNow,
                //     UpdatedAt = DateTime.UtcNow,
                // },

                // Dưa cải chua
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("da85064b-e528-4bfa-8a64-1fbe704f9af5"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Ức gà nướng
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("86bcbac3-fc75-46ed-8d0e-18c8c4860692"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Thịt bò nạc
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("a6ce6816-c6e1-4512-aeb6-d5d647815c1d"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cá hồi nướng
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("edb9d5d0-01f3-4607-a406-9e04bbff85fb"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Tôm hấp
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("4d640470-857a-4765-905f-e49e98a281a1"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("4d640470-857a-4765-905f-e49e98a281a1"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Thịt lợn nạc
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("d3a1c73d-ca5a-45ea-a7fa-d582f1253b79"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cá thu nướng
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Đậu nành luộc
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("3fa8cf38-d835-4279-a113-a8f44cd013e6"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Sữa chua Hy Lạp
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dessert,
                    FoodId = Guid.Parse("d3392e5d-a48f-4b5a-968d-31b98bd47835"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Ức vịt nướng
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("ad6a860f-4a4a-4cb7-90fa-21c8f36c91ce"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cá ngừ đóng hộp
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("5ebbc839-81e6-496f-9e4d-8d90d732a906"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("5ebbc839-81e6-496f-9e4d-8d90d732a906"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Đậu hũ chiên
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("50c0adac-c878-4a21-8b5f-01478e7e4852"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("50c0adac-c878-4a21-8b5f-01478e7e4852"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bò bít tết
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("55bd2b96-0e5f-4be4-acae-25f5e3e25244"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cá hồi hun khói
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("a23f6c85-1a80-4255-a9a1-d08c1d60e753"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Đậu hũ sốt cà
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("8da16f72-42a9-4da2-b217-811903e340c4"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("8da16f72-42a9-4da2-b217-811903e340c4"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Thịt lợn xông khói
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("a5d484c6-9cc8-4d6e-a53c-5c8a2c20999b"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Đậu Hà Lan luộc
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("b29dc622-e8ae-4471-8e22-5676aa5fa909"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Thịt gà quay
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("0f7f47a1-f122-4f58-9e24-40ece9323520"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Sữa bò tươi
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = drink,
                    FoodId = Guid.Parse("98b3945a-9169-4581-b1a5-da82f2ebd8d4"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Yến mạch
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("c46676b3-cbcc-49e9-ad44-7d450a481a19"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("c46676b3-cbcc-49e9-ad44-7d450a481a19"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cải bó xôi
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("597a11b3-31a0-4e70-8d2f-95465ee03e8b"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Rau mồng tơi
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("644f32b3-897e-45b1-b4d7-aa8b9585a262"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Lê
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dessert,
                    FoodId = Guid.Parse("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Dâu tây
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dessert,
                    FoodId = Guid.Parse("2e641c82-56f7-480d-b216-63723b5a5e7d"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Mâm xôi
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dessert,
                    FoodId = Guid.Parse("a8de2767-4b0a-41db-b33b-2523f5be2e0c"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bí đỏ
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("00333cd3-f43b-40af-855e-95aa8a636e4a"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Khoai môn
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("8d95f2a5-cdd0-4c79-8cd0-99ff05cad567"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Măng tây
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("7afe5fe6-3bcb-4354-86ea-e8d6a81aa9a2"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bắp cải tím
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("ff348fc8-cd36-41c4-984f-a5884171f367"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Kiwi
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dessert,
                    FoodId = Guid.Parse("7b3216ff-858e-423e-b8db-a85571aa5488"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Măng khô
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("35cad577-0748-469f-8909-7dc013cf1c55"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Rong biển khô
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("575e8bca-57e3-4d16-b380-545a046c9a4e"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bông cải xanh
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("830df1fb-09f6-4e6e-95c3-e39051e3b2d8"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Gạo lứt
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("9b98036c-2047-4700-bb13-b34a432bb999"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("9b98036c-2047-4700-bb13-b34a432bb999"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Nho
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dessert,
                    FoodId = Guid.Parse("1aa49363-ab95-4565-9e27-1855702197fd"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Rau cải bó xôi
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("98c908b5-dad8-4db4-8d60-c6157c53d2c0"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Củ cải đường
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("857b3565-b170-4162-a97b-c0184c4258aa"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Đậu Hà Lan
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("7cd76708-7312-445e-a392-14f0e806a786"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Rau dền đỏ
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("10869d8c-14b9-4464-85ca-bf76fc4bf91d"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Mì gạo lứt
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Rau chân vịt
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("9979963d-5c37-4fa9-955c-d1ecb5814607"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Củ cải trắng
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("845454d0-967a-4e48-aef3-bd8458775500"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Rau má
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("6a88b8cb-dc82-4751-a2e4-23e5516d850b"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Dừa tươi
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = drink,
                    FoodId = Guid.Parse("49601ef1-2131-478f-a1de-f2e444602be3"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cá thu
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("d3c360a2-441e-4700-a6ec-4310b5976901"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Hồng xiêm
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dessert,
                    FoodId = Guid.Parse("cb693182-b5ff-4f2b-9a47-44ab84841843"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Đào
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dessert,
                    FoodId = Guid.Parse("aaeb8b86-48b3-454c-a299-ec5a627f7047"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Lựu
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dessert,
                    FoodId = Guid.Parse("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Súp cua
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = soup,
                    FoodId = Guid.Parse("5f848972-c5ae-45fc-8ba2-103b24d8a23a"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Canh bí đỏ
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = soup,
                    FoodId = Guid.Parse("2ae82bfd-34db-4928-bfee-b60f4aec4460"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Canh rau củ
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = soup,
                    FoodId = Guid.Parse("c69f3300-4f1b-45ce-bdc3-ae45fec848a7"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Canh bí đao
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = soup,
                    FoodId = Guid.Parse("6487a532-ff5e-4b77-b408-46c789608de9"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Canh cua mồng tơi
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = soup,
                    FoodId = Guid.Parse("63045676-0e70-425f-aa96-e348a4e88c3a"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Canh nấm
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = soup,
                    FoodId = Guid.Parse("827829bf-71cd-4865-80af-1457e0091456"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cháo gà
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("c5e3e4ed-0164-4917-a1ce-99679b971a22"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cháo sườn non
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("e7d4d8d6-6e9a-4c38-95f2-e9790f5bd2c2"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cháo thịt bằm
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("fa1f0dc9-270a-4e77-881f-acb53ac1c91d"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bún chả cá
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("0ece5f0f-9fec-4f74-b948-90dce7ce6ce3"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bún gà
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("7167f942-dc89-4f29-8022-588373aef45e"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bún hải sản
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("d65c7826-78c0-4991-b3b6-1e2b25437f61"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bún ốc
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("90099162-15e0-4ef0-b93e-59d409678b63"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cháo vịt
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("e1a6ae3e-bbb3-4e7f-9d92-55bd38e6fa2f"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bánh mì chả cá
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("9669cdf4-c133-476f-b2bd-f3c091346c52"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Mì quảng
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("61b2c4d9-6de2-4fb2-af3b-fe9fabee0bd4"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Miến gà
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("af036922-79f3-45a7-b562-a6279520c0e6"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Súp rau củ
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = soup,
                    FoodId = Guid.Parse("00bc33fe-4cd5-47df-bd94-15ac9f93648c"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Súp bò hầm
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = soup,
                    FoodId = Guid.Parse("7b3935fa-e426-4dcd-b59f-2dbe8960956b"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Súp gà nấm
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = soup,
                    FoodId = Guid.Parse("3426c7e8-055b-414f-84a3-eb9afdb1d33e"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Súp hải sản
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = soup,
                    FoodId = Guid.Parse("ea63d4c3-41f7-4f89-bf33-e8a16c5d6956"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Rau xào
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("a988cc73-072e-4af1-9b53-55fbf0f4fe79"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Rau luộc
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("2ee163f7-4463-44ec-b9e2-8a409c112db4"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cơm gà xối mỡ
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("01e60ae4-ff69-44d6-b4fd-aaf916e3a7e5"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Salad rau
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("eec3d874-6331-4e33-bbe6-bf0cc4335b29"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Rau muống luộc
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("90a605b6-843d-4cc1-8fe7-a016c76ee29c"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Canh chua cá
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = soup,
                    FoodId = Guid.Parse("56513d2d-2472-4fa4-80bc-2f54002b187f"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,

                },

                // Bánh mì ốp la
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("2d821db4-3e99-4877-b979-bc82d34b3b01"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bò kho
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("29dfb5da-8818-40ff-bf66-7553521c2161"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Canh rau ngót
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = soup,
                    FoodId = Guid.Parse("64e0dca1-abd5-4886-b124-ef0f4a44d0a6"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Canh cải xanh
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = soup,
                    FoodId = Guid.Parse("4edcae53-7e30-42bb-8526-7686355f2268"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Canh củ quả
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = soup,
                    FoodId = Guid.Parse("0292d477-d63b-4904-a83b-2cd8cac39c14"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Thịt heo kho
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("b80c562a-e1d4-4117-a317-c06b5bae8950"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Rau muống xào tỏi
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("99ec20c3-f2a7-4727-9d12-a30f92d256cd"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Canh bầu
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = soup,
                    FoodId = Guid.Parse("3dc2fa80-ab87-4e26-907b-3516611371b8"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Rau cải xanh
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("2c990331-b6ca-4642-893a-be68f0d398d5"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Mận
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dessert,
                    FoodId = Guid.Parse("f0e4a066-b920-4540-a035-1a5504ff1358"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Chôm chôm
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dessert,
                    FoodId = Guid.Parse("c9cb635f-b21e-4b04-9ac9-84d01f2ef42b"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Canh cải ngọt
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = soup,
                    FoodId = Guid.Parse("982d8f3e-f517-4bd2-87a8-48329fc9eb91"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Thịt gà kho
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("43d635e2-6f0c-4385-83d8-fedfd479d356"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bắp cải luộc
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("8ed85dc2-7654-4c48-81f9-19946a73f71d"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Canh mùng tơi mướp
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = soup,
                    FoodId = Guid.Parse("881ae045-1c9a-4e20-9160-0e8c14486be5"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Canh rau dền
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = soup,
                    FoodId = Guid.Parse("b42e9ba6-8aa7-419a-907f-ec7e21cb9337"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cơm chiên
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Canh mướp
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = soup,
                    FoodId = Guid.Parse("e370081a-c0a6-4c00-b01c-7c52f953b7f1"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cải ngọt luộc
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("9acdf58c-c37d-4026-a3f9-40fda186184b"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cá kho
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("b79878e6-36d9-4efc-b3ff-a3c45b35ff21"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bánh mì chả lụa
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("8382816f-1beb-4804-9698-3b486798b20a"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cơm chiên dương châu
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("2405ffc3-524e-4331-9e68-47a411d7b9b8"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cháo đậu xanh
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("2146faae-2e7c-4460-8d81-38f5d313012c"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Súp khoai tây
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = soup,
                    FoodId = Guid.Parse("a950000c-9837-4d1b-b1ae-b9db230f8f1f"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bò xào rau củ
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("a364353c-d589-4a94-9c3b-3038113ea249"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Bánh hỏi
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = mainDish,
                    FoodId = Guid.Parse("8c9e1c76-2616-43a4-8c80-3e2e23b8ac4f"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = sideDish,
                    FoodId = Guid.Parse("8c9e1c76-2616-43a4-8c80-3e2e23b8ac4f"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Canh bí đỏ nấu tôm
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = soup,
                    FoodId = Guid.Parse("87cdf191-876c-4270-92f9-4bb1fc2a7fe9"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Măng cụt
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dessert,
                    FoodId = Guid.Parse("3d19d971-88d0-4108-a335-24ac9e1dec50"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Nhãn
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dessert,
                    FoodId = Guid.Parse("a504d882-4f38-413e-bb28-fae1f2787150"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Cam
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = dessert,
                    FoodId = Guid.Parse("9f624258-a4ee-4879-a23f-b3d0479f2b1b"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Canh hẹ tôm
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = soup,
                    FoodId = Guid.Parse("d034b7e9-b5a2-42d7-95b7-c0c30207293d"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },

                // Canh thịt bò hầm
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    DishTypeId = soup,
                    FoodId = Guid.Parse("85e621ed-0e0c-4d20-8891-51d311cea4a3"),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                }
            );
        }
    }
}
