using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class PortionConfiguration : IEntityTypeConfiguration<Portion>
    {
        public void Configure(EntityTypeBuilder<Portion> builder)
        {
            builder.HasData(
            #region Portion 1
    new Portion
    {
        PortionId = Guid.Parse("1808de3e-ae43-41a6-b9ce-bfe89131be5a"),
        PortionSize = "chén",
        PortionWeight = 100,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 2
    new Portion
    {
        PortionId = Guid.Parse("40991196-f258-43f1-ac84-0381afa83477"),
        PortionSize = "tô",
        PortionWeight = 300,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 3
    new Portion
    {
        PortionId = Guid.Parse("28b06cf6-6367-4786-bccb-89c43dd3ce3a"),
        PortionSize = "quả nhỏ",
        PortionWeight = 81,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 4
    new Portion
    {
        PortionId = Guid.Parse("91524cc2-db22-4cab-abb7-700725232f1f"),
        PortionSize = "quả vừa",
        PortionWeight = 118,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 5
    new Portion
    {
        PortionId = Guid.Parse("1b56833b-1ff5-4a90-aea9-074de2d0dd67"),
        PortionSize = "quả lớn",
        PortionWeight = 136,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 6
    new Portion
    {
        PortionId = Guid.Parse("c605aa91-495e-4977-9876-b2a198ce356e"),
        PortionSize = "quả nhỏ",
        PortionWeight = 38,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 7
    new Portion
    {
        PortionId = Guid.Parse("7be0e4d3-1e50-4de1-931d-08adb85f628b"),
        PortionSize = "quả vừa",
        PortionWeight = 44,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 8
    new Portion
    {
        PortionId = Guid.Parse("698c67ad-a726-435b-b9d2-c5690a79eb5a"),
        PortionSize = "quả lớn",
        PortionWeight = 50,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 9
    new Portion
    {
        PortionId = Guid.Parse("399eee61-90b5-464f-b3f7-7ddc1077ab0d"),
        PortionSize = "hộp",
        PortionWeight = 110,
        MeasurementUnit = "ml",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 10
    new Portion
    {
        PortionId = Guid.Parse("6f34350b-8f99-446e-9de9-e0c6277b10f3"),
        PortionSize = "hộp",
        PortionWeight = 180,
        MeasurementUnit = "ml",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 11
    new Portion
    {
        PortionId = Guid.Parse("41ae956e-14fc-44af-bc6a-e5ba77661cee"),
        PortionSize = "tô",
        PortionWeight = 350,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 12
    new Portion
    {
        PortionId = Guid.Parse("a1589990-affa-4805-a1e0-73de1ffa8516"),
        PortionSize = "trái",
        PortionWeight = 150,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 13
    new Portion
    {
        PortionId = Guid.Parse("4e9013c8-d6f7-4740-80d5-e95d318873b9"),
        PortionSize = "tô",
        PortionWeight = 300,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 14
    new Portion
    {
        PortionId = Guid.Parse("1bf9c3e0-7a2c-46f5-8187-82e5ad1af649"),
        PortionSize = "miếng",
        PortionWeight = 150,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 15
    new Portion
    {
        PortionId = Guid.Parse("faec7c41-2e11-4092-8ab9-cc9c152d858f"),
        PortionSize = "cây",
        PortionWeight = 35,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 16
    new Portion
    {
        PortionId = Guid.Parse("268e00a0-2da3-4e5c-8ea7-5ad8923cfd52"),
        PortionSize = "trái",
        PortionWeight = 164,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 17
    new Portion
    {
        PortionId = Guid.Parse("40bbc8c4-f383-4ae6-979a-3ac83c275881"),
        PortionSize = "cốc",
        PortionWeight = 240,
        MeasurementUnit = "ml",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 18
    new Portion
    {
        PortionId = Guid.Parse("de5d78a3-c5b1-4e2a-b9eb-f3757c999024"),
        PortionSize = "cái",
        PortionWeight = 50,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 19
    new Portion
    {
        PortionId = Guid.Parse("92e149ff-8491-48cf-a4e8-8106b1e95c4c"),
        PortionSize = "cốc",
        PortionWeight = 200,
        MeasurementUnit = "ml",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 20
    new Portion
    {
        PortionId = Guid.Parse("3f77fd90-591c-45f3-8bbc-87d0bb49e461"),
        PortionSize = "tô",
        PortionWeight = 250,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 21
    new Portion
    {
        PortionId = Guid.Parse("6792c392-3c86-4162-be91-4fc8646f861d"),
        PortionSize = "ly",
        PortionWeight = 100,
        MeasurementUnit = "ml",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 22
    new Portion
    {
        PortionId = Guid.Parse("c4fc900f-5a92-4228-ac03-57285fff159e"),
        PortionSize = "đĩa vừa",
        PortionWeight = 350,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 23
    new Portion
    {
        PortionId = Guid.Parse("cd0a9e6f-bf5b-40b3-bb6c-22ccb8e6ab6a"),
        PortionSize = "hộp",
        PortionWeight = 180,
        MeasurementUnit = "ml",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 24
    new Portion
    {
        PortionId = Guid.Parse("a33065fe-80ad-4879-9333-424aadc6734f"),
        PortionSize = "tô",
        PortionWeight = 350,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 25
    new Portion
    {
        PortionId = Guid.Parse("eceaaa32-4023-4eab-abb6-9172c908f77c"),
        PortionSize = "tô",
        PortionWeight = 250,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 26
    new Portion
    {
        PortionId = Guid.Parse("31e9bda5-8ec3-4444-a23a-908e84da6a14"),
        PortionSize = "cốc",
        PortionWeight = 240,
        MeasurementUnit = "ml",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 27
    new Portion
    {
        PortionId = Guid.Parse("93984b54-2044-4ea9-8364-a03c6568e358"),
        PortionSize = "tô",
        PortionWeight = 330,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 28
    new Portion
    {
        PortionId = Guid.Parse("749b288c-112b-4b7b-8750-0daff63d9ab3"),
        PortionSize = "tô",
        PortionWeight = 228,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 29
    new Portion
    {
        PortionId = Guid.Parse("1500876f-ef20-40de-baae-de0336bdc47b"),
        PortionSize = "cốc",
        PortionWeight = 240,
        MeasurementUnit = "ml",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 30
    new Portion
    {
        PortionId = Guid.Parse("e4e4252f-ad38-4190-aba5-8989e3cca994"),
        PortionSize = "miếng",
        PortionWeight = 114,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 31
    new Portion
    {
        PortionId = Guid.Parse("24a4ed15-69e4-4fb5-8dd2-1695de52c264"),
        PortionSize = "cái",
        PortionWeight = 100,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 32
    new Portion
    {
        PortionId = Guid.Parse("bfc705ab-d7e9-44c9-9447-c0b39bc76ca1"),
        PortionSize = "tô",
        PortionWeight = 250,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 33
    new Portion
    {
        PortionId = Guid.Parse("b6623163-4c27-4d0c-99ef-12a67b87635f"),
        PortionSize = "tô",
        PortionWeight = 350,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 34
    new Portion
    {
        PortionId = Guid.Parse("a88faa7c-6eab-4ecb-8a75-b078a9cf7834"),
        PortionSize = "củ",
        PortionWeight = 150,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 35
    new Portion
    {
        PortionId = Guid.Parse("3d7eafa9-9fcc-4f49-b8fb-2a5c629ae6eb"),
        PortionSize = "cái",
        PortionWeight = 50,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 36
    new Portion
    {
        PortionId = Guid.Parse("22f0a09e-6816-410e-a5a2-c802103b089b"),
        PortionSize = "đĩa",
        PortionWeight = 200,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 37
    new Portion
    {
        PortionId = Guid.Parse("5feca670-1f15-430d-9b04-7ac86a329a6c"),
        PortionSize = "ly",
        PortionWeight = 100,
        MeasurementUnit = "ml",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 38
    new Portion
    {
        PortionId = Guid.Parse("f483bb75-84f0-4ecc-8a06-f366a488c6bf"),
        PortionSize = "hộp",
        PortionWeight = 116,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 39
    new Portion
    {
        PortionId = Guid.Parse("a9385e8a-e9b9-484f-beeb-bc35529cf91a"),
        PortionSize = "tô",
        PortionWeight = 330,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 40
    new Portion
    {
        PortionId = Guid.Parse("8a81e20e-ea16-4073-957e-29508a8f7419"),
        PortionSize = "củ",
        PortionWeight = 150,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("27-12-2024", "dd-MM-yyyy", null),
    }
#endregion
            );
        }
    }
}
