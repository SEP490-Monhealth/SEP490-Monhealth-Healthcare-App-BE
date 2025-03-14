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
                    FoodId = Guid.Parse("599cfc95-4108-4dcc-9c5a-077173251f8b"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                // bánh mì
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("08b5c5da-4b0c-48f3-98fc-33420bdf8163"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("08b5c5da-4b0c-48f3-98fc-33420bdf8163"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                // chuối
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("a989c8db-7506-467f-8aba-dce042f68eea"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                // sữa tươi k đường
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("c42e7f00-ea31-430a-ac28-8d6e749b7eca"),
                    DishTypeId = drink,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                // bún bò huế
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("021b651c-bb01-4965-95bc-3532fbacad3d"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                // táo
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("8fa26c41-16b2-49f8-a284-856024a5f947"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("1387c20d-27a6-495b-a3a0-efbb715f6430"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("ab2117f7-9940-44cb-b191-2dfabefac8c8"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("ab2117f7-9940-44cb-b191-2dfabefac8c8"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("455bb5ed-ed2c-4172-8831-2b8a08614198"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("1140212e-cdb4-4f25-92f6-9b9407a71163"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("ff1bc1f2-3515-4dfe-b271-8cabf205bbcf"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("fa0d83ce-d0d7-414f-bd85-e4bc6402c0db"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("77fe5e06-7fee-486d-a1a7-c031f2065490"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("86d88717-df08-4de6-b86d-870210864b46"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("a41a3bc6-0f34-409f-9045-0807fbb4469b"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("7378ca5f-f1a8-4c23-a019-50af3012526f"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("42883b21-4cbd-40ce-850f-b0723f1766fe"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("f6cf96c8-adc3-43e0-af5a-8b19623fed94"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("eac10b91-8509-4986-b689-7ee3a3757a18"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("dca16637-cf90-402f-921f-5c60e99e4bfa"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("85822a08-7189-4e08-8f55-25c73698af92"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("a17722bf-899e-40e9-8e54-ae2fc8a34f44"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("19bbab17-91c6-410f-b566-b509d067e76e"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("19bbab17-91c6-410f-b566-b509d067e76e"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("21a4b410-e26d-444b-8b99-bf8b490e5dcf"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("de097440-db5c-4d91-bd55-76618d70599d"),
                    DishTypeId = drink,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("74181cd5-4b0b-48a9-9042-16d8789483d4"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("65c7b876-87e2-4307-ab76-c72ca277b78c"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("65c7b876-87e2-4307-ab76-c72ca277b78c"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("a47b1646-3576-46f0-a3b6-763a9c3f889b"),
                    DishTypeId = drink,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("a3074169-6441-49cc-9ea7-79e240f6dda3"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("0a47589f-d177-46f9-8a10-63fd6da9b611"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("48113ca0-a1e7-4181-85fa-be6538a70873"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("f77e03de-4ed3-41ca-8fa1-0a4947c67384"),
                    DishTypeId = drink,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("d4df84f2-2d79-41e6-b313-28e89e3785ba"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"),
                    DishTypeId = drink,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"),
                    DishTypeId = drink,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"),
                    DishTypeId = drink,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("83e6e455-3ae1-4f5c-8e44-9a5ae79ee31b"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("77243d82-a633-4fe8-84c9-61a4b6cd4428"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("3222413a-e385-4a0b-9d07-2af7b0cb4276"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("e0eec003-8384-412c-a307-b0185afdb0c7"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("da89578e-9470-4b18-af4f-0bdcc011882f"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("37a66f5c-437f-4520-90ec-4376e0093061"),
                    DishTypeId = drink,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("16bf44f2-711d-4b64-a409-995c6b0c13ce"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("fa445aa4-7b0d-4d47-8ba7-f919dd123637"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("05cfce09-72b4-482d-adcd-c0718015be3d"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("58fe08ca-5c52-4847-800e-b9970c3782f0"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("1d0feb2f-0735-4333-87ce-09e22304ad0d"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("e7468877-17ed-4bb9-9956-5e3cf6a58bde"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("e7468877-17ed-4bb9-9956-5e3cf6a58bde"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("40f03f23-9341-4343-9bf8-fdfdb3b9f236"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("dfa879e8-d77d-4199-b07b-16b37f1cbde1"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("c16aac77-64ee-476d-a646-a3029da83e41"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("244e7e03-baaa-4dc4-aa10-d9d0dac410fe"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("51061170-597d-4289-a021-1e7dde88331f"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("c137f014-34c2-4f0a-be52-7c2a5c64abae"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("5ff26461-880d-4b94-bfd0-e8badc77fe33"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("73016f70-ebb4-4583-aa12-7f3f4633ada4"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("0455b535-2662-43aa-bca2-3e75595fb181"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("0455b535-2662-43aa-bca2-3e75595fb181"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("d30f804f-c59b-4a59-bf4c-5196b302d1ed"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("6e12f6cb-6695-4c7a-bfb0-cd4936ee1782"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("faf19891-525a-4308-9222-992e83de7ce7"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("faf19891-525a-4308-9222-992e83de7ce7"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("30355638-a0e2-4126-93ae-beb7aa9b5758"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("8893c58d-06fd-4c34-9e77-2f50779642dd"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("80ba2672-d26a-4703-98f0-d246a50f92f1"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("a53672e7-8593-4779-bd02-9f02ae81f915"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("a53672e7-8593-4779-bd02-9f02ae81f915"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("98006e54-c44e-4a81-aa99-d4bb95bfb89d"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("fb7d87aa-2bb8-4065-bd31-b54239057405"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("f0132626-5535-4f30-9af4-7e89e086aaaf"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),

                    FoodId = Guid.Parse("7268b449-cb54-4f3d-9709-f42b9966d707"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("7b8500af-d730-4138-9617-cba352faed4a"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("dd1482e7-b3dd-4b17-80f6-5618a640c671"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("628d87df-0bde-417d-b8b5-5f8f5536410b"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("fc85f2de-9aae-4ff4-a829-e01662a42976"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("ef8b0ee3-a4d5-4883-af63-33c83d102bea"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("9122357a-179f-45f4-9106-67eea24d48ab"),
                    DishTypeId = drink,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("22d1cbad-a884-400c-b681-30b17d98bf1c"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("22d1cbad-a884-400c-b681-30b17d98bf1c"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("87225215-43af-49f2-a40b-a5ebb087d27b"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("23443efa-dc06-4e7a-949c-5c823ee6e575"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("afe0a180-0077-4fdf-89e8-9513c6132f92"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("16066b9b-e61f-4354-803b-e2f9c9f5a5db"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("8ebd5a6e-b0af-42b6-af58-b681fceac1ef"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("da85064b-e528-4bfa-8a64-1fbe704f9af5"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("86bcbac3-fc75-46ed-8d0e-18c8c4860692"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("a6ce6816-c6e1-4512-aeb6-d5d647815c1d"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("edb9d5d0-01f3-4607-a406-9e04bbff85fb"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("4d640470-857a-4765-905f-e49e98a281a1"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("d3a1c73d-ca5a-45ea-a7fa-d582f1253b79"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("3fa8cf38-d835-4279-a113-a8f44cd013e6"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("d3392e5d-a48f-4b5a-968d-31b98bd47835"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("ad6a860f-4a4a-4cb7-90fa-21c8f36c91ce"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("5ebbc839-81e6-496f-9e4d-8d90d732a906"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("50c0adac-c878-4a21-8b5f-01478e7e4852"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("50c0adac-c878-4a21-8b5f-01478e7e4852"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("55bd2b96-0e5f-4be4-acae-25f5e3e25244"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("a23f6c85-1a80-4255-a9a1-d08c1d60e753"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("8da16f72-42a9-4da2-b217-811903e340c4"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("a5d484c6-9cc8-4d6e-a53c-5c8a2c20999b"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("b29dc622-e8ae-4471-8e22-5676aa5fa909"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("0f7f47a1-f122-4f58-9e24-40ece9323520"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("98b3945a-9169-4581-b1a5-da82f2ebd8d4"),
                    DishTypeId = drink,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("c46676b3-cbcc-49e9-ad44-7d450a481a19"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("c46676b3-cbcc-49e9-ad44-7d450a481a19"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("597a11b3-31a0-4e70-8d2f-95465ee03e8b"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("644f32b3-897e-45b1-b4d7-aa8b9585a262"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("2e641c82-56f7-480d-b216-63723b5a5e7d"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("a8de2767-4b0a-41db-b33b-2523f5be2e0c"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("00333cd3-f43b-40af-855e-95aa8a636e4a"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("8d95f2a5-cdd0-4c79-8cd0-99ff05cad567"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("7afe5fe6-3bcb-4354-86ea-e8d6a81aa9a2"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("ff348fc8-cd36-41c4-984f-a5884171f367"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("7b3216ff-858e-423e-b8db-a85571aa5488"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("35cad577-0748-469f-8909-7dc013cf1c55"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("575e8bca-57e3-4d16-b380-545a046c9a4e"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("830df1fb-09f6-4e6e-95c3-e39051e3b2d8"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("9b98036c-2047-4700-bb13-b34a432bb999"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("9b98036c-2047-4700-bb13-b34a432bb999"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("1aa49363-ab95-4565-9e27-1855702197fd"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("98c908b5-dad8-4db4-8d60-c6157c53d2c0"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("857b3565-b170-4162-a97b-c0184c4258aa"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("7cd76708-7312-445e-a392-14f0e806a786"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("10869d8c-14b9-4464-85ca-bf76fc4bf91d"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("9979963d-5c37-4fa9-955c-d1ecb5814607"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("6a88b8cb-dc82-4751-a2e4-23e5516d850b"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("49601ef1-2131-478f-a1de-f2e444602be3"),
                    DishTypeId = drink,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("d3c360a2-441e-4700-a6ec-4310b5976901"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("cb693182-b5ff-4f2b-9a47-44ab84841843"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("aaeb8b86-48b3-454c-a299-ec5a627f7047"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("5f848972-c5ae-45fc-8ba2-103b24d8a23a"),
                    DishTypeId = soup,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("2ae82bfd-34db-4928-bfee-b60f4aec4460"),
                    DishTypeId = soup,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("c69f3300-4f1b-45ce-bdc3-ae45fec848a7"),
                    DishTypeId = soup,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("6487a532-ff5e-4b77-b408-46c789608de9"),
                    DishTypeId = soup,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("63045676-0e70-425f-aa96-e348a4e88c3a"),
                    DishTypeId = soup,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("827829bf-71cd-4865-80af-1457e0091456"),
                    DishTypeId = soup,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("c5e3e4ed-0164-4917-a1ce-99679b971a22"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("e7d4d8d6-6e9a-4c38-95f2-e9790f5bd2c2"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("fa1f0dc9-270a-4e77-881f-acb53ac1c91d"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("0ece5f0f-9fec-4f74-b948-90dce7ce6ce3"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("7167f942-dc89-4f29-8022-588373aef45e"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("d65c7826-78c0-4991-b3b6-1e2b25437f61"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("90099162-15e0-4ef0-b93e-59d409678b63"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("e1a6ae3e-bbb3-4e7f-9d92-55bd38e6fa2f"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("9669cdf4-c133-476f-b2bd-f3c091346c52"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("61b2c4d9-6de2-4fb2-af3b-fe9fabee0bd4"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("af036922-79f3-45a7-b562-a6279520c0e6"),
                    DishTypeId = soup,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("00bc33fe-4cd5-47df-bd94-15ac9f93648c"),
                    DishTypeId = soup,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("7b3935fa-e426-4dcd-b59f-2dbe8960956b"),
                    DishTypeId = soup,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("3426c7e8-055b-414f-84a3-eb9afdb1d33e"),
                    DishTypeId = soup,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("ea63d4c3-41f7-4f89-bf33-e8a16c5d6956"),
                    DishTypeId = soup,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("a988cc73-072e-4af1-9b53-55fbf0f4fe79"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("2ee163f7-4463-44ec-b9e2-8a409c112db4"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("01e60ae4-ff69-44d6-b4fd-aaf916e3a7e5"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("eec3d874-6331-4e33-bbe6-bf0cc4335b29"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("90a605b6-843d-4cc1-8fe7-a016c76ee29c"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("56513d2d-2472-4fa4-80bc-2f54002b187f"),
                    DishTypeId = soup,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,

                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("2d821db4-3e99-4877-b979-bc82d34b3b01"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("29dfb5da-8818-40ff-bf66-7553521c2161"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("64e0dca1-abd5-4886-b124-ef0f4a44d0a6"),
                    DishTypeId = soup,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("4edcae53-7e30-42bb-8526-7686355f2268"),
                    DishTypeId = soup,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("0292d477-d63b-4904-a83b-2cd8cac39c14"),
                    DishTypeId = soup,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("b80c562a-e1d4-4117-a317-c06b5bae8950"),
                    DishTypeId = mainDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("99ec20c3-f2a7-4727-9d12-a30f92d256cd"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("3dc2fa80-ab87-4e26-907b-3516611371b8"),
                    DishTypeId = soup,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("2c990331-b6ca-4642-893a-be68f0d398d5"),
                    DishTypeId = sideDish,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("f0e4a066-b920-4540-a035-1a5504ff1358"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("c9cb635f-b21e-4b04-9ac9-84d01f2ef42b"),
                    DishTypeId = dessert,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new DishTypeFood()
                {
                    DishTypeFoodId = Guid.NewGuid(),
                    FoodId = Guid.Parse("982d8f3e-f517-4bd2-87a8-48329fc9eb91"),
                    DishTypeId = soup,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
          new DishTypeFood()
          {
              DishTypeFoodId = Guid.NewGuid(),
              FoodId = Guid.Parse("43d635e2-6f0c-4385-83d8-fedfd479d356"),
              DishTypeId = mainDish,
              CreatedAt = DateTime.Now,
              UpdatedAt = DateTime.Now,
          },
          new DishTypeFood()
          {
              DishTypeFoodId = Guid.NewGuid(),
              FoodId = Guid.Parse("8ed85dc2-7654-4c48-81f9-19946a73f71d"),
              DishTypeId = sideDish,
              CreatedAt = DateTime.Now,
              UpdatedAt = DateTime.Now,
          },
          new DishTypeFood()
          {
              DishTypeFoodId = Guid.NewGuid(),
              FoodId = Guid.Parse("881ae045-1c9a-4e20-9160-0e8c14486be5"),
              DishTypeId = soup,
              CreatedAt = DateTime.Now,
              UpdatedAt = DateTime.Now,
          },
          new DishTypeFood()
          {
              DishTypeFoodId = Guid.NewGuid(),
              FoodId = Guid.Parse("b42e9ba6-8aa7-419a-907f-ec7e21cb9337"),
              DishTypeId = soup,
              CreatedAt = DateTime.Now,
              UpdatedAt = DateTime.Now,
          },
          new DishTypeFood()
          {
              DishTypeFoodId = Guid.NewGuid(),
              FoodId = Guid.Parse("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"),
              DishTypeId = mainDish,
              CreatedAt = DateTime.Now,
              UpdatedAt = DateTime.Now,
          },
          new DishTypeFood()
          {
              DishTypeFoodId = Guid.NewGuid(),
              FoodId = Guid.Parse("e370081a-c0a6-4c00-b01c-7c52f953b7f1"),
              DishTypeId = soup,
              CreatedAt = DateTime.Now,
              UpdatedAt = DateTime.Now,
          },
          new DishTypeFood()
          {
              DishTypeFoodId = Guid.NewGuid(),
              FoodId = Guid.Parse("9acdf58c-c37d-4026-a3f9-40fda186184b"),
              DishTypeId = sideDish,
              CreatedAt = DateTime.Now,
              UpdatedAt = DateTime.Now,
          },
          new DishTypeFood()
          {
              DishTypeFoodId = Guid.NewGuid(),
              FoodId = Guid.Parse("b79878e6-36d9-4efc-b3ff-a3c45b35ff21"),
              DishTypeId = mainDish,
              CreatedAt = DateTime.Now,
              UpdatedAt = DateTime.Now,
          },
          new DishTypeFood()
          {
              DishTypeFoodId = Guid.NewGuid(),
              FoodId = Guid.Parse("8382816f-1beb-4804-9698-3b486798b20a"),
              DishTypeId = mainDish,
              CreatedAt = DateTime.Now,
              UpdatedAt = DateTime.Now,
          },
          new DishTypeFood()
          {
              DishTypeFoodId = Guid.NewGuid(),
              FoodId = Guid.Parse("2405ffc3-524e-4331-9e68-47a411d7b9b8"),
              DishTypeId = mainDish,
              CreatedAt = DateTime.Now,
              UpdatedAt = DateTime.Now,
          },
          new DishTypeFood()
          {
              DishTypeFoodId = Guid.NewGuid(),
              FoodId = Guid.Parse("2146faae-2e7c-4460-8d81-38f5d313012c"),
              DishTypeId = mainDish,
              CreatedAt = DateTime.Now,
              UpdatedAt = DateTime.Now,
          },
          new DishTypeFood()
          {
              DishTypeFoodId = Guid.NewGuid(),
              FoodId = Guid.Parse("a950000c-9837-4d1b-b1ae-b9db230f8f1f"),
              DishTypeId = soup,
              CreatedAt = DateTime.Now,
              UpdatedAt = DateTime.Now,
          },
          new DishTypeFood()
          {
              DishTypeFoodId = Guid.NewGuid(),
              FoodId = Guid.Parse("a364353c-d589-4a94-9c3b-3038113ea249"),
              DishTypeId = mainDish,
              CreatedAt = DateTime.Now,
              UpdatedAt = DateTime.Now,
          },
          new DishTypeFood()
          {
              DishTypeFoodId = Guid.NewGuid(),
              FoodId = Guid.Parse("8c9e1c76-2616-43a4-8c80-3e2e23b8ac4f"),
              DishTypeId = mainDish,
              CreatedAt = DateTime.Now,
              UpdatedAt = DateTime.Now,
          },
          new DishTypeFood()
          {
              DishTypeFoodId = Guid.NewGuid(),
              FoodId = Guid.Parse("87cdf191-876c-4270-92f9-4bb1fc2a7fe9"),
              DishTypeId = soup,
              CreatedAt = DateTime.Now,
              UpdatedAt = DateTime.Now,
          },
          new DishTypeFood()
          {
              DishTypeFoodId = Guid.NewGuid(),
              FoodId = Guid.Parse("3d19d971-88d0-4108-a335-24ac9e1dec50"),
              DishTypeId = dessert,
              CreatedAt = DateTime.Now,
              UpdatedAt = DateTime.Now,
          },
          new DishTypeFood()
          {
              DishTypeFoodId = Guid.NewGuid(),
              FoodId = Guid.Parse("a504d882-4f38-413e-bb28-fae1f2787150"),
              DishTypeId = dessert,
              CreatedAt = DateTime.Now,
              UpdatedAt = DateTime.Now,
          },
          new DishTypeFood()
          {
              DishTypeFoodId = Guid.NewGuid(),
              FoodId = Guid.Parse("9f624258-a4ee-4879-a23f-b3d0479f2b1b"),
              DishTypeId = dessert,
              CreatedAt = DateTime.Now,
              UpdatedAt = DateTime.Now,
          },
          new DishTypeFood()
          {
              DishTypeFoodId = Guid.NewGuid(),
              FoodId = Guid.Parse("d034b7e9-b5a2-42d7-95b7-c0c30207293d"),
              DishTypeId = soup,
              CreatedAt = DateTime.Now,
              UpdatedAt = DateTime.Now,
          },
          new DishTypeFood()
          {
              DishTypeFoodId = Guid.NewGuid(),
              FoodId = Guid.Parse("85e621ed-0e0c-4d20-8891-51d311cea4a3"),
              DishTypeId = soup,
              CreatedAt = DateTime.Now,
              UpdatedAt = DateTime.Now,
          }
                );
        }
    }
}
