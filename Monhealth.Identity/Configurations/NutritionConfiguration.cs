using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class NutritionConfiguration : IEntityTypeConfiguration<Nutrition>
    {
        public void Configure(EntityTypeBuilder<Nutrition> builder)
        {
            var today = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null);

            builder.HasData(

            #region Nutrition 1
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("599cfc95-4108-4dcc-9c5a-077173251f8b"), // Cơm
                Calories = 130,
                Protein = 2.7f,
                Carbs = 28,
                Fiber = 0.4f,
                Sugar = 0.1f,
                Fat = 0.3f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.1f,
                Cholesterol = 0,
                Sodium = 1,
                Potassium = 35,
                Calcium = 10,
                Iron = 0.2f,
                VitaminA = 0,
                VitaminB1 = 0.02f,
                VitaminB2 = 0.01f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 2
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("08b5c5da-4b0c-48f3-98fc-33420bdf8163"), // Bánh mì
                Calories = 265,
                Protein = 9,
                Carbs = 49f,
                Fiber = 2.7f,
                Sugar = 5,
                Fat = 3.2f,
                SaturatedFat = 0.5f,
                UnsaturatedFat = 0.8f,
                Cholesterol = 0,
                Sodium = 491,
                Potassium = 115,
                Calcium = 22,
                Iron = 2.4f,
                VitaminA = 0,
                VitaminB1 = 0.2f,
                VitaminB2 = 0.12f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 3
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("a989c8db-7506-467f-8aba-dce042f68eea"), // Chuối
                Calories = 89,
                Protein = 1.1f,
                Carbs = 23,
                Fiber = 2.6f,
                Sugar = 12,
                Fat = 0.3f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.1f,
                Cholesterol = 0,
                Sodium = 1,
                Potassium = 358,
                Calcium = 5,
                Iron = 0.3f,
                VitaminA = 0.03f,
                VitaminB1 = 0.03f,
                VitaminB2 = 0.07f,
                VitaminC = 8.7f,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 4
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("c42e7f00-ea31-430a-ac28-8d6e749b7eca"), // Trứng gà luộc
                Calories = 155,
                Protein = 13f,
                Carbs = 1.1f,
                Fiber = 0,
                Sugar = 1.1f,
                Fat = 10.6f,
                SaturatedFat = 3.3f,
                UnsaturatedFat = 3.6f,
                Cholesterol = 373,
                Sodium = 124,
                Potassium = 126,
                Calcium = 56,
                Iron = 1.8f,
                VitaminA = 0.52f,
                VitaminB1 = 0.04f,
                VitaminB2 = 0.5f,
                VitaminC = 0,
                VitaminD = 1.1f,
                VitaminE = 0.5f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 5
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("021b651c-bb01-4965-95bc-3532fbacad3d"),
                Calories = 42,
                Protein = 3.4f,
                Carbs = 5,
                Fiber = 0,
                Sugar = 5,
                Fat = 1,
                SaturatedFat = 0.6f,
                UnsaturatedFat = 0.4f,
                Cholesterol = 5,
                Sodium = 44,
                Potassium = 150,
                Calcium = 125,
                Iron = 0,
                VitaminA = 0.04f,
                VitaminB1 = 0.04f,
                VitaminB2 = 0.18f,
                VitaminC = 0,
                VitaminD = 0.02f,
                VitaminE = 0.03f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 6
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("8fa26c41-16b2-49f8-a284-856024a5f947"), // Bún bò huế
                Calories = 290,
                Protein = 20,
                Carbs = 30,
                Fiber = 2,
                Sugar = 3,
                Fat = 12,
                SaturatedFat = 4,
                UnsaturatedFat = 6,
                Cholesterol = 50,
                Sodium = 1200,
                Potassium = 450,
                Calcium = 50,
                Iron = 2,
                VitaminA = 0.2f,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.2f,
                VitaminC = 2,
                VitaminD = 0,
                VitaminE = 0.4f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 7
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("1387c20d-27a6-495b-a3a0-efbb715f6430"), // Táo
                Calories = 52,
                Protein = 0.3f,
                Carbs = 14,
                Fiber = 2.4f,
                Sugar = 10,
                Fat = 0.2f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.2f,
                Cholesterol = 0,
                Sodium = 1,
                Potassium = 107,
                Calcium = 6,
                Iron = 0.1f,
                VitaminA = 0.02f,
                VitaminB1 = 0.02f,
                VitaminB2 = 0.03f,
                VitaminC = 4.6f,
                VitaminD = 0,
                VitaminE = 0.18f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 8
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("ab2117f7-9940-44cb-b191-2dfabefac8c8"), // Bún
                Calories = 110,
                Protein = 1.7f,
                Carbs = 25,
                Fiber = 0.9f,
                Sugar = 0,
                Fat = 0.2f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.1f,
                Cholesterol = 0,
                Sodium = 10,
                Potassium = 15,
                Calcium = 4,
                Iron = 0.1f,
                VitaminA = 0,
                VitaminB1 = 0.01f,
                VitaminB2 = 0.01f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 9
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("455bb5ed-ed2c-4172-8831-2b8a08614198"), // Dưa chuột
                Calories = 16,
                Protein = 0.7f,
                Carbs = 3.6f,
                Fiber = 0.5f,
                Sugar = 1.7f,
                Fat = 0.1f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.1f,
                Cholesterol = 0,
                Sodium = 2,
                Potassium = 147,
                Calcium = 16,
                Iron = 0.3f,
                VitaminA = 0.05f,
                VitaminB1 = 0.03f,
                VitaminB2 = 0.03f,
                VitaminC = 2.8f,
                VitaminD = 0,
                VitaminE = 0.03f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 10
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("1140212e-cdb4-4f25-92f6-9b9407a71163"), // Chuối tây
                Calories = 160,
                Protein = 2,
                Carbs = 8.5f,
                Fiber = 6.7f,
                Sugar = 0.7f,
                Fat = 15,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.1f,
                Cholesterol = 0,
                Sodium = 1,
                Potassium = 360,
                Calcium = 5,
                Iron = 0.3f,
                VitaminA = 0.03f,
                VitaminB1 = 0.03f,
                VitaminB2 = 0.07f,
                VitaminC = 8.7f,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 11
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("ff1bc1f2-3515-4dfe-b271-8cabf205bbcf"), // Chuối tiêu
                Calories = 90,
                Protein = 1.1f,
                Carbs = 23,
                Fiber = 2.6f,
                Sugar = 12,
                Fat = 0.3f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.1f,
                Cholesterol = 0,
                Sodium = 1,
                Potassium = 358,
                Calcium = 5,
                Iron = 0.3f,
                VitaminA = 0.03f,
                VitaminB1 = 0.03f,
                VitaminB2 = 0.07f,
                VitaminC = 8.7f,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 12
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("fa0d83ce-d0d7-414f-bd85-e4bc6402c0db"), // Ổi
                Calories = 68,
                Protein = 2.6f,
                Carbs = 14,
                Fiber = 5.4f,
                Sugar = 9,
                Fat = 0.6f,
                SaturatedFat = 0.3f,
                UnsaturatedFat = 0.6f,
                Cholesterol = 0,
                Sodium = 2,
                Potassium = 417,
                Calcium = 18,
                Iron = 0.3f,
                VitaminA = 0.21f,
                VitaminB1 = 0.07f,
                VitaminB2 = 0.04f,
                VitaminC = 228.3f,
                VitaminD = 0,
                VitaminE = 0.73f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 13
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("77fe5e06-7fee-486d-a1a7-c031f2065490"), // Cơm tấm sườn
                Calories = 350,
                Protein = 20,
                Carbs = 40,
                Fiber = 1.5f,
                Sugar = 2,
                Fat = 12,
                SaturatedFat = 6,
                UnsaturatedFat = 8,
                Cholesterol = 70,
                Sodium = 650,
                Potassium = 320,
                Calcium = 30,
                Iron = 2.5f,
                VitaminA = 0.1f,
                VitaminB1 = 0.15f,
                VitaminB2 = 0.08f,
                VitaminC = 2,
                VitaminD = 0,
                VitaminE = 0.4f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 14
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("86d88717-df08-4de6-b86d-870210864b46"), // Thanh long
                Calories = 60,
                Protein = 1.2f,
                Carbs = 13f,
                Fiber = 3,
                Sugar = 8,
                Fat = 0.4f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.3f,
                Cholesterol = 0,
                Sodium = 4,
                Potassium = 150,
                Calcium = 10,
                Iron = 0.3f,
                VitaminA = 0.03f,
                VitaminB1 = 0.04f,
                VitaminB2 = 0.05f,
                VitaminC = 3,
                VitaminD = 0,
                VitaminE = 0.3f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 15
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("a41a3bc6-0f34-409f-9045-0807fbb4469b"), // Bún riêu cua
                Calories = 280,
                Protein = 15f,
                Carbs = 35f,
                Fiber = 2,
                Sugar = 3,
                Fat = 10,
                SaturatedFat = 4,
                UnsaturatedFat = 6,
                Cholesterol = 40,
                Sodium = 850,
                Potassium = 400,
                Calcium = 80,
                Iron = 2.5f,
                VitaminA = 0.2f,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.2f,
                VitaminC = 4,
                VitaminD = 0,
                VitaminE = 0.5f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 16
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("7378ca5f-f1a8-4c23-a019-50af3012526f"), // Bánh bao
                Calories = 220,
                Protein = 7f,
                Carbs = 40f,
                Fiber = 1f,
                Sugar = 5,
                Fat = 3,
                SaturatedFat = 2,
                UnsaturatedFat = 2.5f,
                Cholesterol = 35,
                Sodium = 300,
                Potassium = 100,
                Calcium = 20,
                Iron = 1.2f,
                VitaminA = 0.05f,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.03f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.2f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 17
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"), // Bún thịt nướng
                Calories = 300,
                Protein = 18,
                Carbs = 40,
                Fiber = 2,
                Sugar = 3,
                Fat = 8,
                SaturatedFat = 5,
                UnsaturatedFat = 8,
                Cholesterol = 60,
                Sodium = 700,
                Potassium = 250,
                Calcium = 40,
                Iron = 2,
                VitaminA = 0.2f,
                VitaminB1 = 0.12f,
                VitaminB2 = 0.1f,
                VitaminC = 3,
                VitaminD = 0,
                VitaminE = 0.5f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 18
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("42883b21-4cbd-40ce-850f-b0723f1766fe"), // Cà chua
                Calories = 18,
                Protein = 0.9f,
                Carbs = 3.9f,
                Fiber = 1.2f,
                Sugar = 2.6f,
                Fat = 0.2f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.2f,
                Cholesterol = 0,
                Sodium = 5,
                Potassium = 237,
                Calcium = 10,
                Iron = 0.3f,
                VitaminA = 0.85f,
                VitaminB1 = 0.04f,
                VitaminB2 = 0.02f,
                VitaminC = 13.7f,
                VitaminD = 0,
                VitaminE = 0.5f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 19
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("f6cf96c8-adc3-43e0-af5a-8b19623fed94"), // Xôi mặn
                Calories = 320,
                Protein = 10,
                Carbs = 55,
                Fiber = 1.5f,
                Sugar = 1,
                Fat = 7,
                SaturatedFat = 4,
                UnsaturatedFat = 6,
                Cholesterol = 50,
                Sodium = 500,
                Potassium = 200,
                Calcium = 30,
                Iron = 1.5f,
                VitaminA = 0.1f,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.06f,
                VitaminC = 1,
                VitaminD = 0,
                VitaminE = 0.3f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 20
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("eac10b91-8509-4986-b689-7ee3a3757a18"), // Dưa hấu
                Calories = 30,
                Protein = 0.6f,
                Carbs = 8,
                Fiber = 0.4f,
                Sugar = 6,
                Fat = 0.2f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.2f,
                Cholesterol = 0,
                Sodium = 1,
                Potassium = 112,
                Calcium = 7,
                Iron = 0.2f,
                VitaminA = 0.57f,
                VitaminB1 = 0.03f,
                VitaminB2 = 0.02f,
                VitaminC = 8.1f,
                VitaminD = 0,
                VitaminE = 0.05f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 21
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("dca16637-cf90-402f-921f-5c60e99e4bfa"), // Chả lụa
                Calories = 180,
                Protein = 15,
                Carbs = 7,
                Fiber = 0,
                Sugar = 1,
                Fat = 10,
                SaturatedFat = 7,
                UnsaturatedFat = 9,
                Cholesterol = 80,
                Sodium = 850,
                Potassium = 180,
                Calcium = 40,
                Iron = 1,
                VitaminA = 0,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.06f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.2f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 22
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("a2c5c215-f105-42f9-8b68-3219b5bcc2a9"), // Cơm gạo lứt
                Calories = 110,
                Protein = 2.6f,
                Carbs = 23f,
                Fiber = 1.8f,
                Sugar = 0.4f,
                Fat = 0.9f,
                SaturatedFat = 0.2f,
                UnsaturatedFat = 0.5f,
                Cholesterol = 0,
                Sodium = 1,
                Potassium = 43,
                Calcium = 10,
                Iron = 0.4f,
                VitaminA = 0,
                VitaminB1 = 0.16f,
                VitaminB2 = 0.03f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 23
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("85822a08-7189-4e08-8f55-25c73698af92"), // Xúc xích
                Calories = 290,
                Protein = 12,
                Carbs = 2.3f,
                Fiber = 0,
                Sugar = 1,
                Fat = 25,
                SaturatedFat = 9,
                UnsaturatedFat = 12,
                Cholesterol = 76,
                Sodium = 1020,
                Potassium = 200,
                Calcium = 20,
                Iron = 1.2f,
                VitaminA = 0.03f,
                VitaminB1 = 0.3f,
                VitaminB2 = 0.12f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.4f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 24
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("ddc8d8f2-261b-4c1d-9061-e482d3c8cef3"), // Ức gà
                Calories = 165,
                Protein = 31,
                Carbs = 0,
                Fiber = 0,
                Sugar = 0,
                Fat = 3.6f,
                SaturatedFat = 1,
                UnsaturatedFat = 1.5f,
                Cholesterol = 85,
                Sodium = 74,
                Potassium = 256,
                Calcium = 11,
                Iron = 0.9f,
                VitaminA = 0,
                VitaminB1 = 0.06f,
                VitaminB2 = 0.08f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.3f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 25
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"), // Bắp luộc
                Calories = 96,
                Protein = 3.4f,
                Carbs = 21,
                Fiber = 2.4f,
                Sugar = 4.5f,
                Fat = 1.5f,
                SaturatedFat = 0.2f,
                UnsaturatedFat = 0.8f,
                Cholesterol = 0,
                Sodium = 1,
                Potassium = 270,
                Calcium = 2,
                Iron = 0.5f,
                VitaminA = 0.02f,
                VitaminB1 = 0.15f,
                VitaminB2 = 0.1f,
                VitaminC = 6.8f,
                VitaminD = 0,
                VitaminE = 0.2f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 26
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("a17722bf-899e-40e9-8e54-ae2fc8a34f44"), // Sữa chua
                Calories = 60,
                Protein = 3.5f,
                Carbs = 5,
                Fiber = 0,
                Sugar = 4,
                Fat = 3,
                SaturatedFat = 1,
                UnsaturatedFat = 0.6f,
                Cholesterol = 5,
                Sodium = 36,
                Potassium = 141,
                Calcium = 110,
                Iron = 0,
                VitaminA = 0.05f,
                VitaminB1 = 0.04f,
                VitaminB2 = 0.14f,
                VitaminC = 0,
                VitaminD = 0.02f,
                VitaminE = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 27
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("19bbab17-91c6-410f-b566-b509d067e76e"), // Đậu hũ
                Calories = 80,
                Protein = 8f,
                Carbs = 2,
                Fiber = 1.2f,
                Sugar = 0.7f,
                Fat = 4.5f,
                SaturatedFat = 0.7f,
                UnsaturatedFat = 2.4f,
                Cholesterol = 0,
                Sodium = 7,
                Potassium = 121,
                Calcium = 201,
                Iron = 1.6f,
                VitaminA = 0,
                VitaminB1 = 0.04f,
                VitaminB2 = 0.03f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.02f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 28
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("21a4b410-e26d-444b-8b99-bf8b490e5dcf"), // Bánh bao chay
                Calories = 190,
                Protein = 5,
                Carbs = 38,
                Fiber = 1.5f,
                Sugar = 4,
                Fat = 2,
                SaturatedFat = 0.5f,
                UnsaturatedFat = 1,
                Cholesterol = 0,
                Sodium = 300,
                Potassium = 100,
                Calcium = 20,
                Iron = 1,
                VitaminA = 0.05f,
                VitaminB1 = 0.06f,
                VitaminB2 = 0.03f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 29
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("de097440-db5c-4d91-bd55-76618d70599d"), // Nước cam
                Calories = 45,
                Protein = 0.7f,
                Carbs = 10.4f,
                Fiber = 0.2f,
                Sugar = 8.3f,
                Fat = 0.2f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.2f,
                Cholesterol = 0,
                Sodium = 1,
                Potassium = 200,
                Calcium = 11,
                Iron = 0.1f,
                VitaminA = 0.02f,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.02f,
                VitaminC = 50f,
                VitaminD = 0,
                VitaminE = 0.02f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 30
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("74181cd5-4b0b-48a9-9042-16d8789483d4"), // Cà rốt
                Calories = 41,
                Protein = 0.9f,
                Carbs = 10,
                Fiber = 2.8f,
                Sugar = 4.7f,
                Fat = 0.2f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.2f,
                Cholesterol = 0,
                Sodium = 69,
                Potassium = 320,
                Calcium = 33,
                Iron = 0.3f,
                VitaminA = 1.69f,
                VitaminB1 = 0.04f,
                VitaminB2 = 0.03f,
                VitaminC = 5.9f,
                VitaminD = 0,
                VitaminE = 0.66f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 31
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"), // Cháo lòng
                Calories = 150,
                Protein = 10,
                Carbs = 20,
                Fiber = 0.5f,
                Sugar = 0.5f,
                Fat = 3,
                SaturatedFat = 2,
                UnsaturatedFat = 2.5f,
                Cholesterol = 70,
                Sodium = 500,
                Potassium = 200,
                Calcium = 30,
                Iron = 1.5f,
                VitaminA = 0.1f,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.03f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 32
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("65c7b876-87e2-4307-ab76-c72ca277b78c"), // Bánh mì sandwich
                Calories = 280,
                Protein = 10,
                Carbs = 45,
                Fiber = 3,
                Sugar = 6,
                Fat = 5,
                SaturatedFat = 0.5f,
                UnsaturatedFat = 0.8f,
                Cholesterol = 0,
                Sodium = 491,
                Potassium = 115,
                Calcium = 22,
                Iron = 2.4f,
                VitaminA = 0,
                VitaminB1 = 0.2f,
                VitaminB2 = 0.12f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 33
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("a47b1646-3576-46f0-a3b6-763a9c3f889b"), // Nước dừa
                Calories = 19,
                Protein = 0.7f,
                Carbs = 3.7f,
                Fiber = 1.1f,
                Sugar = 2.6f,
                Fat = 0.2f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.2f,
                Cholesterol = 0,
                Sodium = 11,
                Potassium = 250,
                Calcium = 24,
                Iron = 0.3f,
                VitaminA = 0,
                VitaminB1 = 0.03f,
                VitaminB2 = 0.02f,
                VitaminC = 2.4f,
                VitaminD = 0,
                VitaminE = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 34
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("a3074169-6441-49cc-9ea7-79e240f6dda3"), // Xoài
                Calories = 65,
                Protein = 0.5f,
                Carbs = 17,
                Fiber = 1.8f,
                Sugar = 14,
                Fat = 0.3f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.3f,
                Cholesterol = 0,
                Sodium = 1,
                Potassium = 168,
                Calcium = 11,
                Iron = 0.2f,
                VitaminA = 0.54f,
                VitaminB1 = 0.03f,
                VitaminB2 = 0.04f,
                VitaminC = 36.4f,
                VitaminD = 0,
                VitaminE = 0.9f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 35
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("0a47589f-d177-46f9-8a10-63fd6da9b611"), // Rau muống
                Calories = 20,
                Protein = 2.6f,
                Carbs = 3,
                Fiber = 2,
                Sugar = 0.8f,
                Fat = 0.2f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.4f,
                Cholesterol = 0,
                Sodium = 113,
                Potassium = 312,
                Calcium = 77,
                Iron = 1.5f,
                VitaminA = 6.3f,
                VitaminB1 = 0.04f,
                VitaminB2 = 0.09f,
                VitaminC = 55,
                VitaminD = 0,
                VitaminE = 1.5f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 36
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("48113ca0-a1e7-4181-85fa-be6538a70873"), // Bún chả
                Calories = 300,
                Protein = 18,
                Carbs = 35,
                Fiber = 2,
                Sugar = 3,
                Fat = 12,
                SaturatedFat = 5,
                UnsaturatedFat = 7,
                Cholesterol = 60,
                Sodium = 800,
                Potassium = 250,
                Calcium = 40,
                Iron = 2,
                VitaminA = 0.1f,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.08f,
                VitaminC = 3,
                VitaminD = 0,
                VitaminE = 0.3f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 37
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("f77e03de-4ed3-41ca-8fa1-0a4947c67384"), // Sữa hộp Milo
                Calories = 80,
                Protein = 3.2f,
                Carbs = 12,
                Fiber = 0.7f,
                Sugar = 9,
                Fat = 2,
                SaturatedFat = 1,
                UnsaturatedFat = 1.5f,
                Cholesterol = 5,
                Sodium = 50,
                Potassium = 200,
                Calcium = 120,
                Iron = 0.6f,
                VitaminA = 0.2f,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.1f,
                VitaminC = 2,
                VitaminD = 0.1f,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 38
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("d4df84f2-2d79-41e6-b313-28e89e3785ba"), // Bánh canh
                Calories = 250,
                Protein = 8,
                Carbs = 45,
                Fiber = 1.5f,
                Sugar = 2,
                Fat = 3,
                SaturatedFat = 2,
                UnsaturatedFat = 2.5f,
                Cholesterol = 20,
                Sodium = 700,
                Potassium = 250,
                Calcium = 40,
                Iron = 1.5f,
                VitaminA = 0.1f,
                VitaminB1 = 0.08f,
                VitaminB2 = 0.06f,
                VitaminC = 1,
                VitaminD = 0,
                VitaminE = 0.2f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 39
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"), // Hủ tíu
                Calories = 280,
                Protein = 25,
                Carbs = 70,
                Fiber = 1.5f,
                Sugar = 1,
                Fat = 12,
                SaturatedFat = 2.5f,
                UnsaturatedFat = 4.5f,
                Cholesterol = 30,
                Sodium = 850,
                Potassium = 250,
                Calcium = 40,
                Iron = 1.2f,
                VitaminA = 0.1f,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.1f,
                VitaminC = 3,
                VitaminD = 0,
                VitaminE = 0.2f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 40
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"), // Cà phê
                Calories = 2,
                Protein = 0.2f,
                Carbs = 0,
                Fiber = 0,
                Sugar = 0,
                Fat = 0,
                SaturatedFat = 0,
                UnsaturatedFat = 0,
                Cholesterol = 0,
                Sodium = 5,
                Potassium = 49,
                Calcium = 2,
                Iron = 0,
                VitaminA = 0,
                VitaminB1 = 0,
                VitaminB2 = 0,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 41
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"), // Cà phê sữa
                Calories = 70,
                Protein = 1.5f,
                Carbs = 10,
                Fiber = 0,
                Sugar = 8,
                Fat = 2.5f,
                SaturatedFat = 2,
                UnsaturatedFat = 1.5f,
                Cholesterol = 10,
                Sodium = 40,
                Potassium = 80,
                Calcium = 60,
                Iron = 0.2f,
                VitaminA = 0.02f,
                VitaminB1 = 0.04f,
                VitaminB2 = 0.06f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 42
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"), // Sữa đậu nành
                Calories = 33,
                Protein = 3.3f,
                Carbs = 2,
                Fiber = 0.5f,
                Sugar = 1,
                Fat = 1.8f,
                SaturatedFat = 0.2f,
                UnsaturatedFat = 0.8f,
                Cholesterol = 0,
                Sodium = 51,
                Potassium = 118,
                Calcium = 25,
                Iron = 0.7f,
                VitaminA = 0.02f,
                VitaminB1 = 0.03f,
                VitaminB2 = 0.04f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 43
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("83e6e455-3ae1-4f5c-8e44-9a5ae79ee31b"), // Thịt kho tiêu
                Calories = 250,
                Protein = 25,
                Carbs = 5,
                Fiber = 0.5f,
                Sugar = 2,
                Fat = 15,
                SaturatedFat = 9,
                UnsaturatedFat = 12,
                Cholesterol = 75,
                Sodium = 900,
                Potassium = 400,
                Calcium = 30,
                Iron = 2,
                VitaminA = 0.04f,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.06f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.2f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 44
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("77243d82-a633-4fe8-84c9-61a4b6cd4428"), // Bún xào
                Calories = 280,
                Protein = 10,
                Carbs = 45,
                Fiber = 2,
                Sugar = 3,
                Fat = 8,
                SaturatedFat = 4,
                UnsaturatedFat = 6,
                Cholesterol = 20,
                Sodium = 500,
                Potassium = 300,
                Calcium = 50,
                Iron = 2,
                VitaminA = 0.2f,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.08f,
                VitaminC = 3,
                VitaminD = 0,
                VitaminE = 0.3f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 45
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("3222413a-e385-4a0b-9d07-2af7b0cb4276"), // Cải thìa
                Calories = 13,
                Protein = 1.5f,
                Carbs = 2.2f,
                Fiber = 1,
                Sugar = 1.2f,
                Fat = 0.2f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.2f,
                Cholesterol = 0,
                Sodium = 65,
                Potassium = 176,
                Calcium = 105,
                Iron = 0.8f,
                VitaminA = 2.6f,
                VitaminB1 = 0.04f,
                VitaminB2 = 0.07f,
                VitaminC = 45,
                VitaminD = 0,
                VitaminE = 0.15f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 46
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("e0eec003-8384-412c-a307-b0185afdb0c7"), // Xôi bắp
                Calories = 220,
                Protein = 5,
                Carbs = 45,
                Fiber = 2,
                Sugar = 6,
                Fat = 2,
                SaturatedFat = 2,
                UnsaturatedFat = 3,
                Cholesterol = 0,
                Sodium = 250,
                Potassium = 200,
                Calcium = 15,
                Iron = 1,
                VitaminA = 0.03f,
                VitaminB1 = 0.15f,
                VitaminB2 = 0.1f,
                VitaminC = 3,
                VitaminD = 0,
                VitaminE = 0.2f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 47
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"), // Phở bò tái
                Calories = 300,
                Protein = 20,
                Carbs = 40,
                Fiber = 2,
                Sugar = 3,
                Fat = 8,
                SaturatedFat = 4,
                UnsaturatedFat = 6,
                Cholesterol = 60,
                Sodium = 900,
                Potassium = 350,
                Calcium = 40,
                Iron = 3,
                VitaminA = 0.1f,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.08f,
                VitaminC = 1,
                VitaminD = 0,
                VitaminE = 0.2f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 48
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("da89578e-9470-4b18-af4f-0bdcc011882f"), // Phở gà
                Calories = 280,
                Protein = 18,
                Carbs = 40,
                Fiber = 1.5f,
                Sugar = 2,
                Fat = 6,
                SaturatedFat = 3,
                UnsaturatedFat = 5,
                Cholesterol = 55,
                Sodium = 850,
                Potassium = 320,
                Calcium = 35,
                Iron = 2.5f,
                VitaminA = 0.08f,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.07f,
                VitaminC = 1,
                VitaminD = 0,
                VitaminE = 0.3f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 49
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("37a66f5c-437f-4520-90ec-4376e0093061"), // Nước chanh
                Calories = 20,
                Protein = 0.1f,
                Carbs = 6,
                Fiber = 0.1f,
                Sugar = 5,
                Fat = 0.1f,
                SaturatedFat = 0,
                UnsaturatedFat = 0,
                Cholesterol = 0,
                Sodium = 2,
                Potassium = 15,
                Calcium = 3,
                Iron = 0.1f,
                VitaminA = 0,
                VitaminB1 = 0.02f,
                VitaminB2 = 0.02f,
                VitaminC = 20f,
                VitaminD = 0,
                VitaminE = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 50
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"), // Bánh mì thịt trứng
                Calories = 350,
                Protein = 15,
                Carbs = 40,
                Fiber = 2,
                Sugar = 4,
                Fat = 15,
                SaturatedFat = 5,
                UnsaturatedFat = 7,
                Cholesterol = 80,
                Sodium = 600,
                Potassium = 200,
                Calcium = 30,
                Iron = 2,
                VitaminA = 0.04f,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.08f,
                VitaminC = 2,
                VitaminD = 0,
                VitaminE = 0.3f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 51
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("16bf44f2-711d-4b64-a409-995c6b0c13ce"), // Quýt
                Calories = 53,
                Protein = 0.8f,
                Carbs = 13,
                Fiber = 1.8f,
                Sugar = 10.5f,
                Fat = 0.3f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.3f,
                Cholesterol = 0,
                Sodium = 2,
                Potassium = 166,
                Calcium = 37,
                Iron = 0.1f,
                VitaminA = 0.34f,
                VitaminB1 = 0.06f,
                VitaminB2 = 0.03f,
                VitaminC = 26.7f,
                VitaminD = 0,
                VitaminE = 0.2f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 52
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("fa445aa4-7b0d-4d47-8ba7-f919dd123637"), // Sữa chua nha đam
                Calories = 90,
                Protein = 3,
                Carbs = 15,
                Fiber = 1,
                Sugar = 12,
                Fat = 2,
                SaturatedFat = 1,
                UnsaturatedFat = 0.5f,
                Cholesterol = 5,
                Sodium = 35,
                Potassium = 140,
                Calcium = 110,
                Iron = 0,
                VitaminA = 0.05f,
                VitaminB1 = 0.04f,
                VitaminB2 = 0.14f,
                VitaminC = 0,
                VitaminD = 0.02f,
                VitaminE = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            // #region Nutrition 53
            // new Nutrition
            // {
            //     NutritionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("05cfce09-72b4-482d-adcd-c0718015be3d"), // Bánh xèo
            //     Calories = 320,
            //     Protein = 10,
            //     Carbs = 30,
            //     Fiber = 2,
            //     Sugar = 3,
            //     Fat = 18,
            //     SaturatedFat = 3,
            //     UnsaturatedFat = 5,
            //     Cholesterol = 50,
            //     Sodium = 400,
            //     Potassium = 150,
            //     Calcium = 30,
            //     Iron = 1.2f,
            //     VitaminA = 0.02f,
            //     VitaminB1 = 0.08f,
            //     VitaminB2 = 0.05f,
            //     VitaminC = 2,
            //     VitaminD = 0,
            //     VitaminE = 0.2f,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            // },
            // #endregion

            #region Nutrition 54
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("58fe08ca-5c52-4847-800e-b9970c3782f0"), // Ớt chuông
                Calories = 31,
                Protein = 1,
                Carbs = 6,
                Fiber = 2.1f,
                Sugar = 4.2f,
                Fat = 0.3f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.2f,
                Cholesterol = 0,
                Sodium = 3,
                Potassium = 175,
                Calcium = 10,
                Iron = 0.3f,
                VitaminA = 0.93f,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.04f,
                VitaminC = 80f,
                VitaminD = 0,
                VitaminE = 0.37f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 55
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("1d0feb2f-0735-4333-87ce-09e22304ad0d"), // Nấm kim châm
                Calories = 27,
                Protein = 2.2f,
                Carbs = 5,
                Fiber = 2.5f,
                Sugar = 1,
                Fat = 0.3f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.2f,
                Cholesterol = 0,
                Sodium = 3,
                Potassium = 359,
                Calcium = 3,
                Iron = 0.4f,
                VitaminA = 0,
                VitaminB1 = 0.11f,
                VitaminB2 = 0.1f,
                VitaminC = 2.1f,
                VitaminD = 0,
                VitaminE = 0.01f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            // #region Nutrition 56
            // new Nutrition
            // {
            //     NutritionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("a782e478-d5c5-4da6-b809-180b48ad08c3"), // Lòng đỏ trứng gà
            //     Calories = 322,
            //     Protein = 15.9f,
            //     Carbs = 3.6f,
            //     Fiber = 0,
            //     Sugar = 0.6f,
            //     Fat = 26.5f,
            //     SaturatedFat = 8.7f,
            //     UnsaturatedFat = 11.2f,
            //     Cholesterol = 1085,
            //     Sodium = 48,
            //     Potassium = 109,
            //     Calcium = 129,
            //     Iron = 2.7f,
            //     VitaminA = 0.53f,
            //     VitaminB1 = 0.08f,
            //     VitaminB2 = 0.37f,
            //     VitaminC = 0,
            //     VitaminD = 2,
            //     VitaminE = 2.7f,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            // },
            // #endregion

            // #region Nutrition 57
            // new Nutrition
            // {
            //     NutritionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("f41484a3-c7df-4530-b7d2-060390103985"), // Lòng trắng trứng gà
            //     Calories = 17,
            //     Protein = 3.6f,
            //     Carbs = 0.2f,
            //     Fiber = 0,
            //     Sugar = 0.2f,
            //     Fat = 0.1f,
            //     SaturatedFat = 0,
            //     UnsaturatedFat = 0.1f,
            //     Cholesterol = 0,
            //     Sodium = 55,
            //     Potassium = 54,
            //     Calcium = 2,
            //     Iron = 0,
            //     VitaminA = 0,
            //     VitaminB1 = 0.01f,
            //     VitaminB2 = 0.15f,
            //     VitaminC = 0,
            //     VitaminD = 0,
            //     VitaminE = 0,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            // },
            // #endregion

            #region Nutrition 58
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"), // Hoành thánh
                Calories = 240,
                Protein = 8,
                Carbs = 30,
                Fiber = 1,
                Sugar = 1,
                Fat = 10,
                SaturatedFat = 3,
                UnsaturatedFat = 3.5f,
                Cholesterol = 45,
                Sodium = 480,
                Potassium = 150,
                Calcium = 20,
                Iron = 1.5f,
                VitaminA = 0.1f,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.04f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 59
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("e7468877-17ed-4bb9-9956-5e3cf6a58bde"), // Tôm
                Calories = 99,
                Protein = 24,
                Carbs = 0,
                Fiber = 0,
                Sugar = 0,
                Fat = 1.1f,
                SaturatedFat = 0.2f,
                UnsaturatedFat = 0.6f,
                Cholesterol = 189,
                Sodium = 111,
                Potassium = 259,
                Calcium = 70,
                Iron = 0.3f,
                VitaminA = 0.02f,
                VitaminB1 = 0.02f,
                VitaminB2 = 0.11f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.6f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 60
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("40f03f23-9341-4343-9bf8-fdfdb3b9f236"), // Đậu bắp
                Calories = 33,
                Protein = 1.9f,
                Carbs = 7,
                Fiber = 3.2f,
                Sugar = 1.5f,
                Fat = 0.2f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.2f,
                Cholesterol = 0,
                Sodium = 7,
                Potassium = 299,
                Calcium = 81,
                Iron = 0.8f,
                VitaminA = 0.36f,
                VitaminB1 = 0.02f,
                VitaminB2 = 0.04f,
                VitaminC = 21,
                VitaminD = 0,
                VitaminE = 0.27f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 61
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("dfa879e8-d77d-4199-b07b-16b37f1cbde1"), // Bánh canh cua
                Calories = 260,
                Protein = 12,
                Carbs = 40,
                Fiber = 1.5f,
                Sugar = 2,
                Fat = 5,
                SaturatedFat = 4,
                UnsaturatedFat = 6,
                Cholesterol = 70,
                Sodium = 900,
                Potassium = 350,
                Calcium = 80,
                Iron = 2,
                VitaminA = 0.1f,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.1f,
                VitaminC = 3,
                VitaminD = 0,
                VitaminE = 0.3f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 62
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("c16aac77-64ee-476d-a646-a3029da83e41"), // Bánh bèo
                Calories = 180,
                Protein = 3.5f,
                Carbs = 35,
                Fiber = 0.5f,
                Sugar = 1,
                Fat = 3,
                SaturatedFat = 1,
                UnsaturatedFat = 1.5f,
                Cholesterol = 10,
                Sodium = 250,
                Potassium = 100,
                Calcium = 20,
                Iron = 0.4f,
                VitaminA = 0.01f,
                VitaminB1 = 0.04f,
                VitaminB2 = 0.02f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.05f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 63
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"), // Bún mắm
                Calories = 290,
                Protein = 15,
                Carbs = 45,
                Fiber = 2,
                Sugar = 3,
                Fat = 6,
                SaturatedFat = 4,
                UnsaturatedFat = 6,
                Cholesterol = 50,
                Sodium = 1200,
                Potassium = 300,
                Calcium = 50,
                Iron = 2,
                VitaminA = 0.1f,
                VitaminB1 = 0.08f,
                VitaminB2 = 0.1f,
                VitaminC = 4,
                VitaminD = 0,
                VitaminE = 0.2f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 64
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("244e7e03-baaa-4dc4-aa10-d9d0dac410fe"), // Cải thảo
                Calories = 16,
                Protein = 1.2f,
                Carbs = 3.2f,
                Fiber = 1.2f,
                Sugar = 1.8f,
                Fat = 0.2f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.2f,
                Cholesterol = 0,
                Sodium = 13,
                Potassium = 252,
                Calcium = 40,
                Iron = 0.5f,
                VitaminA = 0.37f,
                VitaminB1 = 0.04f,
                VitaminB2 = 0.04f,
                VitaminC = 36.6f,
                VitaminD = 0,
                VitaminE = 0.12f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 65
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("51061170-597d-4289-a021-1e7dde88331f"), // Thịt vịt
                Calories = 240,
                Protein = 19,
                Carbs = 0,
                Fiber = 0,
                Sugar = 0,
                Fat = 19,
                SaturatedFat = 8.5f,
                UnsaturatedFat = 12.5f,
                Cholesterol = 76,
                Sodium = 63,
                Potassium = 205,
                Calcium = 11,
                Iron = 2.7f,
                VitaminA = 0.06f,
                VitaminB1 = 0.15f,
                VitaminB2 = 0.23f,
                VitaminC = 0,
                VitaminD = 0.02f,
                VitaminE = 0.3f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 66
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("c137f014-34c2-4f0a-be52-7c2a5c64abae"), // Thịt gà
                Calories = 165,
                Protein = 31,
                Carbs = 0,
                Fiber = 0,
                Sugar = 0,
                Fat = 3.6f,
                SaturatedFat = 3.8f,
                UnsaturatedFat = 7,
                Cholesterol = 88,
                Sodium = 82,
                Potassium = 223,
                Calcium = 12,
                Iron = 1.2f,
                VitaminA = 0.02f,
                VitaminB1 = 0.07f,
                VitaminB2 = 0.13f,
                VitaminC = 0,
                VitaminD = 0.02f,
                VitaminE = 0.3f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 67
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("5ff26461-880d-4b94-bfd0-e8badc77fe33"), // Thịt kho trứng
                Calories = 280,
                Protein = 22,
                Carbs = 5,
                Fiber = 0,
                Sugar = 3,
                Fat = 18,
                SaturatedFat = 8,
                UnsaturatedFat = 12,
                Cholesterol = 120,
                Sodium = 800,
                Potassium = 300,
                Calcium = 30,
                Iron = 2.5f,
                VitaminA = 0.03f,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.06f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.2f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 68
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("73016f70-ebb4-4583-aa12-7f3f4633ada4"), // Sườn non
                Calories = 330,
                Protein = 27,
                Carbs = 0,
                Fiber = 0,
                Sugar = 0,
                Fat = 25,
                SaturatedFat = 9,
                UnsaturatedFat = 10f,
                Cholesterol = 100,
                Sodium = 75,
                Potassium = 200,
                Calcium = 10,
                Iron = 1.5f,
                VitaminA = 0,
                VitaminB1 = 0.08f,
                VitaminB2 = 0.05f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 69
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("0455b535-2662-43aa-bca2-3e75595fb181"), // Thịt heo băm
                Calories = 240,
                Protein = 17,
                Carbs = 0,
                Fiber = 0,
                Sugar = 0,
                Fat = 20,
                SaturatedFat = 7,
                UnsaturatedFat = 10f,
                Cholesterol = 75,
                Sodium = 65,
                Potassium = 220,
                Calcium = 8,
                Iron = 1.3f,
                VitaminA = 0,
                VitaminB1 = 0.08f,
                VitaminB2 = 0.05f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 70
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("d30f804f-c59b-4a59-bf4c-5196b302d1ed"), // Cơm chiên trứng
                Calories = 190,
                Protein = 5,
                Carbs = 30,
                Fiber = 0.5f,
                Sugar = 0.5f,
                Fat = 5,
                SaturatedFat = 2,
                UnsaturatedFat = 4,
                Cholesterol = 70,
                Sodium = 450,
                Potassium = 100,
                Calcium = 20,
                Iron = 1,
                VitaminA = 0.03f,
                VitaminB1 = 0.04f,
                VitaminB2 = 0.05f,
                VitaminC = 2,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 71
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("6e12f6cb-6695-4c7a-bfb0-cd4936ee1782"), // Cháo sườn
                Calories = 130,
                Protein = 8,
                Carbs = 20,
                Fiber = 0.5f,
                Sugar = 0.5f,
                Fat = 2.5f,
                SaturatedFat = 2,
                UnsaturatedFat = 3,
                Cholesterol = 30,
                Sodium = 300,
                Potassium = 150,
                Calcium = 20,
                Iron = 1.2f,
                VitaminA = 0.02f,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.04f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 72
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"), // Bánh bột lọc
                Calories = 170,
                Protein = 2,
                Carbs = 35,
                Fiber = 0.5f,
                Sugar = 0.5f,
                Fat = 2,
                SaturatedFat = 1,
                UnsaturatedFat = 1.5f,
                Cholesterol = 20,
                Sodium = 250,
                Potassium = 100,
                Calcium = 10,
                Iron = 0.4f,
                VitaminA = 0.02f,
                VitaminB1 = 0.02f,
                VitaminB2 = 0.02f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 73
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"), // Bánh bao xá xíu
                Calories = 250,
                Protein = 10,
                Carbs = 38,
                Fiber = 1,
                Sugar = 4,
                Fat = 6,
                SaturatedFat = 2,
                UnsaturatedFat = 2.5f,
                Cholesterol = 30,
                Sodium = 300,
                Potassium = 100,
                Calcium = 20,
                Iron = 1.2f,
                VitaminA = 0.01f,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.03f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 74
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("faf19891-525a-4308-9222-992e83de7ce7"), // Cá hồi
                Calories = 206,
                Protein = 22,
                Carbs = 0,
                Fiber = 0,
                Sugar = 0,
                Fat = 13,
                SaturatedFat = 3.1f,
                UnsaturatedFat = 7.5f,
                Cholesterol = 55,
                Sodium = 59,
                Potassium = 363,
                Calcium = 9,
                Iron = 0.5f,
                VitaminA = 0.03f,
                VitaminB1 = 0.2f,
                VitaminB2 = 0.4f,
                VitaminC = 0,
                VitaminD = 0.38f,
                VitaminE = 0.5f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 75
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("30355638-a0e2-4126-93ae-beb7aa9b5758"), // Khoai lang
                Calories = 86,
                Protein = 1.6f,
                Carbs = 20,
                Fiber = 3,
                Sugar = 4.2f,
                Fat = 0.1f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.1f,
                Cholesterol = 0,
                Sodium = 55,
                Potassium = 337,
                Calcium = 30,
                Iron = 0.6f,
                VitaminA = 0.96f,
                VitaminB1 = 0.08f,
                VitaminB2 = 0.03f,
                VitaminC = 2.4f,
                VitaminD = 0,
                VitaminE = 0.26f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 76
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("8893c58d-06fd-4c34-9e77-2f50779642dd"), // Khoai tây
                Calories = 77,
                Protein = 2,
                Carbs = 17,
                Fiber = 2.2f,
                Sugar = 0.8f,
                Fat = 0.1f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.1f,
                Cholesterol = 0,
                Sodium = 6,
                Potassium = 425,
                Calcium = 11,
                Iron = 0.8f,
                VitaminA = 0.01f,
                VitaminB1 = 0.11f,
                VitaminB2 = 0.03f,
                VitaminC = 19.7f,
                VitaminD = 0,
                VitaminE = 0.01f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 77
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"), // Hành tây
                Calories = 40,
                Protein = 1.1f,
                Carbs = 9.3f,
                Fiber = 1.7f,
                Sugar = 4.2f,
                Fat = 0.1f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.1f,
                Cholesterol = 0,
                Sodium = 4,
                Potassium = 146,
                Calcium = 23,
                Iron = 0.2f,
                VitaminA = 0.01f,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.02f,
                VitaminC = 7.4f,
                VitaminD = 0,
                VitaminE = 0.02f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 78
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("80ba2672-d26a-4703-98f0-d246a50f92f1"), // Bầu
                Calories = 20,
                Protein = 0.8f,
                Carbs = 4.5f,
                Fiber = 1.2f,
                Sugar = 2.5f,
                Fat = 0.1f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.1f,
                Cholesterol = 0,
                Sodium = 1,
                Potassium = 170,
                Calcium = 18,
                Iron = 0.3f,
                VitaminA = 0.03f,
                VitaminB1 = 0.02f,
                VitaminB2 = 0.02f,
                VitaminC = 10f,
                VitaminD = 0,
                VitaminE = 0.01f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 79
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("a53672e7-8593-4779-bd02-9f02ae81f915"), // Mực
                Calories = 92,
                Protein = 15.6f,
                Carbs = 3.1f,
                Fiber = 0,
                Sugar = 0,
                Fat = 1.5f,
                SaturatedFat = 0.5f,
                UnsaturatedFat = 0.7f,
                Cholesterol = 233,
                Sodium = 44,
                Potassium = 279,
                Calcium = 21,
                Iron = 0.7f,
                VitaminA = 0.01f,
                VitaminB1 = 0.02f,
                VitaminB2 = 0.06f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.01f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 80
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("98006e54-c44e-4a81-aa99-d4bb95bfb89d"), // Đậu que
                Calories = 31,
                Protein = 1.8f,
                Carbs = 7,
                Fiber = 2.7f,
                Sugar = 3.3f,
                Fat = 0.1f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.1f,
                Cholesterol = 0,
                Sodium = 6,
                Potassium = 211,
                Calcium = 37,
                Iron = 1,
                VitaminA = 0.69f,
                VitaminB1 = 0.02f,
                VitaminB2 = 0.1f,
                VitaminC = 12.2f,
                VitaminD = 0,
                VitaminE = 0.41f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 81
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("fb7d87aa-2bb8-4065-bd31-b54239057405"), // Bánh ướt
                Calories = 160,
                Protein = 3,
                Carbs = 35,
                Fiber = 0.5f,
                Sugar = 1,
                Fat = 1.5f,
                SaturatedFat = 0.5f,
                UnsaturatedFat = 1,
                Cholesterol = 0,
                Sodium = 300,
                Potassium = 50,
                Calcium = 10,
                Iron = 0.5f,
                VitaminA = 0,
                VitaminB1 = 0.01f,
                VitaminB2 = 0.01f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 82
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("f0132626-5535-4f30-9af4-7e89e086aaaf"), // Bánh cuốn
                Calories = 170,
                Protein = 4,
                Carbs = 35,
                Fiber = 0.8f,
                Sugar = 1.2f,
                Fat = 2,
                SaturatedFat = 1,
                UnsaturatedFat = 2,
                Cholesterol = 20,
                Sodium = 350,
                Potassium = 80,
                Calcium = 20,
                Iron = 0.8f,
                VitaminA = 0.01f,
                VitaminB1 = 0.02f,
                VitaminB2 = 0.02f,
                VitaminC = 1,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 83
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("7268b449-cb54-4f3d-9709-f42b9966d707"), // Canh bún
                Calories = 280,
                Protein = 15f,
                Carbs = 35f,
                Fiber = 2,
                Sugar = 3,
                Fat = 10,
                SaturatedFat = 4,
                UnsaturatedFat = 6,
                Cholesterol = 40,
                Sodium = 850,
                Potassium = 400,
                Calcium = 80,
                Iron = 2.5f,
                VitaminA = 0.2f,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.2f,
                VitaminC = 4,
                VitaminD = 0,
                VitaminE = 0.5f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 84
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("7b8500af-d730-4138-9617-cba352faed4a"), // Vải
                Calories = 66,
                Protein = 0.8f,
                Carbs = 16.5f,
                Fiber = 1.3f,
                Sugar = 15.2f,
                Fat = 0.4f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.4f,
                Cholesterol = 0,
                Sodium = 1,
                Potassium = 171,
                Calcium = 5,
                Iron = 0.3f,
                VitaminA = 0.02f,
                VitaminB1 = 0.01f,
                VitaminB2 = 0.07f,
                VitaminC = 71.5f,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 85
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("dd1482e7-b3dd-4b17-80f6-5618a640c671"), // Cá khô
                Calories = 270,
                Protein = 58,
                Carbs = 0,
                Fiber = 0,
                Sugar = 0,
                Fat = 6,
                SaturatedFat = 0.3f,
                UnsaturatedFat = 0.5f,
                Cholesterol = 152,
                Sodium = 702,
                Potassium = 684,
                Calcium = 500,
                Iron = 2.8f,
                VitaminA = 0.04f,
                VitaminB1 = 0.12f,
                VitaminB2 = 0.1f,
                VitaminC = 0,
                VitaminD = 0.6f,
                VitaminE = 0.2f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 86
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("628d87df-0bde-417d-b8b5-5f8f5536410b"), // Nấm đùi gà
                Calories = 35,
                Protein = 2.2f,
                Carbs = 6.5f,
                Fiber = 2.5f,
                Sugar = 0,
                Fat = 0.5f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.2f,
                Cholesterol = 0,
                Sodium = 3,
                Potassium = 300,
                Calcium = 5,
                Iron = 0.3f,
                VitaminA = 0,
                VitaminB1 = 0.06f,
                VitaminB2 = 0.07f,
                VitaminC = 0.5f,
                VitaminD = 0.02f,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 87
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("fc85f2de-9aae-4ff4-a829-e01662a42976"), // Mướp
                Calories = 15,
                Protein = 0.8f,
                Carbs = 3.4f,
                Fiber = 1.2f,
                Sugar = 1.8f,
                Fat = 0.1f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.1f,
                Cholesterol = 0,
                Sodium = 3,
                Potassium = 140,
                Calcium = 18,
                Iron = 0.2f,
                VitaminA = 0.03f,
                VitaminB1 = 0.03f,
                VitaminB2 = 0.04f,
                VitaminC = 10f,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 88
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("ef8b0ee3-a4d5-4883-af63-33c83d102bea"), // Bánh bao trứng cút
                Calories = 240,
                Protein = 9,
                Carbs = 38,
                Fiber = 1,
                Sugar = 3,
                Fat = 5,
                SaturatedFat = 2.5f,
                UnsaturatedFat = 3.5f,
                Cholesterol = 60,
                Sodium = 350,
                Potassium = 120,
                Calcium = 30,
                Iron = 1.2f,
                VitaminA = 0.02f,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.04f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 89
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("9122357a-179f-45f4-9106-67eea24d48ab"), // Trà tắc
                Calories = 30,
                Protein = 0,
                Carbs = 7.5f,
                Fiber = 0,
                Sugar = 7,
                Fat = 0,
                SaturatedFat = 0,
                UnsaturatedFat = 0,
                Cholesterol = 0,
                Sodium = 3,
                Potassium = 40,
                Calcium = 10,
                Iron = 0.1f,
                VitaminA = 0.02f,
                VitaminB1 = 0.01f,
                VitaminB2 = 0.01f,
                VitaminC = 20f,
                VitaminD = 0,
                VitaminE = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 90
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("22d1cbad-a884-400c-b681-30b17d98bf1c"), // Đậu hũ non
                Calories = 65,
                Protein = 7,
                Carbs = 2.4f,
                Fiber = 1,
                Sugar = 0.5f,
                Fat = 3.5f,
                SaturatedFat = 0.5f,
                UnsaturatedFat = 2.5f,
                Cholesterol = 0,
                Sodium = 15,
                Potassium = 150,
                Calcium = 80,
                Iron = 1,
                VitaminA = 0.01f,
                VitaminB1 = 0.02f,
                VitaminB2 = 0.03f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            // #region Nutrition 91
            // new Nutrition
            // {
            //     NutritionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("c81a404a-ec10-428e-acec-dd56ec1d3607"), // Nem chua
            //     Calories = 220,
            //     Protein = 15,
            //     Carbs = 15,
            //     Fiber = 0.5f,
            //     Sugar = 2,
            //     Fat = 12,
            //     SaturatedFat = 2,
            //     UnsaturatedFat = 3,
            //     Cholesterol = 20,
            //     Sodium = 500,
            //     Potassium = 200,
            //     Calcium = 10,
            //     Iron = 0.8f,
            //     VitaminA = 0.01f,
            //     VitaminB1 = 0.04f,
            //     VitaminB2 = 0.03f,
            //     VitaminC = 0,
            //     VitaminD = 0,
            //     VitaminE = 0.1f,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            // },
            // #endregion

            #region Nutrition 92
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"), // Cá ngừ
                Calories = 184,
                Protein = 30,
                Carbs = 0,
                Fiber = 0,
                Sugar = 0,
                Fat = 6,
                SaturatedFat = 0.3f,
                UnsaturatedFat = 0.6f,
                Cholesterol = 51,
                Sodium = 37,
                Potassium = 252,
                Calcium = 10,
                Iron = 0.9f,
                VitaminA = 0.01f,
                VitaminB1 = 0.07f,
                VitaminB2 = 0.18f,
                VitaminC = 0,
                VitaminD = 0.8f,
                VitaminE = 0.2f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 93
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("87225215-43af-49f2-a40b-a5ebb087d27b"), // Phở bò viên
                Calories = 290,
                Protein = 18,
                Carbs = 40,
                Fiber = 1.5f,
                Sugar = 2,
                Fat = 7,
                SaturatedFat = 4,
                UnsaturatedFat = 6,
                Cholesterol = 60,
                Sodium = 900,
                Potassium = 350,
                Calcium = 40,
                Iron = 3,
                VitaminA = 0.1f,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.08f,
                VitaminC = 1,
                VitaminD = 0,
                VitaminE = 0.2f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 94
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("23443efa-dc06-4e7a-949c-5c823ee6e575"), // Khoai lang luộc
                Calories = 86,
                Protein = 1.6f,
                Carbs = 20,
                Fiber = 3,
                Sugar = 4.2f,
                Fat = 0.1f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.1f,
                Cholesterol = 0,
                Sodium = 55,
                Potassium = 337,
                Calcium = 30,
                Iron = 0.6f,
                VitaminA = 0.96f,
                VitaminB1 = 0.08f,
                VitaminB2 = 0.03f,
                VitaminC = 2.4f,
                VitaminD = 0,
                VitaminE = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 95
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("afe0a180-0077-4fdf-89e8-9513c6132f92"), // Đu đủ
                Calories = 43,
                Protein = 0.5f,
                Carbs = 11,
                Fiber = 0.7f,
                Sugar = 8.3f,
                Fat = 0.3f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.4f,
                Cholesterol = 0,
                Sodium = 3,
                Potassium = 257,
                Calcium = 20,
                Iron = 0.3f,
                VitaminA = 0.95f,
                VitaminB1 = 0.03f,
                VitaminB2 = 0.04f,
                VitaminC = 61,
                VitaminD = 0,
                VitaminE = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 96
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("16066b9b-e61f-4354-803b-e2f9c9f5a5db"), // Cháo đậu đỏ
                Calories = 120,
                Protein = 4,
                Carbs = 25,
                Fiber = 3,
                Sugar = 3,
                Fat = 0.5f,
                SaturatedFat = 1,
                UnsaturatedFat = 0.8f,
                Cholesterol = 0,
                Sodium = 50,
                Potassium = 200,
                Calcium = 30,
                Iron = 1.2f,
                VitaminA = 0.02f,
                VitaminB1 = 0.03f,
                VitaminB2 = 0.02f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            // #region Nutrition 97
            // new Nutrition
            // {
            //     NutritionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("8ebd5a6e-b0af-42b6-af58-b681fceac1ef"), // Chè đậu đen
            //     Calories = 140,
            //     Protein = 5f,
            //     Carbs = 25f,
            //     Fiber = 5,
            //     Sugar = 12,
            //     Fat = 2,
            //     SaturatedFat = 0.5f,
            //     UnsaturatedFat = 1.2f,
            //     Cholesterol = 0,
            //     Sodium = 30,
            //     Potassium = 300,
            //     Calcium = 40,
            //     Iron = 2,
            //     VitaminA = 0.02f,
            //     VitaminB1 = 0.05f,
            //     VitaminB2 = 0.03f,
            //     VitaminC = 0,
            //     VitaminD = 0,
            //     VitaminE = 0.1f,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            // },
            // #endregion

            #region Nutrition 98
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("da85064b-e528-4bfa-8a64-1fbe704f9af5"), // Dưa cải chua
                Calories = 25,
                Protein = 1.2f,
                Carbs = 5,
                Fiber = 1.5f,
                Sugar = 2,
                Fat = 0.2f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.1f,
                Cholesterol = 0,
                Sodium = 750,
                Potassium = 120,
                Calcium = 40,
                Iron = 0.6f,
                VitaminA = 0.03f,
                VitaminB1 = 0.01f,
                VitaminB2 = 0.02f,
                VitaminC = 15,
                VitaminD = 0,
                VitaminE = 0.02f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 99
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("86bcbac3-fc75-46ed-8d0e-18c8c4860692"), // Ức gà nướng
                Calories = 165,
                Protein = 31f,
                Carbs = 0,
                Fiber = 0,
                Sugar = 0,
                Fat = 3.6f,
                SaturatedFat = 1f,
                UnsaturatedFat = 2.6f,
                Cholesterol = 85,
                Sodium = 70,
                Potassium = 256,
                Calcium = 13,
                Iron = 1f,
                VitaminA = 13f,
                VitaminB1 = 0.07f,
                VitaminB2 = 0.1f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.5f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 100
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("a6ce6816-c6e1-4512-aeb6-d5d647815c1d"), // Thịt bò nạc
                Calories = 250,
                Protein = 26f,
                Carbs = 0,
                Fiber = 0,
                Sugar = 0,
                Fat = 15f,
                SaturatedFat = 6f,
                UnsaturatedFat = 9f,
                Cholesterol = 90,
                Sodium = 75,
                Potassium = 280,
                Calcium = 20,
                Iron = 2.5f,
                VitaminA = 0,
                VitaminB1 = 0.08f,
                VitaminB2 = 0.2f,
                VitaminC = 0,
                VitaminD = 7f,
                VitaminE = 0.5f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 101
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("edb9d5d0-01f3-4607-a406-9e04bbff85fb"), // Cá hồi nướng
                Calories = 206,
                Protein = 22,
                Carbs = 0,
                Fiber = 0,
                Sugar = 0,
                Fat = 13,
                SaturatedFat = 3.1f,
                UnsaturatedFat = 9.9f,
                Cholesterol = 63,
                Sodium = 59,
                Potassium = 363,
                Calcium = 12,
                Iron = 0.5f,
                VitaminA = 0,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.38f,
                VitaminC = 0,
                VitaminD = 570f,
                VitaminE = 0.4f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 102
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("4d640470-857a-4765-905f-e49e98a281a1"), // Tôm hấp
                Calories = 99,
                Protein = 24,
                Carbs = 0,
                Fiber = 0,
                Sugar = 0,
                Fat = 1.1f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.2f,
                Cholesterol = 189,
                Sodium = 111,
                Potassium = 264,
                Calcium = 70,
                Iron = 0.4f,
                VitaminA = 0,
                VitaminB1 = 0.02f,
                VitaminB2 = 0.1f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 1.3f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 103
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("d3a1c73d-ca5a-45ea-a7fa-d582f1253b79"), // Thịt lợn nạc
                Calories = 143,
                Protein = 26,
                Carbs = 0,
                Fiber = 0,
                Sugar = 0,
                Fat = 3.5f,
                SaturatedFat = 5.2f,
                UnsaturatedFat = 8.8f,
                Cholesterol = 70,
                Sodium = 65,
                Potassium = 370,
                Calcium = 7,
                Iron = 0.9f,
                VitaminA = 0,
                VitaminB1 = 0.6f,
                VitaminB2 = 0.15f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.2f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 104
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"), // Cá thu nướng
                Calories = 190,
                Protein = 20,
                Carbs = 0,
                Fiber = 0,
                Sugar = 0,
                Fat = 12,
                SaturatedFat = 4.3f,
                UnsaturatedFat = 8.7f,
                Cholesterol = 75,
                Sodium = 60,
                Potassium = 302,
                Calcium = 12,
                Iron = 1.1f,
                VitaminA = 0,
                VitaminB1 = 0.03f,
                VitaminB2 = 0.33f,
                VitaminC = 0,
                VitaminD = 440f,
                VitaminE = 0.5f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 105
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("3fa8cf38-d835-4279-a113-a8f44cd013e6"), // Đậu nành luộc
                Calories = 172,
                Protein = 18,
                Carbs = 8.4f,
                Fiber = 6,
                Sugar = 2,
                Fat = 9,
                SaturatedFat = 1.3f,
                UnsaturatedFat = 7.7f,
                Cholesterol = 0,
                Sodium = 15,
                Potassium = 620,
                Calcium = 277,
                Iron = 2.5f,
                VitaminA = 9f,
                VitaminB1 = 0.16f,
                VitaminB2 = 0.18f,
                VitaminC = 6f,
                VitaminD = 0,
                VitaminE = 0.9f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 106
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("d3392e5d-a48f-4b5a-968d-31b98bd47835"), // Sữa chua Hy Lạp
                Calories = 97,
                Protein = 10,
                Carbs = 3.6f,
                Fiber = 0,
                Sugar = 3.6f,
                Fat = 5,
                SaturatedFat = 0.2f,
                UnsaturatedFat = 0.2f,
                Cholesterol = 5,
                Sodium = 36,
                Potassium = 141,
                Calcium = 110,
                Iron = 0.1f,
                VitaminA = 3f,
                VitaminB1 = 0.04f,
                VitaminB2 = 0.14f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 107
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("ad6a860f-4a4a-4cb7-90fa-21c8f36c91ce"), // Ức vịt nướng
                Calories = 195,
                Protein = 19,
                Carbs = 0,
                Fiber = 0,
                Sugar = 0,
                Fat = 13,
                SaturatedFat = 2.5f,
                UnsaturatedFat = 5.5f,
                Cholesterol = 75,
                Sodium = 60,
                Potassium = 250,
                Calcium = 15,
                Iron = 1.4f,
                VitaminA = 0,
                VitaminB1 = 0.06f,
                VitaminB2 = 0.15f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.7f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 108
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("5ebbc839-81e6-496f-9e4d-8d90d732a906"), // Cá ngừ đóng hộp
                Calories = 116,
                Protein = 25,
                Carbs = 0,
                Fiber = 0,
                Sugar = 0,
                Fat = 1,
                SaturatedFat = 0.2f,
                UnsaturatedFat = 0.8f,
                Cholesterol = 45,
                Sodium = 300,
                Potassium = 200,
                Calcium = 11,
                Iron = 0.5f,
                VitaminA = 0,
                VitaminB1 = 0.09f,
                VitaminB2 = 0.2f,
                VitaminC = 0,
                VitaminD = 200f,
                VitaminE = 0.4f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 109
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("50c0adac-c878-4a21-8b5f-01478e7e4852"), // Đậu hũ chiên
                Calories = 270,
                Protein = 17,
                Carbs = 10,
                Fiber = 3,
                Sugar = 1,
                Fat = 20,
                SaturatedFat = 1f,
                UnsaturatedFat = 7f,
                Cholesterol = 0,
                Sodium = 10,
                Potassium = 230,
                Calcium = 350,
                Iron = 3f,
                VitaminA = 5f,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.1f,
                VitaminC = 0.5f,
                VitaminD = 0,
                VitaminE = 0.4f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 110
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("55bd2b96-0e5f-4be4-acae-25f5e3e25244"), // Bò bít tết
                Calories = 270,
                Protein = 25,
                Carbs = 0,
                Fiber = 0,
                Sugar = 0,
                Fat = 19,
                SaturatedFat = 7.4f,
                UnsaturatedFat = 11.6f,
                Cholesterol = 82,
                Sodium = 62,
                Potassium = 300,
                Calcium = 18,
                Iron = 2.7f,
                VitaminA = 0,
                VitaminB1 = 0.08f,
                VitaminB2 = 0.18f,
                VitaminC = 0,
                VitaminD = 8f,
                VitaminE = 0.5f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 111
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("a23f6c85-1a80-4255-a9a1-d08c1d60e753"), // Cá hồi hun khói
                Calories = 180,
                Protein = 25,
                Carbs = 0,
                Fiber = 0,
                Sugar = 0,
                Fat = 9,
                SaturatedFat = 0.7f,
                UnsaturatedFat = 3.6f,
                Cholesterol = 25,
                Sodium = 670,
                Potassium = 265,
                Calcium = 11,
                Iron = 0.4f,
                VitaminA = 0,
                VitaminB1 = 0.09f,
                VitaminB2 = 0.2f,
                VitaminC = 0,
                VitaminD = 200f,
                VitaminE = 0.6f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            // #region Nutrition 112
            // new Nutrition
            // {
            //     NutritionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("b0f051be-5972-4e7a-a77d-47ec28d58993"), // Hạt hạnh nhân
            //     Calories = 576,
            //     Protein = 21f,
            //     Carbs = 22f,
            //     Fiber = 12f,
            //     Sugar = 3.9f,
            //     Fat = 50f,
            //     SaturatedFat = 3.8f,
            //     UnsaturatedFat = 46.2f,
            //     Cholesterol = 0,
            //     Sodium = 1,
            //     Potassium = 705,
            //     Calcium = 264,
            //     Iron = 3.7f,
            //     VitaminA = 1f,
            //     VitaminB1 = 0.21f,
            //     VitaminB2 = 1.01f,
            //     VitaminC = 0,
            //     VitaminD = 0,
            //     VitaminE = 25.6f,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            // },
            // #endregion

            #region Nutrition 113
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("8da16f72-42a9-4da2-b217-811903e340c4"), // Đậu hũ sốt cà
                Calories = 150,
                Protein = 10,
                Carbs = 12,
                Fiber = 3,
                Sugar = 6,
                Fat = 8,
                SaturatedFat = 1.1f,
                UnsaturatedFat = 5.9f,
                Cholesterol = 0,
                Sodium = 15,
                Potassium = 240,
                Calcium = 357,
                Iron = 2.8f,
                VitaminA = 12f,
                VitaminB1 = 0.08f,
                VitaminB2 = 0.16f,
                VitaminC = 5f,
                VitaminD = 0,
                VitaminE = 0.5f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 114
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("a5d484c6-9cc8-4d6e-a53c-5c8a2c20999b"), // Thịt lợn xông khói
                Calories = 420,
                Protein = 30,
                Carbs = 0,
                Fiber = 0,
                Sugar = 0,
                Fat = 35,
                SaturatedFat = 14.6f,
                UnsaturatedFat = 24.4f,
                Cholesterol = 60,
                Sodium = 800,
                Potassium = 200,
                Calcium = 15,
                Iron = 1f,
                VitaminA = 0,
                VitaminB1 = 0.04f,
                VitaminB2 = 0.09f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.3f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            // #region Nutrition 115
            // new Nutrition
            // {
            //     NutritionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("59988378-901f-4ec4-bd6c-9fdc28ca97a1"), // Hạt bí ngô
            //     Calories = 559,
            //     Protein = 30f,
            //     Carbs = 14f,
            //     Fiber = 6f,
            //     Sugar = 1.4f,
            //     Fat = 49f,
            //     SaturatedFat = 8.7f,
            //     UnsaturatedFat = 40.3f,
            //     Cholesterol = 0,
            //     Sodium = 18,
            //     Potassium = 809,
            //     Calcium = 46,
            //     Iron = 8.8f,
            //     VitaminA = 0,
            //     VitaminB1 = 0.19f,
            //     VitaminB2 = 0.32f,
            //     VitaminC = 0,
            //     VitaminD = 0,
            //     VitaminE = 2.2f,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            // },
            // #endregion

            #region Nutrition 116
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("b29dc622-e8ae-4471-8e22-5676aa5fa909"), // Đậu Hà Lan luộc
                Calories = 81,
                Protein = 5,
                Carbs = 14,
                Fiber = 5,
                Sugar = 5.7f,
                Fat = 0.4f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.3f,
                Cholesterol = 0,
                Sodium = 5,
                Potassium = 244,
                Calcium = 25,
                Iron = 1.5f,
                VitaminA = 765f,
                VitaminB1 = 0.27f,
                VitaminB2 = 0.15f,
                VitaminC = 40f,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 117
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("0f7f47a1-f122-4f58-9e24-40ece9323520"), // Thịt gà quay
                Calories = 190,
                Protein = 27,
                Carbs = 0,
                Fiber = 0,
                Sugar = 0,
                Fat = 9,
                SaturatedFat = 4.1f,
                UnsaturatedFat = 9.9f,
                Cholesterol = 76,
                Sodium = 70,
                Potassium = 260,
                Calcium = 15,
                Iron = 0.8f,
                VitaminA = 10f,
                VitaminB1 = 0.06f,
                VitaminB2 = 0.11f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.3f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 118
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("98b3945a-9169-4581-b1a5-da82f2ebd8d4"), // Sữa bò tươi
                Calories = 61,
                Protein = 3.3f,
                Carbs = 4.8f,
                Fiber = 0,
                Sugar = 4.8f,
                Fat = 3.3f,
                SaturatedFat = 0.6f,
                UnsaturatedFat = 0.4f,
                Cholesterol = 5,
                Sodium = 44,
                Potassium = 150,
                Calcium = 120,
                Iron = 0.1f,
                VitaminA = 47f,
                VitaminB1 = 0.02f,
                VitaminB2 = 0.18f,
                VitaminC = 0,
                VitaminD = 2f,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 119
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("c46676b3-cbcc-49e9-ad44-7d450a481a19"), // Yến mạch
                Calories = 375,
                Protein = 13,
                Carbs = 68,
                Fiber = 10,
                Sugar = 1,
                Fat = 7,
                SaturatedFat = 1.2f,
                UnsaturatedFat = 5.7f,
                Cholesterol = 0,
                Sodium = 2,
                Potassium = 362,
                Calcium = 54,
                Iron = 4.7f,
                VitaminA = 0,
                VitaminB1 = 0.76f,
                VitaminB2 = 0.14f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.42f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 120
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("597a11b3-31a0-4e70-8d2f-95465ee03e8b"), // Cải bó xôi
                Calories = 23,
                Protein = 2.9f,
                Carbs = 3.6f,
                Fiber = 2.2f,
                Sugar = 0.4f,
                Fat = 0.4f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.3f,
                Cholesterol = 0,
                Sodium = 79,
                Potassium = 558,
                Calcium = 99,
                Iron = 2.7f,
                VitaminA = 9377f,
                VitaminB1 = 0.08f,
                VitaminB2 = 0.19f,
                VitaminC = 28.1f,
                VitaminD = 0,
                VitaminE = 2.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            // #region Nutrition 121
            // new Nutrition
            // {
            //     NutritionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("4e46f955-4413-496f-97b4-968a38ee3e11"), // Hạt hướng dương
            //     Calories = 584,
            //     Protein = 20.8f,
            //     Carbs = 20f,
            //     Fiber = 8.6f,
            //     Sugar = 2.6f,
            //     Fat = 51.5f,
            //     SaturatedFat = 4.5f,
            //     UnsaturatedFat = 47f,
            //     Cholesterol = 0,
            //     Sodium = 9,
            //     Potassium = 645,
            //     Calcium = 78,
            //     Iron = 5.3f,
            //     VitaminA = 0,
            //     VitaminB1 = 1.48f,
            //     VitaminB2 = 0.25f,
            //     VitaminC = 1.4f,
            //     VitaminD = 0,
            //     VitaminE = 35.2f,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            // },
            // #endregion

            #region Nutrition 122
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("644f32b3-897e-45b1-b4d7-aa8b9585a262"), // Rau mồng tơi
                Calories = 23,
                Protein = 2.3f,
                Carbs = 3.6f,
                Fiber = 2.1f,
                Sugar = 0.4f,
                Fat = 0.3f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.3f,
                Cholesterol = 0,
                Sodium = 30,
                Potassium = 554,
                Calcium = 114,
                Iron = 2.1f,
                VitaminA = 8100f,
                VitaminB1 = 0.08f,
                VitaminB2 = 0.16f,
                VitaminC = 51.9f,
                VitaminD = 0,
                VitaminE = 1.9f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 123
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"), // Lê
                Calories = 57,
                Protein = 0.4f,
                Carbs = 15,
                Fiber = 3.1f,
                Sugar = 10,
                Fat = 0.2f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.1f,
                Cholesterol = 0,
                Sodium = 1,
                Potassium = 116,
                Calcium = 9,
                Iron = 0.2f,
                VitaminA = 25f,
                VitaminB1 = 0.02f,
                VitaminB2 = 0.03f,
                VitaminC = 4.3f,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 124
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("2e641c82-56f7-480d-b216-63723b5a5e7d"), // Dâu tây
                Calories = 32,
                Protein = 0.7f,
                Carbs = 7.7f,
                Fiber = 2,
                Sugar = 4.9f,
                Fat = 0.3f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.3f,
                Cholesterol = 0,
                Sodium = 1,
                Potassium = 153,
                Calcium = 16,
                Iron = 0.4f,
                VitaminA = 12f,
                VitaminB1 = 0.02f,
                VitaminB2 = 0.05f,
                VitaminC = 58.8f,
                VitaminD = 0,
                VitaminE = 0.3f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 125
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("a8de2767-4b0a-41db-b33b-2523f5be2e0c"), // Mâm xôi
                Calories = 52,
                Protein = 1.2f,
                Carbs = 12,
                Fiber = 6.5f,
                Sugar = 4.4f,
                Fat = 0.7f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.6f,
                Cholesterol = 0,
                Sodium = 1,
                Potassium = 151,
                Calcium = 25,
                Iron = 0.7f,
                VitaminA = 33f,
                VitaminB1 = 0.03f,
                VitaminB2 = 0.04f,
                VitaminC = 26.2f,
                VitaminD = 0,
                VitaminE = 0.9f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 126
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("00333cd3-f43b-40af-855e-95aa8a636e4a"), // Bí đỏ
                Calories = 26,
                Protein = 1,
                Carbs = 6.5f,
                Fiber = 0.5f,
                Sugar = 2.8f,
                Fat = 0.1f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.1f,
                Cholesterol = 0,
                Sodium = 1,
                Potassium = 340,
                Calcium = 21,
                Iron = 0.8f,
                VitaminA = 8533f,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.11f,
                VitaminC = 9f,
                VitaminD = 0,
                VitaminE = 0.3f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 127
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("8d95f2a5-cdd0-4c79-8cd0-99ff05cad567"), // Khoai môn
                Calories = 112,
                Protein = 1.5f,
                Carbs = 26,
                Fiber = 4.1f,
                Sugar = 0.5f,
                Fat = 0.2f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.1f,
                Cholesterol = 0,
                Sodium = 13,
                Potassium = 484,
                Calcium = 43,
                Iron = 0.6f,
                VitaminA = 47f,
                VitaminB1 = 0.09f,
                VitaminB2 = 0.03f,
                VitaminC = 4.5f,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 128
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("7afe5fe6-3bcb-4354-86ea-e8d6a81aa9a2"), // Măng tây
                Calories = 20,
                Protein = 2.2f,
                Carbs = 3.9f,
                Fiber = 2.1f,
                Sugar = 1.9f,
                Fat = 0.1f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.2f,
                Cholesterol = 0,
                Sodium = 2,
                Potassium = 202,
                Calcium = 24,
                Iron = 0.5f,
                VitaminA = 756f,
                VitaminB1 = 0.08f,
                VitaminB2 = 0.14f,
                VitaminC = 5.6f,
                VitaminD = 0,
                VitaminE = 1.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 129
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("ff348fc8-cd36-41c4-984f-a5884171f367"), // Bắp cải tím
                Calories = 31,
                Protein = 1.4f,
                Carbs = 7,
                Fiber = 2.8f,
                Sugar = 3.8f,
                Fat = 0.2f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.2f,
                Cholesterol = 0,
                Sodium = 27,
                Potassium = 216,
                Calcium = 45,
                Iron = 0.6f,
                VitaminA = 993f,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.06f,
                VitaminC = 36.6f,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 130
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("7b3216ff-858e-423e-b8db-a85571aa5488"), // Kiwi
                Calories = 61,
                Protein = 1.1f,
                Carbs = 15,
                Fiber = 3,
                Sugar = 9,
                Fat = 0.5f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.5f,
                Cholesterol = 0,
                Sodium = 3,
                Potassium = 312,
                Calcium = 34,
                Iron = 0.3f,
                VitaminA = 87f,
                VitaminB1 = 0.02f,
                VitaminB2 = 0.05f,
                VitaminC = 92.7f,
                VitaminD = 0,
                VitaminE = 1.5f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            // #region Nutrition 131
            // new Nutrition
            // {
            //     NutritionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("68c8c4c4-e5d6-4e15-ad60-1c18f0c1cb4d"), // Hạt kê
            //     Calories = 378,
            //     Protein = 11f,
            //     Carbs = 72.9f,
            //     Fiber = 8.5f,
            //     Sugar = 0.6f,
            //     Fat = 4.2f,
            //     SaturatedFat = 0.7f,
            //     UnsaturatedFat = 3.5f,
            //     Cholesterol = 0,
            //     Sodium = 5,
            //     Potassium = 195,
            //     Calcium = 8,
            //     Iron = 3f,
            //     VitaminA = 0,
            //     VitaminB1 = 0.41f,
            //     VitaminB2 = 0.29f,
            //     VitaminC = 0,
            //     VitaminD = 0,
            //     VitaminE = 0.1f,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            // },
            // #endregion

            #region Nutrition 132
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("35cad577-0748-469f-8909-7dc013cf1c55"), // Măng khô
                Calories = 258,
                Protein = 5,
                Carbs = 60,
                Fiber = 13,
                Sugar = 2,
                Fat = 1,
                SaturatedFat = 0,
                UnsaturatedFat = 0.2f,
                Cholesterol = 0,
                Sodium = 4,
                Potassium = 533,
                Calcium = 16,
                Iron = 0.7f,
                VitaminA = 0,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.03f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 133
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("575e8bca-57e3-4d16-b380-545a046c9a4e"), // Rong biển khô
                Calories = 35,
                Protein = 6,
                Carbs = 5.3f,
                Fiber = 0.5f,
                Sugar = 0.5f,
                Fat = 0.3f,
                SaturatedFat = 0.6f,
                UnsaturatedFat = 1.5f,
                Cholesterol = 0,
                Sodium = 233,
                Potassium = 1040,
                Calcium = 70,
                Iron = 2.3f,
                VitaminA = 260f,
                VitaminB1 = 0.06f,
                VitaminB2 = 0.32f,
                VitaminC = 6f,
                VitaminD = 0,
                VitaminE = 1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 134
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("830df1fb-09f6-4e6e-95c3-e39051e3b2d8"), // Bông cải xanh
                Calories = 34,
                Protein = 2.8f,
                Carbs = 7,
                Fiber = 2.6f,
                Sugar = 1.7f,
                Fat = 0.4f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.4f,
                Cholesterol = 0,
                Sodium = 33,
                Potassium = 316,
                Calcium = 47,
                Iron = 0.7f,
                VitaminA = 623f,
                VitaminB1 = 0.07f,
                VitaminB2 = 0.12f,
                VitaminC = 89.2f,
                VitaminD = 0,
                VitaminE = 0.8f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 135
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("9b98036c-2047-4700-bb13-b34a432bb999"), // Gạo lứt
                Calories = 112,
                Protein = 2.6f,
                Carbs = 24,
                Fiber = 1.8f,
                Sugar = 0.4f,
                Fat = 0.8f,
                SaturatedFat = 0.2f,
                UnsaturatedFat = 0.7f,
                Cholesterol = 0,
                Sodium = 1,
                Potassium = 86,
                Calcium = 10,
                Iron = 0.4f,
                VitaminA = 0,
                VitaminB1 = 0.14f,
                VitaminB2 = 0.02f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 136
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("1aa49363-ab95-4565-9e27-1855702197fd"), // Nho
                Calories = 69,
                Protein = 0.7f,
                Carbs = 18,
                Fiber = 0.9f,
                Sugar = 16,
                Fat = 0.2f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.2f,
                Cholesterol = 0,
                Sodium = 2,
                Potassium = 191,
                Calcium = 10,
                Iron = 0.4f,
                VitaminA = 92f,
                VitaminB1 = 0.03f,
                VitaminB2 = 0.04f,
                VitaminC = 10.8f,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 137
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("98c908b5-dad8-4db4-8d60-c6157c53d2c0"), // Rau cải bó xôi
                Calories = 23,
                Protein = 2.9f,
                Carbs = 3.6f,
                Fiber = 2.2f,
                Sugar = 0.4f,
                Fat = 0.4f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.3f,
                Cholesterol = 0,
                Sodium = 79,
                Potassium = 558,
                Calcium = 99,
                Iron = 2.7f,
                VitaminA = 9377f,
                VitaminB1 = 0.08f,
                VitaminB2 = 0.19f,
                VitaminC = 28.1f,
                VitaminD = 0,
                VitaminE = 2.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            // #region Nutrition 138
            // new Nutrition
            // {
            //     NutritionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("9349fefa-ecbc-4afc-89f4-62c2f67eb441"), // Đậu đen
            //     Calories = 132,
            //     Protein = 8.9f,
            //     Carbs = 23.7f,
            //     Fiber = 8.7f,
            //     Sugar = 0.3f,
            //     Fat = 0.5f,
            //     SaturatedFat = 0.1f,
            //     UnsaturatedFat = 0.4f,
            //     Cholesterol = 0,
            //     Sodium = 5,
            //     Potassium = 355,
            //     Calcium = 27,
            //     Iron = 2.1f,
            //     VitaminA = 5f,
            //     VitaminB1 = 0.24f,
            //     VitaminB2 = 0.21f,
            //     VitaminC = 0,
            //     VitaminD = 0,
            //     VitaminE = 0.2f,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            // },
            // #endregion

            #region Nutrition 139
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("857b3565-b170-4162-a97b-c0184c4258aa"), // Củ cải đường
                Calories = 43,
                Protein = 1.6f,
                Carbs = 10,
                Fiber = 2.8f,
                Sugar = 6.8f,
                Fat = 0.2f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.2f,
                Cholesterol = 0,
                Sodium = 78,
                Potassium = 325,
                Calcium = 16,
                Iron = 0.8f,
                VitaminA = 33f,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.03f,
                VitaminC = 4.9f,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 140
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("7cd76708-7312-445e-a392-14f0e806a786"), // Đậu Hà Lan
                Calories = 81,
                Protein = 5,
                Carbs = 14,
                Fiber = 5,
                Sugar = 5.7f,
                Fat = 0.4f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.3f,
                Cholesterol = 0,
                Sodium = 5,
                Potassium = 244,
                Calcium = 25,
                Iron = 1.5f,
                VitaminA = 765f,
                VitaminB1 = 0.27f,
                VitaminB2 = 0.15f,
                VitaminC = 40f,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            // #region Nutrition 141
            // new Nutrition
            // {
            //     NutritionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("642480b4-22c9-4350-a6ce-c052f99e60e3"), // Lúa mạch
            //     Calories = 354,
            //     Protein = 12.5f,
            //     Carbs = 73.5f,
            //     Fiber = 17.3f,
            //     Sugar = 0.8f,
            //     Fat = 2.3f,
            //     SaturatedFat = 0.5f,
            //     UnsaturatedFat = 1.8f,
            //     Cholesterol = 0,
            //     Sodium = 9,
            //     Potassium = 452,
            //     Calcium = 33,
            //     Iron = 3.6f,
            //     VitaminA = 22f,
            //     VitaminB1 = 0.27f,
            //     VitaminB2 = 0.16f,
            //     VitaminC = 0,
            //     VitaminD = 0,
            //     VitaminE = 0.2f,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            // },
            // #endregion

            #region Nutrition 142
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("10869d8c-14b9-4464-85ca-bf76fc4bf91d"), // Rau dền đỏ
                Calories = 23,
                Protein = 2.5f,
                Carbs = 4.2f,
                Fiber = 2.6f,
                Sugar = 0.4f,
                Fat = 0.3f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.3f,
                Cholesterol = 0,
                Sodium = 15,
                Potassium = 500,
                Calcium = 55,
                Iron = 1.8f,
                VitaminA = 8890f,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.18f,
                VitaminC = 37.5f,
                VitaminD = 0,
                VitaminE = 0.4f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 143
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("c9a7bb8d-a7da-407f-8f88-1ccc01adce80"), // Mì gạo lứt
                Calories = 110,
                Protein = 3.5f,
                Carbs = 22,
                Fiber = 2.5f,
                Sugar = 0.2f,
                Fat = 0.9f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.5f,
                Cholesterol = 0,
                Sodium = 4,
                Potassium = 60,
                Calcium = 8,
                Iron = 0.2f,
                VitaminA = 0,
                VitaminB1 = 0.08f,
                VitaminB2 = 0.03f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 144
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("9979963d-5c37-4fa9-955c-d1ecb5814607"), // Rau chân vịt
                Calories = 23,
                Protein = 2.9f,
                Carbs = 3.6f,
                Fiber = 2.2f,
                Sugar = 0.4f,
                Fat = 0.4f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.3f,
                Cholesterol = 0,
                Sodium = 79,
                Potassium = 558,
                Calcium = 99,
                Iron = 2.7f,
                VitaminA = 9377f,
                VitaminB1 = 0.08f,
                VitaminB2 = 0.19f,
                VitaminC = 28.1f,
                VitaminD = 0,
                VitaminE = 2.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 145
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("845454d0-967a-4e48-aef3-bd8458775500"), // Củ cải trắng
                Calories = 18,
                Protein = 0.6f,
                Carbs = 4.1f,
                Fiber = 1.6f,
                Sugar = 2.5f,
                Fat = 0.1f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.1f,
                Cholesterol = 0,
                Sodium = 9,
                Potassium = 233,
                Calcium = 27,
                Iron = 0.3f,
                VitaminA = 0,
                VitaminB1 = 0.02f,
                VitaminB2 = 0.03f,
                VitaminC = 14.8f,
                VitaminD = 0,
                VitaminE = 0.2f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 146
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("6a88b8cb-dc82-4751-a2e4-23e5516d850b"), // Rau má
                Calories = 32,
                Protein = 2,
                Carbs = 6.3f,
                Fiber = 2f,
                Sugar = 0.5f,
                Fat = 0.3f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.2f,
                Cholesterol = 0,
                Sodium = 36,
                Potassium = 391,
                Calcium = 39,
                Iron = 0.9f,
                VitaminA = 442f,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.05f,
                VitaminC = 48.5f,
                VitaminD = 0,
                VitaminE = 0.6f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            // #region Nutrition 147
            // new Nutrition
            // {
            //     NutritionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("7729551a-e475-4079-aaa0-07c02efde2a5"), // Hạt lanh
            //     Calories = 534,
            //     Protein = 18.3f,
            //     Carbs = 28.9f,
            //     Fiber = 27.3f,
            //     Sugar = 1.6f,
            //     Fat = 42.2f,
            //     SaturatedFat = 3.7f,
            //     UnsaturatedFat = 38.5f,
            //     Cholesterol = 0,
            //     Sodium = 30,
            //     Potassium = 813,
            //     Calcium = 255,
            //     Iron = 5.7f,
            //     VitaminA = 0,
            //     VitaminB1 = 0.41f,
            //     VitaminB2 = 0.16f,
            //     VitaminC = 0.6f,
            //     VitaminD = 0,
            //     VitaminE = 0.3f,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            // },
            // #endregion

            // #region Nutrition 148
            // new Nutrition
            // {
            //     NutritionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("404a286a-90c5-4c54-8e27-3ddeba55ada3"), // Hạt dẻ cười
            //     Calories = 562,
            //     Protein = 20.3f,
            //     Carbs = 27.2f,
            //     Fiber = 10.3f,
            //     Sugar = 7.7f,
            //     Fat = 45.4f,
            //     SaturatedFat = 5.6f,
            //     UnsaturatedFat = 39.8f,
            //     Cholesterol = 0,
            //     Sodium = 1,
            //     Potassium = 1025,
            //     Calcium = 107,
            //     Iron = 4f,
            //     VitaminA = 26f,
            //     VitaminB1 = 0.87f,
            //     VitaminB2 = 0.16f,
            //     VitaminC = 5.4f,
            //     VitaminD = 0,
            //     VitaminE = 2.9f,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            // },
            // #endregion

            #region Nutrition 149
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("49601ef1-2131-478f-a1de-f2e444602be3"), // Dừa tươi
                Calories = 354,
                Protein = 3.3f,
                Carbs = 15,
                Fiber = 9,
                Sugar = 6.2f,
                Fat = 33,
                SaturatedFat = 29.7f,
                UnsaturatedFat = 3.8f,
                Cholesterol = 0,
                Sodium = 20,
                Potassium = 356,
                Calcium = 14,
                Iron = 2.4f,
                VitaminA = 0,
                VitaminB1 = 0.04f,
                VitaminB2 = 0.02f,
                VitaminC = 3.3f,
                VitaminD = 0,
                VitaminE = 0.3f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 150
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("d3c360a2-441e-4700-a6ec-4310b5976901"), // Cá thu
                Calories = 190,
                Protein = 20,
                Carbs = 0,
                Fiber = 0,
                Sugar = 0,
                Fat = 12,
                SaturatedFat = 4.3f,
                UnsaturatedFat = 8.7f,
                Cholesterol = 75,
                Sodium = 60,
                Potassium = 302,
                Calcium = 12,
                Iron = 1.1f,
                VitaminA = 0,
                VitaminB1 = 0.03f,
                VitaminB2 = 0.33f,
                VitaminC = 0,
                VitaminD = 440f,
                VitaminE = 0.5f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            // #region Nutrition 151
            // new Nutrition
            // {
            //     NutritionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("731974ef-495e-4c08-ba95-20589d60c20c"), // Hạt mắc ca
            //     Calories = 718,
            //     Protein = 7.9f,
            //     Carbs = 13.8f,
            //     Fiber = 8.6f,
            //     Sugar = 4.6f,
            //     Fat = 75.8f,
            //     SaturatedFat = 12.1f,
            //     UnsaturatedFat = 63.7f,
            //     Cholesterol = 0,
            //     Sodium = 5,
            //     Potassium = 363,
            //     Calcium = 85,
            //     Iron = 2.5f,
            //     VitaminA = 0,
            //     VitaminB1 = 0.21f,
            //     VitaminB2 = 0.16f,
            //     VitaminC = 1.1f,
            //     VitaminD = 0,
            //     VitaminE = 0.6f,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            // },
            // #endregion

            #region Nutrition 152
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("cb693182-b5ff-4f2b-9a47-44ab84841843"), // Hồng xiêm
                Calories = 70,
                Protein = 0.6f,
                Carbs = 19,
                Fiber = 3.6f,
                Sugar = 13,
                Fat = 0.2f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.3f,
                Cholesterol = 0,
                Sodium = 12,
                Potassium = 193,
                Calcium = 21,
                Iron = 0.8f,
                VitaminA = 60f,
                VitaminB1 = 0.01f,
                VitaminB2 = 0.02f,
                VitaminC = 14.7f,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 153
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("aaeb8b86-48b3-454c-a299-ec5a627f7047"), // Đào
                Calories = 39,
                Protein = 0.9f,
                Carbs = 10,
                Fiber = 1.5f,
                Sugar = 8.4f,
                Fat = 0.3f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.3f,
                Cholesterol = 0,
                Sodium = 0,
                Potassium = 190,
                Calcium = 6,
                Iron = 0.3f,
                VitaminA = 326f,
                VitaminB1 = 0.02f,
                VitaminB2 = 0.05f,
                VitaminC = 6.6f,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 154
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"), // Lựu
                Calories = 83,
                Protein = 1.7f,
                Carbs = 19,
                Fiber = 4,
                Sugar = 14,
                Fat = 1.2f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 1.1f,
                Cholesterol = 0,
                Sodium = 3,
                Potassium = 236,
                Calcium = 10,
                Iron = 0.3f,
                VitaminA = 0,
                VitaminB1 = 0.07f,
                VitaminB2 = 0.06f,
                VitaminC = 10.2f,
                VitaminD = 0,
                VitaminE = 0.6f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 155
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("5f848972-c5ae-45fc-8ba2-103b24d8a23a"), // Súp cua
                Calories = 90,
                Protein = 6,
                Carbs = 10,
                Fiber = 0.5f,
                Sugar = 1,
                Fat = 3,
                SaturatedFat = 0.5f,
                UnsaturatedFat = 1.5f,
                Cholesterol = 30,
                Sodium = 500,
                Potassium = 150,
                Calcium = 20,
                Iron = 0.7f,
                VitaminA = 50,
                VitaminB1 = 0.03f,
                VitaminB2 = 0.1f,
                VitaminC = 1,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 156
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("2ae82bfd-34db-4928-bfee-b60f4aec4460"), // Canh bí đỏ
                Calories = 30,
                Protein = 1.5f,
                Carbs = 6,
                Fiber = 1,
                Sugar = 3,
                Fat = 0.3f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.4f,
                Cholesterol = 0,
                Sodium = 250,
                Potassium = 200,
                Calcium = 20,
                Iron = 0.5f,
                VitaminA = 500,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.03f,
                VitaminC = 15,
                VitaminD = 0,
                VitaminE = 1,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 157
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("c69f3300-4f1b-45ce-bdc3-ae45fec848a7"), // Canh rau củ
                Calories = 25,
                Protein = 1.3f,
                Carbs = 5,
                Fiber = 1.5f,
                Sugar = 2,
                Fat = 0.2f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.4f,
                Cholesterol = 0,
                Sodium = 300,
                Potassium = 250,
                Calcium = 30,
                Iron = 0.8f,
                VitaminA = 600,
                VitaminB1 = 0.06f,
                VitaminB2 = 0.05f,
                VitaminC = 20f,
                VitaminD = 0,
                VitaminE = 1,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 158
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("6487a532-ff5e-4b77-b408-46c789608de9"), // Canh bí đao
                Calories = 15,
                Protein = 0.8f,
                Carbs = 3,
                Fiber = 0.8f,
                Sugar = 1.5f,
                Fat = 0.2f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.1f,
                Cholesterol = 0,
                Sodium = 180,
                Potassium = 150,
                Calcium = 20,
                Iron = 0.3f,
                VitaminA = 10,
                VitaminB1 = 0.03f,
                VitaminB2 = 0.02f,
                VitaminC = 7,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 159
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("63045676-0e70-425f-aa96-e348a4e88c3a"), // Canh cua mồng tơi
                Calories = 40,
                Protein = 4,
                Carbs = 4,
                Fiber = 1.5f,
                Sugar = 1,
                Fat = 1,
                SaturatedFat = 0.5f,
                UnsaturatedFat = 1.5f,
                Cholesterol = 35,
                Sodium = 300,
                Potassium = 250,
                Calcium = 40,
                Iron = 1.5f,
                VitaminA = 300,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.1f,
                VitaminC = 5,
                VitaminD = 0,
                VitaminE = 0.5f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 160
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("827829bf-71cd-4865-80af-1457e0091456"), // Canh nấm
                Calories = 35,
                Protein = 2,
                Carbs = 5,
                Fiber = 1.5f,
                Sugar = 2,
                Fat = 1,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.4f,
                Cholesterol = 0,
                Sodium = 250,
                Potassium = 300,
                Calcium = 15,
                Iron = 0.8f,
                VitaminA = 10,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.03f,
                VitaminC = 4,
                VitaminD = 0,
                VitaminE = 0.3f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 161
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("c5e3e4ed-0164-4917-a1ce-99679b971a22"), // Cháo gà
                Calories = 120,
                Protein = 6,
                Carbs = 20,
                Fiber = 0.5f,
                Sugar = 0.5f,
                Fat = 2,
                SaturatedFat = 0.5f,
                UnsaturatedFat = 1.5f,
                Cholesterol = 25,
                Sodium = 300,
                Potassium = 150,
                Calcium = 10,
                Iron = 0.6f,
                VitaminA = 50,
                VitaminB1 = 0.06f,
                VitaminB2 = 0.05f,
                VitaminC = 1,
                VitaminD = 0,
                VitaminE = 0.2f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 162
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("e7d4d8d6-6e9a-4c38-95f2-e9790f5bd2c2"), // Cháo sườn non
                Calories = 130,
                Protein = 7,
                Carbs = 20,
                Fiber = 0.5f,
                Sugar = 0.5f,
                Fat = 3,
                SaturatedFat = 1,
                UnsaturatedFat = 3,
                Cholesterol = 30,
                Sodium = 400,
                Potassium = 200,
                Calcium = 15,
                Iron = 1,
                VitaminA = 30,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.1f,
                VitaminC = 2,
                VitaminD = 0,
                VitaminE = 0.3f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 163
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("fa1f0dc9-270a-4e77-881f-acb53ac1c91d"), // Cháo thịt băm
                Calories = 125,
                Protein = 6,
                Carbs = 20,
                Fiber = 0.5f,
                Sugar = 0.5f,
                Fat = 2.5f,
                SaturatedFat = 1,
                UnsaturatedFat = 3,
                Cholesterol = 25,
                Sodium = 350,
                Potassium = 180,
                Calcium = 15,
                Iron = 0.9f,
                VitaminA = 20,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.07f,
                VitaminC = 1,
                VitaminD = 0,
                VitaminE = 0.2f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 164
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("0ece5f0f-9fec-4f74-b948-90dce7ce6ce3"), // Bún chả cá
                Calories = 270,
                Protein = 15,
                Carbs = 40,
                Fiber = 1.5f,
                Sugar = 2,
                Fat = 6,
                SaturatedFat = 0.5f,
                UnsaturatedFat = 2.5f,
                Cholesterol = 35,
                Sodium = 450,
                Potassium = 200,
                Calcium = 30,
                Iron = 1.5f,
                VitaminA = 100,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.1f,
                VitaminC = 3,
                VitaminD = 0,
                VitaminE = 0.3f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 165
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("7167f942-dc89-4f29-8022-588373aef45e"), // Bún gà
                Calories = 260,
                Protein = 14,
                Carbs = 40,
                Fiber = 1.5f,
                Sugar = 2,
                Fat = 5,
                SaturatedFat = 0.5f,
                UnsaturatedFat = 2.5f,
                Cholesterol = 30,
                Sodium = 400,
                Potassium = 220,
                Calcium = 25,
                Iron = 0.9f,
                VitaminA = 80,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.1f,
                VitaminC = 3,
                VitaminD = 0,
                VitaminE = 0.3f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 166
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("d65c7826-78c0-4991-b3b6-1e2b25437f61"), // Bún hải sản
                Calories = 280,
                Protein = 16,
                Carbs = 40,
                Fiber = 1.5f,
                Sugar = 2,
                Fat = 6,
                SaturatedFat = 0.5f,
                UnsaturatedFat = 2.5f,
                Cholesterol = 40,
                Sodium = 500,
                Potassium = 250,
                Calcium = 30,
                Iron = 1.5f,
                VitaminA = 150,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.1f,
                VitaminC = 5,
                VitaminD = 0,
                VitaminE = 0.4f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 167
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("90099162-15e0-4ef0-b93e-59d409678b63"), // Bún ốc
                Calories = 250,
                Protein = 12,
                Carbs = 40,
                Fiber = 1.5f,
                Sugar = 2,
                Fat = 4,
                SaturatedFat = 0.5f,
                UnsaturatedFat = 1.5f,
                Cholesterol = 35,
                Sodium = 400,
                Potassium = 220,
                Calcium = 30,
                Iron = 1.2f,
                VitaminA = 100,
                VitaminB1 = 0.08f,
                VitaminB2 = 0.1f,
                VitaminC = 3,
                VitaminD = 0,
                VitaminE = 0.3f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 168
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("e1a6ae3e-bbb3-4e7f-9d92-55bd38e6fa2f"), // Cháo vịt
                Calories = 130,
                Protein = 7,
                Carbs = 20,
                Fiber = 0.5f,
                Sugar = 0.5f,
                Fat = 3.5f,
                SaturatedFat = 1,
                UnsaturatedFat = 3,
                Cholesterol = 40,
                Sodium = 350,
                Potassium = 200,
                Calcium = 20,
                Iron = 1,
                VitaminA = 50,
                VitaminB1 = 0.06f,
                VitaminB2 = 0.07f,
                VitaminC = 2,
                VitaminD = 0,
                VitaminE = 0.3f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 169
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("9669cdf4-c133-476f-b2bd-f3c091346c52"), // Bánh mì chả cá
                Calories = 300,
                Protein = 14,
                Carbs = 45,
                Fiber = 2,
                Sugar = 4,
                Fat = 8,
                SaturatedFat = 1.5f,
                UnsaturatedFat = 5.5f,
                Cholesterol = 35,
                Sodium = 500,
                Potassium = 200,
                Calcium = 40,
                Iron = 1.2f,
                VitaminA = 100,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.1f,
                VitaminC = 2,
                VitaminD = 0,
                VitaminE = 0.5f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 170
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("61b2c4d9-6de2-4fb2-af3b-fe9fabee0bd4"), // Mì Quảng
                Calories = 320,
                Protein = 15,
                Carbs = 50,
                Fiber = 2,
                Sugar = 3,
                Fat = 7,
                SaturatedFat = 1.5f,
                UnsaturatedFat = 6.5f,
                Cholesterol = 35,
                Sodium = 600,
                Potassium = 250,
                Calcium = 30,
                Iron = 1.5f,
                VitaminA = 200,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.1f,
                VitaminC = 5,
                VitaminD = 0,
                VitaminE = 0.7f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 171
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("af036922-79f3-45a7-b562-a6279520c0e6"), // Miến gà
                Calories = 250,
                Protein = 12,
                Carbs = 40,
                Fiber = 1.5f,
                Sugar = 1,
                Fat = 5,
                SaturatedFat = 0.5f,
                UnsaturatedFat = 1.5f,
                Cholesterol = 25,
                Sodium = 350,
                Potassium = 200,
                Calcium = 15,
                Iron = 0.6f,
                VitaminA = 50,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.07f,
                VitaminC = 3,
                VitaminD = 0,
                VitaminE = 0.2f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 172
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("00bc33fe-4cd5-47df-bd94-15ac9f93648c"), // Súp rau củ
                Calories = 50,
                Protein = 2,
                Carbs = 10,
                Fiber = 2,
                Sugar = 3,
                Fat = 0.5f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.4f,
                Cholesterol = 0,
                Sodium = 250,
                Potassium = 200,
                Calcium = 30,
                Iron = 0.8f,
                VitaminA = 600,
                VitaminB1 = 0.06f,
                VitaminB2 = 0.05f,
                VitaminC = 20f,
                VitaminD = 0,
                VitaminE = 1,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 173
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("7b3935fa-e426-4dcd-b59f-2dbe8960956b"), // Súp bò hầm
                Calories = 120,
                Protein = 10,
                Carbs = 10,
                Fiber = 1.5f,
                Sugar = 2,
                Fat = 5,
                SaturatedFat = 3,
                UnsaturatedFat = 5,
                Cholesterol = 40,
                Sodium = 500,
                Potassium = 250,
                Calcium = 20,
                Iron = 2,
                VitaminA = 50,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.1f,
                VitaminC = 5,
                VitaminD = 0,
                VitaminE = 0.5f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 174
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("3426c7e8-055b-414f-84a3-eb9afdb1d33e"), // Súp gà nấm
                Calories = 100,
                Protein = 6,
                Carbs = 8,
                Fiber = 1,
                Sugar = 1.5f,
                Fat = 4,
                SaturatedFat = 0.5f,
                UnsaturatedFat = 2.5f,
                Cholesterol = 25,
                Sodium = 300,
                Potassium = 200,
                Calcium = 15,
                Iron = 1,
                VitaminA = 50,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.06f,
                VitaminC = 4,
                VitaminD = 0,
                VitaminE = 0.3f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 175
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("ea63d4c3-41f7-4f89-bf33-e8a16c5d6956"), // Súp hải sản
                Calories = 110,
                Protein = 9,
                Carbs = 10,
                Fiber = 1,
                Sugar = 1.5f,
                Fat = 3,
                SaturatedFat = 1,
                UnsaturatedFat = 2,
                Cholesterol = 40,
                Sodium = 450,
                Potassium = 250,
                Calcium = 30,
                Iron = 1,
                VitaminA = 100,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.1f,
                VitaminC = 5,
                VitaminD = 0,
                VitaminE = 0.4f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 176
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("a988cc73-072e-4af1-9b53-55fbf0f4fe79"), // Rau xào
                Calories = 70,
                Protein = 2.5f,
                Carbs = 7,
                Fiber = 3,
                Sugar = 2,
                Fat = 3.5f,
                SaturatedFat = 0.5f,
                UnsaturatedFat = 2.5f,
                Cholesterol = 0,
                Sodium = 200,
                Potassium = 250,
                Calcium = 50,
                Iron = 1.2f,
                VitaminA = 500,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.07f,
                VitaminC = 15,
                VitaminD = 0,
                VitaminE = 2,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 177
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("2ee163f7-4463-44ec-b9e2-8a409c112db4"), // Rau luộc
                Calories = 30,
                Protein = 2,
                Carbs = 6,
                Fiber = 3,
                Sugar = 2,
                Fat = 0.2f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.4f,
                Cholesterol = 0,
                Sodium = 150,
                Potassium = 300,
                Calcium = 40,
                Iron = 0.8f,
                VitaminA = 500,
                VitaminB1 = 0.04f,
                VitaminB2 = 0.05f,
                VitaminC = 20f,
                VitaminD = 0,
                VitaminE = 0.5f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 178
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("01e60ae4-ff69-44d6-b4fd-aaf916e3a7e5"), // Cơm gà xối mỡ
                Calories = 350,
                Protein = 20,
                Carbs = 45,
                Fiber = 1,
                Sugar = 1,
                Fat = 10,
                SaturatedFat = 3,
                UnsaturatedFat = 7,
                Cholesterol = 45,
                Sodium = 600,
                Potassium = 250,
                Calcium = 20,
                Iron = 1,
                VitaminA = 150,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.1f,
                VitaminC = 3,
                VitaminD = 0,
                VitaminE = 0.5f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 179
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("eec3d874-6331-4e33-bbe6-bf0cc4335b29"), // Salad rau
                Calories = 45,
                Protein = 1.5f,
                Carbs = 8,
                Fiber = 3,
                Sugar = 4,
                Fat = 1.5f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.4f,
                Cholesterol = 0,
                Sodium = 50,
                Potassium = 250,
                Calcium = 40,
                Iron = 1,
                VitaminA = 700,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.06f,
                VitaminC = 25,
                VitaminD = 0,
                VitaminE = 1,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 180
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("90a605b6-843d-4cc1-8fe7-a016c76ee29c"), // Rau muống luộc
                Calories = 20,
                Protein = 2.5f,
                Carbs = 3,
                Fiber = 2,
                Sugar = 0.8f,
                Fat = 0.2f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.4f,
                Cholesterol = 0,
                Sodium = 100,
                Potassium = 300,
                Calcium = 40,
                Iron = 0.9f,
                VitaminA = 500,
                VitaminB1 = 0.04f,
                VitaminB2 = 0.05f,
                VitaminC = 30f,
                VitaminD = 0,
                VitaminE = 0.5f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 181
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("56513d2d-2472-4fa4-80bc-2f54002b187f"), // Canh chua cá
                Calories = 70,
                Protein = 8,
                Carbs = 6,
                Fiber = 1.5f,
                Sugar = 3,
                Fat = 2,
                SaturatedFat = 0.5f,
                UnsaturatedFat = 1.5f,
                Cholesterol = 40,
                Sodium = 500,
                Potassium = 250,
                Calcium = 25,
                Iron = 1,
                VitaminA = 100,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.1f,
                VitaminC = 10f,
                VitaminD = 0,
                VitaminE = 0.3f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 182
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("2d821db4-3e99-4877-b979-bc82d34b3b01"), // Bánh mì ốp la
                Calories = 330,
                Protein = 12,
                Carbs = 40,
                Fiber = 2,
                Sugar = 3,
                Fat = 15,
                SaturatedFat = 3,
                UnsaturatedFat = 12,
                Cholesterol = 150,
                Sodium = 500,
                Potassium = 250,
                Calcium = 40,
                Iron = 1.5f,
                VitaminA = 250,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.1f,
                VitaminC = 1,
                VitaminD = 1,
                VitaminE = 0.7f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 183
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("29dfb5da-8818-40ff-bf66-7553521c2161"), // Bò kho
                Calories = 220,
                Protein = 20,
                Carbs = 15,
                Fiber = 2,
                Sugar = 5,
                Fat = 10,
                SaturatedFat = 4,
                UnsaturatedFat = 8,
                Cholesterol = 50,
                Sodium = 600,
                Potassium = 300,
                Calcium = 30,
                Iron = 2.5f,
                VitaminA = 150,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.1f,
                VitaminC = 4,
                VitaminD = 0,
                VitaminE = 1,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 184
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("64e0dca1-abd5-4886-b124-ef0f4a44d0a6"), // Canh rau ngót
                Calories = 30,
                Protein = 2,
                Carbs = 5,
                Fiber = 2,
                Sugar = 1.5f,
                Fat = 0.5f,
                SaturatedFat = 0.2f,
                UnsaturatedFat = 0.8f,
                Cholesterol = 0,
                Sodium = 300,
                Potassium = 250,
                Calcium = 50,
                Iron = 1.2f,
                VitaminA = 400,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.07f,
                VitaminC = 20f,
                VitaminD = 0,
                VitaminE = 0.5f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 185
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("4edcae53-7e30-42bb-8526-7686355f2268"), // Canh cải xanh
                Calories = 25,
                Protein = 2,
                Carbs = 4,
                Fiber = 2,
                Sugar = 1,
                Fat = 0.5f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.4f,
                Cholesterol = 0,
                Sodium = 150,
                Potassium = 300,
                Calcium = 40,
                Iron = 1,
                VitaminA = 500,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.06f,
                VitaminC = 30f,
                VitaminD = 0,
                VitaminE = 0.5f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 186
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("0292d477-d63b-4904-a83b-2cd8cac39c14"), // Canh củ quả
                Calories = 40,
                Protein = 1.5f,
                Carbs = 8,
                Fiber = 2,
                Sugar = 3,
                Fat = 0.5f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.2f,
                Cholesterol = 0,
                Sodium = 250,
                Potassium = 330,
                Calcium = 35,
                Iron = 0.5f,
                VitaminA = 600,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.08f,
                VitaminC = 45,
                VitaminD = 0,
                VitaminE = 0.7f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 187
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("b80c562a-e1d4-4117-a317-c06b5bae8950"), // Thịt heo kho
                Calories = 250,
                Protein = 20,
                Carbs = 8,
                Fiber = 0,
                Sugar = 5,
                Fat = 15,
                SaturatedFat = 6.5f,
                UnsaturatedFat = 10.5f,
                Cholesterol = 70,
                Sodium = 530,
                Potassium = 330,
                Calcium = 15,
                Iron = 1.2f,
                VitaminA = 45,
                VitaminB1 = 0.8f,
                VitaminB2 = 0.2f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.3f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 188
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("99ec20c3-f2a7-4727-9d12-a30f92d256cd"), // Rau muống xào tỏi
                Calories = 70,
                Protein = 3,
                Carbs = 6,
                Fiber = 2,
                Sugar = 1,
                Fat = 4,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.5f,
                Cholesterol = 0,
                Sodium = 250,
                Potassium = 450,
                Calcium = 55,
                Iron = 1,
                VitaminA = 700,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.1f,
                VitaminC = 45,
                VitaminD = 0,
                VitaminE = 1.2f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 189
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("3dc2fa80-ab87-4e26-907b-3516611371b8"), // Canh bầu
                Calories = 25,
                Protein = 1,
                Carbs = 5,
                Fiber = 1.5f,
                Sugar = 2,
                Fat = 0.3f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.1f,
                Cholesterol = 0,
                Sodium = 125,
                Potassium = 140,
                Calcium = 16,
                Iron = 0.3f,
                VitaminA = 20,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.06f,
                VitaminC = 12,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 190
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("2c990331-b6ca-4642-893a-be68f0d398d5"), // Rau cải xanh
                Calories = 25,
                Protein = 2.5f,
                Carbs = 4,
                Fiber = 2.5f,
                Sugar = 1,
                Fat = 0.3f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.3f,
                Cholesterol = 0,
                Sodium = 50,
                Potassium = 296,
                Calcium = 150,
                Iron = 1.6f,
                VitaminA = 740,
                VitaminB1 = 0.07f,
                VitaminB2 = 0.09f,
                VitaminC = 55,
                VitaminD = 0,
                VitaminE = 1.2f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 191
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("f0e4a066-b920-4540-a035-1a5504ff1358"), // Mận
                Calories = 46,
                Protein = 0.7f,
                Carbs = 11,
                Fiber = 1.4f,
                Sugar = 10,
                Fat = 0.3f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.3f,
                Cholesterol = 0,
                Sodium = 0,
                Potassium = 157,
                Calcium = 6,
                Iron = 0.2f,
                VitaminA = 0,
                VitaminB1 = 0.03f,
                VitaminB2 = 0.04f,
                VitaminC = 9.5f,
                VitaminD = 0,
                VitaminE = 0.4f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 192
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("c9cb635f-b21e-4b04-9ac9-84d01f2ef42b"), // Chôm chôm
                Calories = 82,
                Protein = 0.9f,
                Carbs = 20,
                Fiber = 1.3f,
                Sugar = 14,
                Fat = 0.3f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.2f,
                Cholesterol = 0,
                Sodium = 0,
                Potassium = 42,
                Calcium = 22,
                Iron = 0.3f,
                VitaminA = 0,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.05f,
                VitaminC = 20f,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 193
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("982d8f3e-f517-4bd2-87a8-48329fc9eb91"), // Canh cải ngọt
                Calories = 25,
                Protein = 1.8f,
                Carbs = 4,
                Fiber = 1.5f,
                Sugar = 1,
                Fat = 0.3f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.3f,
                Cholesterol = 0,
                Sodium = 60,
                Potassium = 260,
                Calcium = 130,
                Iron = 0.8f,
                VitaminA = 560,
                VitaminB1 = 0.06f,
                VitaminB2 = 0.08f,
                VitaminC = 35,
                VitaminD = 0,
                VitaminE = 0.5f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 194
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("43d635e2-6f0c-4385-83d8-fedfd479d356"), // Thịt gà kho
                Calories = 210,
                Protein = 25,
                Carbs = 6,
                Fiber = 0,
                Sugar = 3,
                Fat = 10,
                SaturatedFat = 1,
                UnsaturatedFat = 2.6f,
                Cholesterol = 85,
                Sodium = 340,
                Potassium = 220,
                Calcium = 15,
                Iron = 1,
                VitaminA = 20,
                VitaminB1 = 0.08f,
                VitaminB2 = 0.07f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.4f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 195
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("8ed85dc2-7654-4c48-81f9-19946a73f71d"), // Bắp cải luộc
                Calories = 25,
                Protein = 1.3f,
                Carbs = 5,
                Fiber = 2.5f,
                Sugar = 2.8f,
                Fat = 0.1f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.1f,
                Cholesterol = 0,
                Sodium = 18,
                Potassium = 170,
                Calcium = 40,
                Iron = 0.5f,
                VitaminA = 75,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.04f,
                VitaminC = 36,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 196
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("881ae045-1c9a-4e20-9160-0e8c14486be5"), // Canh mùng tơi mướp
                Calories = 30,
                Protein = 1.5f,
                Carbs = 5,
                Fiber = 2,
                Sugar = 2,
                Fat = 0.5f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.2f,
                Cholesterol = 0,
                Sodium = 80,
                Potassium = 250,
                Calcium = 35,
                Iron = 0.5f,
                VitaminA = 650,
                VitaminB1 = 0.04f,
                VitaminB2 = 0.05f,
                VitaminC = 20f,
                VitaminD = 0,
                VitaminE = 0.4f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 197
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("b42e9ba6-8aa7-419a-907f-ec7e21cb9337"), // Canh rau dền
                Calories = 30,
                Protein = 2,
                Carbs = 5,
                Fiber = 2.5f,
                Sugar = 1,
                Fat = 0.5f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.2f,
                Cholesterol = 0,
                Sodium = 25,
                Potassium = 250,
                Calcium = 40,
                Iron = 1,
                VitaminA = 450,
                VitaminB1 = 0.07f,
                VitaminB2 = 0.08f,
                VitaminC = 25,
                VitaminD = 0,
                VitaminE = 0.4f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 198
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("b9ac5dae-d139-4ba1-a8e0-fe0e16719df9"), // Cơm chiên
                Calories = 180,
                Protein = 4,
                Carbs = 35,
                Fiber = 0.5f,
                Sugar = 0.5f,
                Fat = 3,
                SaturatedFat = 1,
                UnsaturatedFat = 5.5f,
                Cholesterol = 25,
                Sodium = 400,
                Potassium = 120,
                Calcium = 20,
                Iron = 0.7f,
                VitaminA = 50,
                VitaminB1 = 0.08f,
                VitaminB2 = 0.05f,
                VitaminC = 1,
                VitaminD = 0,
                VitaminE = 0.2f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 199
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("e370081a-c0a6-4c00-b01c-7c52f953b7f1"), // Canh mướp
                Calories = 20,
                Protein = 0.8f,
                Carbs = 4,
                Fiber = 1.5f,
                Sugar = 2,
                Fat = 0.2f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.1f,
                Cholesterol = 0,
                Sodium = 50,
                Potassium = 150,
                Calcium = 20,
                Iron = 0.2f,
                VitaminA = 50,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.04f,
                VitaminC = 12,
                VitaminD = 0,
                VitaminE = 0.2f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 200
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("9acdf58c-c37d-4026-a3f9-40fda186184b"), // Cải ngọt luộc
                Calories = 20,
                Protein = 1.8f,
                Carbs = 3.5f,
                Fiber = 1.5f,
                Sugar = 1,
                Fat = 0.2f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.2f,
                Cholesterol = 0,
                Sodium = 40,
                Potassium = 140,
                Calcium = 130,
                Iron = 1,
                VitaminA = 800,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.07f,
                VitaminC = 40f,
                VitaminD = 0,
                VitaminE = 0.4f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 201
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("b79878e6-36d9-4efc-b3ff-a3c45b35ff21"), // Cá kho
                Calories = 180,
                Protein = 20,
                Carbs = 5,
                Fiber = 0,
                Sugar = 3,
                Fat = 10,
                SaturatedFat = 1.5f,
                UnsaturatedFat = 5.5f,
                Cholesterol = 50,
                Sodium = 350,
                Potassium = 300,
                Calcium = 25,
                Iron = 1.5f,
                VitaminA = 80,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.07f,
                VitaminC = 2,
                VitaminD = 0.5f,
                VitaminE = 0.3f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 202
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("8382816f-1beb-4804-9698-3b486798b20a"), // Bánh mì chả lụa
                Calories = 320,
                Protein = 15,
                Carbs = 48,
                Fiber = 3,
                Sugar = 4,
                Fat = 9,
                SaturatedFat = 3,
                UnsaturatedFat = 7,
                Cholesterol = 25,
                Sodium = 450,
                Potassium = 250,
                Calcium = 50,
                Iron = 1,
                VitaminA = 100,
                VitaminB1 = 0.2f,
                VitaminB2 = 0.1f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.5f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 203
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("2405ffc3-524e-4331-9e68-47a411d7b9b8"), // Cơm chiên dương châu
                Calories = 380,
                Protein = 16,
                Carbs = 60,
                Fiber = 3,
                Sugar = 3,
                Fat = 10,
                SaturatedFat = 1.5f,
                UnsaturatedFat = 4.5f,
                Cholesterol = 30,
                Sodium = 500,
                Potassium = 150,
                Calcium = 40,
                Iron = 1,
                VitaminA = 100,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.08f,
                VitaminC = 5,
                VitaminD = 0,
                VitaminE = 0.4f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            // #region Nutrition 204
            // new Nutrition
            // {
            //     NutritionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("a1ff09f1-9d02-40a8-84de-8da9aad67c58"), // Cơm rang
            //     Calories = 170,
            //     Protein = 4,
            //     Carbs = 23,
            //     Fiber = 1,
            //     Sugar = 1,
            //     Fat = 7,
            //     SaturatedFat = 1,
            //     UnsaturatedFat = 6,
            //     Cholesterol = 15,
            //     Sodium = 350,
            //     Potassium = 150,
            //     Calcium = 20,
            //     Iron = 0.7f,
            //     VitaminA = 50,
            //     VitaminB1 = 0.05f,
            //     VitaminB2 = 0.05f,
            //     VitaminC = 0,
            //     VitaminD = 0,
            //     VitaminE = 0.2f,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            // },
            // #endregion

            #region Nutrition 205
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("2146faae-2e7c-4460-8d81-38f5d313012c"), // Cháo đậu xanh
                Calories = 180,
                Protein = 8,
                Carbs = 35,
                Fiber = 6,
                Sugar = 1,
                Fat = 1,
                SaturatedFat = 0.2f,
                UnsaturatedFat = 1.3f,
                Cholesterol = 0,
                Sodium = 150,
                Potassium = 260,
                Calcium = 40,
                Iron = 1,
                VitaminA = 0,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.05f,
                VitaminC = 1,
                VitaminD = 0,
                VitaminE = 0.3f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            // #region Nutrition 206
            // new Nutrition
            // {
            //     NutritionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("7a253877-3c54-4fcf-bb05-d9f4e14d5b64"), // Mì xào thập cẩm
            //     Calories = 200,
            //     Protein = 7.5f,
            //     Carbs = 30f,
            //     Fiber = 2,
            //     Sugar = 3,
            //     Fat = 7,
            //     SaturatedFat = 1.5f,
            //     UnsaturatedFat = 5.5f,
            //     Cholesterol = 20,
            //     Sodium = 600,
            //     Potassium = 200,
            //     Calcium = 40,
            //     Iron = 1.2f,
            //     VitaminA = 100,
            //     VitaminB1 = 0.1f,
            //     VitaminB2 = 0.1f,
            //     VitaminC = 10f,
            //     VitaminD = 0,
            //     VitaminE = 0.5f,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            // },
            // #endregion

            #region Nutrition 207
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("a950000c-9837-4d1b-b1ae-b9db230f8f1f"), // Súp khoai tây
                Calories = 150,
                Protein = 4,
                Carbs = 25,
                Fiber = 3,
                Sugar = 3,
                Fat = 5,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.4f,
                Cholesterol = 0,
                Sodium = 350,
                Potassium = 350,
                Calcium = 15,
                Iron = 0.6f,
                VitaminA = 20,
                VitaminB1 = 0.06f,
                VitaminB2 = 0.05f,
                VitaminC = 10f,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            // #region Nutrition 208
            // new Nutrition
            // {
            //     NutritionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("30f9d9dc-1653-495c-99b7-b649c49f7930"), // Bánh cuốn thịt bằm
            //     Calories = 130,
            //     Protein = 6,
            //     Carbs = 18,
            //     Fiber = 1,
            //     Sugar = 1,
            //     Fat = 4.5f,
            //     SaturatedFat = 1.5f,
            //     UnsaturatedFat = 3,
            //     Cholesterol = 20,
            //     Sodium = 500,
            //     Potassium = 180,
            //     Calcium = 30,
            //     Iron = 1.2f,
            //     VitaminA = 50,
            //     VitaminB1 = 0.1f,
            //     VitaminB2 = 0.1f,
            //     VitaminC = 2,
            //     VitaminD = 0,
            //     VitaminE = 0.3f,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            // },
            // #endregion

            #region Nutrition 209
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("a364353c-d589-4a94-9c3b-3038113ea249"), // Bò xào rau củ
                Calories = 280,
                Protein = 25,
                Carbs = 15,
                Fiber = 5,
                Sugar = 5,
                Fat = 12,
                SaturatedFat = 2.5f,
                UnsaturatedFat = 5.5f,
                Cholesterol = 55,
                Sodium = 350,
                Potassium = 350,
                Calcium = 30,
                Iron = 2.5f,
                VitaminA = 150,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.1f,
                VitaminC = 25,
                VitaminD = 0,
                VitaminE = 1,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            // #region Nutrition 210
            // new Nutrition
            // {
            //     NutritionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("cf9ab10f-2094-496b-9018-96b9d2e1af76"), // Cơm gà
            //     Calories = 150,
            //     Protein = 10.5f,
            //     Carbs = 18,
            //     Fiber = 1,
            //     Sugar = 1.5f,
            //     Fat = 4,
            //     SaturatedFat = 1,
            //     UnsaturatedFat = 3,
            //     Cholesterol = 40,
            //     Sodium = 400,
            //     Potassium = 250,
            //     Calcium = 30,
            //     Iron = 1,
            //     VitaminA = 40,
            //     VitaminB1 = 0.1f,
            //     VitaminB2 = 0.1f,
            //     VitaminC = 5,
            //     VitaminD = 0,
            //     VitaminE = 0.3f,
            //     CreatedAt = today,
            //     UpdatedAt = today,
            // },
            // #endregion

            #region Nutrition 211
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("8c9e1c76-2616-43a4-8c80-3e2e23b8ac4f"), // Bánh hỏi
                Calories = 200,
                Protein = 5,
                Carbs = 40,
                Fiber = 1,
                Sugar = 1,
                Fat = 2,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.4f,
                Cholesterol = 0,
                Sodium = 250,
                Potassium = 120,
                Calcium = 15,
                Iron = 0.5f,
                VitaminA = 0,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.1f,
                VitaminC = 0,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 212
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("87cdf191-876c-4270-92f9-4bb1fc2a7fe9"), // Canh bí đỏ nấu tôm
                Calories = 110,
                Protein = 10,
                Carbs = 15,
                Fiber = 3,
                Sugar = 5,
                Fat = 2,
                SaturatedFat = 0.2f,
                UnsaturatedFat = 0.8f,
                Cholesterol = 40,
                Sodium = 300,
                Potassium = 230,
                Calcium = 40,
                Iron = 0.5f,
                VitaminA = 850,
                VitaminB1 = 0.05f,
                VitaminB2 = 0.07f,
                VitaminC = 15,
                VitaminD = 0,
                VitaminE = 0.5f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 213
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("3d19d971-88d0-4108-a335-24ac9e1dec50"), // Măng cụt
                Calories = 65,
                Protein = 0.5f,
                Carbs = 16,
                Fiber = 6,
                Sugar = 14,
                Fat = 0.5f,
                SaturatedFat = 0.1f,
                UnsaturatedFat = 0.5f,
                Cholesterol = 0,
                Sodium = 10,
                Potassium = 42,
                Calcium = 12,
                Iron = 0.3f,
                VitaminA = 0,
                VitaminB1 = 0.04f,
                VitaminB2 = 0.05f,
                VitaminC = 5,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 214
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("a504d882-4f38-413e-bb28-fae1f2787150"), // Nhãn
                Calories = 65,
                Protein = 1.2f,
                Carbs = 16,
                Fiber = 1.3f,
                Sugar = 13,
                Fat = 0.3f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.1f,
                Cholesterol = 0,
                Sodium = 1,
                Potassium = 42,
                Calcium = 9,
                Iron = 0.3f,
                VitaminA = 0,
                VitaminB1 = 0.03f,
                VitaminB2 = 0.05f,
                VitaminC = 10f,
                VitaminD = 0,
                VitaminE = 0.1f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 215
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("9f624258-a4ee-4879-a23f-b3d0479f2b1b"), // Cam
                Calories = 65,
                Protein = 1.3f,
                Carbs = 16,
                Fiber = 3.5f,
                Sugar = 13,
                Fat = 0.2f,
                SaturatedFat = 0,
                UnsaturatedFat = 0.2f,
                Cholesterol = 0,
                Sodium = 1,
                Potassium = 181,
                Calcium = 40,
                Iron = 0.1f,
                VitaminA = 0,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.04f,
                VitaminC = 53.2f,
                VitaminD = 0,
                VitaminE = 0.2f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 216
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("d034b7e9-b5a2-42d7-95b7-c0c30207293d"), // Canh hẹ tôm
                Calories = 80,
                Protein = 8,
                Carbs = 5,
                Fiber = 1.5f,
                Sugar = 1,
                Fat = 2,
                SaturatedFat = 0.3f,
                UnsaturatedFat = 1.2f,
                Cholesterol = 30,
                Sodium = 250,
                Potassium = 180,
                Calcium = 20,
                Iron = 0.7f,
                VitaminA = 100,
                VitaminB1 = 0.07f,
                VitaminB2 = 0.05f,
                VitaminC = 8,
                VitaminD = 0,
                VitaminE = 0.4f,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Nutrition 217
            new Nutrition
            {
                NutritionId = Guid.NewGuid(),
                FoodId = Guid.Parse("85e621ed-0e0c-4d20-8891-51d311cea4a3"), // Canh thịt bò hầm
                Calories = 180,
                Protein = 20,
                Carbs = 10,
                Fiber = 2.5f,
                Sugar = 3,
                Fat = 8,
                SaturatedFat = 1.5f,
                UnsaturatedFat = 3,
                Cholesterol = 50,
                Sodium = 400,
                Potassium = 250,
                Calcium = 30,
                Iron = 2,
                VitaminA = 40,
                VitaminB1 = 0.1f,
                VitaminB2 = 0.1f,
                VitaminC = 4,
                VitaminD = 0,
                VitaminE = 0.5f,
                CreatedAt = today,
                UpdatedAt = today,
            }
            #endregion
            );
        }
    }
}
