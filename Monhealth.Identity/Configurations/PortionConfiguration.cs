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
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 2
    new Portion
    {
        PortionId = Guid.Parse("40991196-f258-43f1-ac84-0381afa83477"),
        PortionSize = "tô",
        PortionWeight = 300,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 3
    new Portion
    {
        PortionId = Guid.Parse("28b06cf6-6367-4786-bccb-89c43dd3ce3a"),
        PortionSize = "quả nhỏ",
        PortionWeight = 81,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 4
    new Portion
    {
        PortionId = Guid.Parse("91524cc2-db22-4cab-abb7-700725232f1f"),
        PortionSize = "quả vừa",
        PortionWeight = 118,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 5
    new Portion
    {
        PortionId = Guid.Parse("1b56833b-1ff5-4a90-aea9-074de2d0dd67"),
        PortionSize = "quả lớn",
        PortionWeight = 136,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 6
    new Portion
    {
        PortionId = Guid.Parse("c605aa91-495e-4977-9876-b2a198ce356e"),
        PortionSize = "quả nhỏ",
        PortionWeight = 38,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 7
    new Portion
    {
        PortionId = Guid.Parse("7be0e4d3-1e50-4de1-931d-08adb85f628b"),
        PortionSize = "quả vừa",
        PortionWeight = 44,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 8
    new Portion
    {
        PortionId = Guid.Parse("698c67ad-a726-435b-b9d2-c5690a79eb5a"),
        PortionSize = "quả lớn",
        PortionWeight = 50,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 9
    new Portion
    {
        PortionId = Guid.Parse("399eee61-90b5-464f-b3f7-7ddc1077ab0d"),
        PortionSize = "hộp",
        PortionWeight = 110,
        MeasurementUnit = "ml",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 10
    new Portion
    {
        PortionId = Guid.Parse("6f34350b-8f99-446e-9de9-e0c6277b10f3"),
        PortionSize = "hộp",
        PortionWeight = 180,
        MeasurementUnit = "ml",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 11
    new Portion
    {
        PortionId = Guid.Parse("41ae956e-14fc-44af-bc6a-e5ba77661cee"),
        PortionSize = "tô",
        PortionWeight = 350,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 12
    new Portion
    {
        PortionId = Guid.Parse("a1589990-affa-4805-a1e0-73de1ffa8516"),
        PortionSize = "trái",
        PortionWeight = 150,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 13
    new Portion
    {
        PortionId = Guid.Parse("4e9013c8-d6f7-4740-80d5-e95d318873b9"),
        PortionSize = "tô",
        PortionWeight = 300,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 14
    new Portion
    {
        PortionId = Guid.Parse("1bf9c3e0-7a2c-46f5-8187-82e5ad1af649"),
        PortionSize = "miếng",
        PortionWeight = 150,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 15
    new Portion
    {
        PortionId = Guid.Parse("faec7c41-2e11-4092-8ab9-cc9c152d858f"),
        PortionSize = "cây nhỏ",
        PortionWeight = 35,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 16
    new Portion
    {
        PortionId = Guid.Parse("36398f6d-0668-4d37-8850-9f9ee89b8b92"),
        PortionSize = "cây vừa",
        PortionWeight = 70,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 17
    new Portion
    {
        PortionId = Guid.Parse("c6e853f0-06bd-4cda-8b43-cbe66fea98c8"),
        PortionSize = "cây to",
        PortionWeight = 150,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 18
    new Portion
    {
        PortionId = Guid.Parse("268e00a0-2da3-4e5c-8ea7-5ad8923cfd52"),
        PortionSize = "trái",
        PortionWeight = 164,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 19
    new Portion
    {
        PortionId = Guid.Parse("40bbc8c4-f383-4ae6-979a-3ac83c275881"),
        PortionSize = "cốc",
        PortionWeight = 240,
        MeasurementUnit = "ml",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 20
    new Portion
    {
        PortionId = Guid.Parse("26096793-894d-47c1-a06f-cf9133f8089d"),
        PortionSize = "hộp",
        PortionWeight = 150,
        MeasurementUnit = "ml",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 21
    new Portion
    {
        PortionId = Guid.Parse("de5d78a3-c5b1-4e2a-b9eb-f3757c999024"),
        PortionSize = "cái",
        PortionWeight = 50,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 22
    new Portion
    {
        PortionId = Guid.Parse("92e149ff-8491-48cf-a4e8-8106b1e95c4c"),
        PortionSize = "cốc",
        PortionWeight = 200,
        MeasurementUnit = "ml",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 23
    new Portion
    {
        PortionId = Guid.Parse("3f77fd90-591c-45f3-8bbc-87d0bb49e461"),
        PortionSize = "tô",
        PortionWeight = 250,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 24
    new Portion
    {
        PortionId = Guid.Parse("6792c392-3c86-4162-be91-4fc8646f861d"),
        PortionSize = "ly",
        PortionWeight = 100,
        MeasurementUnit = "ml",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 25
    new Portion
    {
        PortionId = Guid.Parse("c4fc900f-5a92-4228-ac03-57285fff159e"),
        PortionSize = "đĩa vừa",
        PortionWeight = 350,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 26
    new Portion
    {
        PortionId = Guid.Parse("cd0a9e6f-bf5b-40b3-bb6c-22ccb8e6ab6a"),
        PortionSize = "hộp",
        PortionWeight = 180,
        MeasurementUnit = "ml",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 27
    new Portion
    {
        PortionId = Guid.Parse("a33065fe-80ad-4879-9333-424aadc6734f"),
        PortionSize = "tô",
        PortionWeight = 350,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 28
    new Portion
    {
        PortionId = Guid.Parse("eceaaa32-4023-4eab-abb6-9172c908f77c"),
        PortionSize = "tô",
        PortionWeight = 250,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 29
    new Portion
    {
        PortionId = Guid.Parse("31e9bda5-8ec3-4444-a23a-908e84da6a14"),
        PortionSize = "cốc",
        PortionWeight = 240,
        MeasurementUnit = "ml",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 30
    new Portion
    {
        PortionId = Guid.Parse("93984b54-2044-4ea9-8364-a03c6568e358"),
        PortionSize = "tô",
        PortionWeight = 330,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 31
    new Portion
    {
        PortionId = Guid.Parse("749b288c-112b-4b7b-8750-0daff63d9ab3"),
        PortionSize = "tô",
        PortionWeight = 228,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 32
    new Portion
    {
        PortionId = Guid.Parse("1500876f-ef20-40de-baae-de0336bdc47b"),
        PortionSize = "cốc",
        PortionWeight = 240,
        MeasurementUnit = "ml",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 33
    new Portion
    {
        PortionId = Guid.Parse("e4e4252f-ad38-4190-aba5-8989e3cca994"),
        PortionSize = "miếng",
        PortionWeight = 114,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 34
    new Portion
    {
        PortionId = Guid.Parse("24a4ed15-69e4-4fb5-8dd2-1695de52c264"),
        PortionSize = "cái",
        PortionWeight = 100,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 35
    new Portion
    {
        PortionId = Guid.Parse("bfc705ab-d7e9-44c9-9447-c0b39bc76ca1"),
        PortionSize = "tô",
        PortionWeight = 250,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 36
    new Portion
    {
        PortionId = Guid.Parse("b6623163-4c27-4d0c-99ef-12a67b87635f"),
        PortionSize = "tô",
        PortionWeight = 350,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 37
    new Portion
    {
        PortionId = Guid.Parse("a88faa7c-6eab-4ecb-8a75-b078a9cf7834"),
        PortionSize = "củ nhỏ",
        PortionWeight = 110,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 38
    new Portion
    {
        PortionId = Guid.Parse("218b9709-852d-4a1f-ad8b-c9410b49fea6"),
        PortionSize = "củ vừa",
        PortionWeight = 200,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 39
    new Portion
    {
        PortionId = Guid.Parse("e5cc2785-6d62-4b5f-8fc1-e6ab45babd76"),
        PortionSize = "củ to",
        PortionWeight = 300,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 40
    new Portion
    {
        PortionId = Guid.Parse("3d7eafa9-9fcc-4f49-b8fb-2a5c629ae6eb"),
        PortionSize = "cái",
        PortionWeight = 50,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 41
    new Portion
    {
        PortionId = Guid.Parse("22f0a09e-6816-410e-a5a2-c802103b089b"),
        PortionSize = "đĩa",
        PortionWeight = 200,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 42
    new Portion
    {
        PortionId = Guid.Parse("5feca670-1f15-430d-9b04-7ac86a329a6c"),
        PortionSize = "ly",
        PortionWeight = 100,
        MeasurementUnit = "ml",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 43
    new Portion
    {
        PortionId = Guid.Parse("f483bb75-84f0-4ecc-8a06-f366a488c6bf"),
        PortionSize = "khúc nhỏ",
        PortionWeight = 120,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 44
    new Portion
    {
        PortionId = Guid.Parse("17c9d30f-bd85-4e58-bfc0-6b6d70b2e5fe"),
        PortionSize = "khúc vừa",
        PortionWeight = 300,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 45
    new Portion
    {
        PortionId = Guid.Parse("52c86d57-0909-41c3-b513-e770e6f6d104"),
        PortionSize = "khúc to",
        PortionWeight = 600,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 46
    new Portion
    {
        PortionId = Guid.Parse("a9385e8a-e9b9-484f-beeb-bc35529cf91a"),
        PortionSize = "tô",
        PortionWeight = 330,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 47
    new Portion
    {
        PortionId = Guid.Parse("8a81e20e-ea16-4073-957e-29508a8f7419"),
        PortionSize = "củ",
        PortionWeight = 150,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },

            #endregion

            // NEW
            #region Portion 48
    new Portion
    {
        PortionId = Guid.Parse("84793ef9-fcd0-42df-ab0d-9380dfa18630"),
        PortionSize = "ổ",
        PortionWeight = 110,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 49
    new Portion
    {
        PortionId = Guid.Parse("255ba0f6-14cc-4049-add8-138f27055b49"),
        PortionSize = "đĩa",
        PortionWeight = 220,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 50
    new Portion
    {
        PortionId = Guid.Parse("f7b36043-9ca9-42c3-8a00-e9e235b56bb3"),
        PortionSize = "ly",
        PortionWeight = 200,
        MeasurementUnit = "ml",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 51
    new Portion
    {
        PortionId = Guid.Parse("18809fb3-b78a-4f67-b9f9-8bb6ab95ab00"),
        PortionSize = "cái",
        PortionWeight = 130,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 52
    new Portion
    {
        PortionId = Guid.Parse("cd0b1476-44a8-4350-a6a1-3de8747a5ebc"),
        PortionSize = "cái",
        PortionWeight = 250,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 53
    new Portion
    {
        PortionId = Guid.Parse("5afaa147-398e-4be8-b0d1-8dcabe6ed18c"),
        PortionSize = "quả nhỏ",
        PortionWeight = 150,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 54
    new Portion
    {
        PortionId = Guid.Parse("d3850e1b-4780-490d-8c0c-ced1a9aa323b"),
        PortionSize = "quả vừa",
        PortionWeight = 220,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 55
    new Portion
    {
        PortionId = Guid.Parse("e09c493c-5806-4b14-bbef-e26e19e1d8d5"),
        PortionSize = "quả to",
        PortionWeight = 400,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 56
    new Portion
    {
        PortionId = Guid.Parse("5f7f859a-f20a-4f6c-8b8c-ecfbb1ff522e"),
        PortionSize = "quả",
        PortionWeight = 90,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 57
    new Portion
    {
        PortionId = Guid.Parse("2c7ac6ee-f7fe-4ec8-974f-11f62a5f60b9"),
        PortionSize = "con",
        PortionWeight = 250,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 58
    new Portion
    {
        PortionId = Guid.Parse("f0e8f9cd-d133-49cf-be7d-d427b630e05a"),
        PortionSize = "quả",
        PortionWeight = 120,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 59
    new Portion
    {
        PortionId = Guid.Parse("ef6b8c43-9ab5-497c-a9a8-e31f0a349527"),
        PortionSize = "quả",
        PortionWeight = 220,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 60
    new Portion
    {
        PortionId = Guid.Parse("1cddc91d-209a-4948-8e9f-9017252d5423"),
        PortionSize = "củ",
        PortionWeight = 250,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 61
    new Portion
    {
        PortionId = Guid.Parse("d09266d3-9e7d-46a6-ad3a-7c608ec802d1"),
        PortionSize = "tô",
        PortionWeight = 300,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 62
    new Portion
    {
        PortionId = Guid.Parse("5384aebd-4eab-4a44-8cbb-7ec2c04f1401"),
        PortionSize = "đĩa",
        PortionWeight = 230,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 63
    new Portion
    {
        PortionId = Guid.Parse("222e1fa2-3910-42ac-9a5c-f371dded16eb"),
        PortionSize = "lát",
        PortionWeight = 30,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 64
    new Portion
    {
        PortionId = Guid.Parse("eff728af-c8f0-4bb5-a985-d079cbadb6b5"),
        PortionSize = "củ nhỏ",
        PortionWeight = 20,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 65
    new Portion
    {
        PortionId = Guid.Parse("a5dbb27a-4856-44be-a239-76eb073c3e41"),
        PortionSize = "củ vừa",
        PortionWeight = 80,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 66
    new Portion
    {
        PortionId = Guid.Parse("a7936b9f-b6f8-4295-8b6e-6fe1b096f437"),
        PortionSize = "củ to",
        PortionWeight = 200,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 67
    new Portion
    {
        PortionId = Guid.Parse("e23d4491-73d1-45b5-8010-0385d7185c98"),
        PortionSize = "quả",
        PortionWeight = 300,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 68
    new Portion
    {
        PortionId = Guid.Parse("0336a88f-f5cd-4cc2-8478-980467aa91aa"),
        PortionSize = "con",
        PortionWeight = 550,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 69
    new Portion
    {
        PortionId = Guid.Parse("bdd1ee1e-3a93-421f-855e-0993c7e6f767"),
        PortionSize = "đĩa",
        PortionWeight = 250,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 70
    new Portion
    {
        PortionId = Guid.Parse("c4993d6a-a2e0-4ddd-821a-0629541e019c"),
        PortionSize = "tô",
        PortionWeight = 300,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 71
    new Portion
    {
        PortionId = Guid.Parse("5a1bc1cb-ed0b-49bf-9c1a-5494db962d27"),
        PortionSize = "đĩa",
        PortionWeight = 200,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 72
    new Portion
    {
        PortionId = Guid.Parse("8ecbc063-8d6e-450d-af39-0ba28bc572bf"),
        PortionSize = "tô",
        PortionWeight = 300,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 73
    new Portion
    {
        PortionId = Guid.Parse("16dc894a-746e-497e-a2c5-2d58f7f83c4d"),
        PortionSize = "ly",
        PortionWeight = 180,
        MeasurementUnit = "ml",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 74
    new Portion
    {
        PortionId = Guid.Parse("30f41ca6-c420-4f7d-9602-bf80735d5691"),
        PortionSize = "củ",
        PortionWeight = 150,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 75
    new Portion
    {
        PortionId = Guid.Parse("1cf439ce-a31b-4b95-b092-b7f6edf8d40f"),
        PortionSize = "quả nhỏ",
        PortionWeight = 220,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 76
    new Portion
    {
        PortionId = Guid.Parse("ad9ecd1e-40ec-414a-be69-b16e7013b377"),
        PortionSize = "quả to",
        PortionWeight = 550,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 77
    new Portion
    {
        PortionId = Guid.Parse("1802caa2-cfe0-48e7-8580-29165f84387d"),
        PortionSize = "quả nhỏ",
        PortionWeight = 300,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 78
    new Portion
    {
        PortionId = Guid.Parse("21e32570-7d64-4cec-b711-873185c76523"),
        PortionSize = "quả to",
        PortionWeight = 1500,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 79
    new Portion
    {
        PortionId = Guid.Parse("9c276c0b-84b6-4216-8dbb-ae2034ac2176"),
        PortionSize = "tô",
        PortionWeight = 300,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 80
    new Portion
    {
        PortionId = Guid.Parse("d9dad801-145a-419d-bbe2-408acf97a273"),
        PortionSize = "con nhỏ",
        PortionWeight = 30,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 81
    new Portion
    {
        PortionId = Guid.Parse("bf0f7ca4-9089-4800-95d7-8d037d98b7fc"),
        PortionSize = "con vừa",
        PortionWeight = 60,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 82
    new Portion
    {
        PortionId = Guid.Parse("56681171-ccbd-4700-90bc-2233c1e661bb"),
        PortionSize = "con to",
        PortionWeight = 500,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 83
    new Portion
    {
        PortionId = Guid.Parse("709578ca-672f-461e-995d-dc78aeda8c4c"),
        PortionSize = "con nhỏ",
        PortionWeight = 30,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 84
    new Portion
    {
        PortionId = Guid.Parse("f928b7a6-2558-478a-bc22-515516f4dc74"),
        PortionSize = "con vừa",
        PortionWeight = 60,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 85
    new Portion
    {
        PortionId = Guid.Parse("23ce32a0-6597-4b60-b35c-98073ff595c6"),
        PortionSize = "con to",
        PortionWeight = 500,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 86
    new Portion
    {
        PortionId = Guid.Parse("bad70aff-4237-4c83-b412-460020a5ee44"),
        PortionSize = "hộp",
        PortionWeight = 150,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 87
    new Portion
    {
        PortionId = Guid.Parse("8c141b0b-f09b-486e-b75a-04fa194d412c"),
        PortionSize = "củ nhỏ",
        PortionWeight = 200,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 88
    new Portion
    {
        PortionId = Guid.Parse("f359ba3c-6597-40ad-9dbd-6719ff302994"),
        PortionSize = "củ vừa",
        PortionWeight = 300,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 89
    new Portion
    {
        PortionId = Guid.Parse("b6b0faee-84e8-4a16-a8f7-4b8719787e8a"),
        PortionSize = "củ to",
        PortionWeight = 450,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 90
    new Portion
    {
        PortionId = Guid.Parse("59589114-7d6a-4c80-8681-db5c554ab38f"),
        PortionSize = "ổ",
        PortionWeight = 200,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 91
    new Portion
    {
        PortionId = Guid.Parse("13672611-5453-40a0-9b58-33c2e552bf57"),
        PortionSize = "quả nhỏ",
        PortionWeight = 60,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 92
    new Portion
    {
        PortionId = Guid.Parse("f01f8da7-9d7b-4893-999f-cf30e719e010"),
        PortionSize = "quả to",
        PortionWeight = 75,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 93
    new Portion
    {
        PortionId = Guid.Parse("c65d34ee-8c0c-43bb-9d4e-aa39955a4768"),
        PortionSize = "quả nhỏ",
        PortionWeight = 60,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 94
    new Portion
    {
        PortionId = Guid.Parse("f9bc9ae8-e42e-4e8b-84d3-f2bc36037552"),
        PortionSize = "quả vừa",
        PortionWeight = 110,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 95
    new Portion
    {
        PortionId = Guid.Parse("bd16f0ec-5ae1-42f4-a302-b4bce8f0db28"),
        PortionSize = "quả to",
        PortionWeight = 220,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 96
    new Portion
    {
        PortionId = Guid.Parse("549d664a-eb1c-4b9a-8ad7-fab9e1482e5b"),
        PortionSize = "quả nhỏ",
        PortionWeight = 100,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 97
    new Portion
    {
        PortionId = Guid.Parse("e45c2156-a98c-4121-90b4-25097e8a5cd1"),
        PortionSize = "quả vừa",
        PortionWeight = 170,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 98
    new Portion
    {
        PortionId = Guid.Parse("7b138bd4-4d3a-426c-9ab0-d66699b762d2"),
        PortionSize = "quả to",
        PortionWeight = 350,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 99
    new Portion
    {
        PortionId = Guid.Parse("2892c25f-bd50-4bb4-a845-997395ef6693"),
        PortionSize = "gói",
        PortionWeight = 150,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 100
    new Portion
    {
        PortionId = Guid.Parse("03a92c0b-b7f6-4283-8109-a35898d5d3c5"),
        PortionSize = "quả nhỏ",
        PortionWeight = 12,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 101
    new Portion
    {
        PortionId = Guid.Parse("fc245902-ef53-4363-b4ce-0e598e1dd4a4"),
        PortionSize = "quả vừa",
        PortionWeight = 17,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 102
    new Portion
    {
        PortionId = Guid.Parse("da254ee7-d229-4769-bad5-a617d09676d4"),
        PortionSize = "quả to",
        PortionWeight = 20,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 103
    new Portion
    {
        PortionId = Guid.Parse("3d6d946f-8d9f-479a-b27e-3d78dc354db0"),
        PortionSize = "chén",
        PortionWeight = 40,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 104
    new Portion
    {
        PortionId = Guid.Parse("424ebe64-6570-4d88-9052-08c06dc0a2c8"),
        PortionSize = "cái",
        PortionWeight = 30,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 105
    new Portion
    {
        PortionId = Guid.Parse("5adcb96d-70ef-403d-89c6-cc3aa807b6a7"),
        PortionSize = "củ nhỏ",
        PortionWeight = 110,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 106
    new Portion
    {
        PortionId = Guid.Parse("5a9ac478-aa65-48ea-9387-1ad92f6c76b1"),
        PortionSize = "củ vừa",
        PortionWeight = 180,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 107
    new Portion
    {
        PortionId = Guid.Parse("113f6a04-87c4-43c6-8263-920bd099c8e0"),
        PortionSize = "củ to",
        PortionWeight = 300,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 108
    new Portion
    {
        PortionId = Guid.Parse("d2e88505-bbd6-4af6-9a88-535896c5d587"),
        PortionSize = "quả nhỏ",
        PortionWeight = 500,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 109
    new Portion
    {
        PortionId = Guid.Parse("3f19ef5c-3c60-4a11-b1b3-5158859f1286"),
        PortionSize = "quả vừa",
        PortionWeight = 900,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 110
    new Portion
    {
        PortionId = Guid.Parse("7e071bd6-6afa-483d-8688-28b31b9a8bef"),
        PortionSize = "hộp",
        PortionWeight = 280,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 111
    new Portion
    {
        PortionId = Guid.Parse("d6c41cdb-4735-4b9e-85ae-1f48f33b7d6c"),
        PortionSize = "cây",
        PortionWeight = 40,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 112
    new Portion
    {
        PortionId = Guid.Parse("b9423874-3290-4fda-9996-7c13d7c61d96"),
        PortionSize = "cái",
        PortionWeight = 90,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 113
    new Portion
    {
        PortionId = Guid.Parse("2b7a3473-9f67-4938-b419-7cafa8f72a41"),
        PortionSize = "hộp",
        PortionWeight = 300,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 114
    new Portion
    {
        PortionId = Guid.Parse("a43d7637-6fc7-421b-86f1-f83e691431a4"),
        PortionSize = "phần nhỏ",
        PortionWeight = 150,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 115
    new Portion
    {
        PortionId = Guid.Parse("6e98f2be-9196-4c4e-8279-b02010f853f1"),
        PortionSize = "phần vừa",
        PortionWeight = 250,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 116
    new Portion
    {
        PortionId = Guid.Parse("e00ed683-11ff-4c21-8b1c-576b448726c9"),
        PortionSize = "phần to",
        PortionWeight = 400,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 117
    new Portion
    {
        PortionId = Guid.Parse("509da3d8-ed0f-4cd0-be26-3a896b9500b3"),
        PortionSize = "con nhỏ",
        PortionWeight = 15,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 118
    new Portion
    {
        PortionId = Guid.Parse("8bffc4ad-afcc-436b-953c-444f1e8ce533"),
        PortionSize = "con vừa",
        PortionWeight = 30,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 119
    new Portion
    {
        PortionId = Guid.Parse("28f6a369-f694-437d-82eb-944b09d5e369"),
        PortionSize = "con to",
        PortionWeight = 70,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 120
    new Portion
    {
        PortionId = Guid.Parse("63d10d95-7983-455e-b920-29c1f0c88d85"),
        PortionSize = "quả nhỏ",
        PortionWeight = 120,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 121
    new Portion
    {
        PortionId = Guid.Parse("919c7f66-53e5-46bd-b181-558f6052b953"),
        PortionSize = "quả vừa",
        PortionWeight = 170,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 122
    new Portion
    {
        PortionId = Guid.Parse("87409e4f-4bea-4bba-855d-a3bfbc2f9c20"),
        PortionSize = "quả to",
        PortionWeight = 250,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 123
    new Portion
    {
        PortionId = Guid.Parse("26dcc6e0-67aa-40ed-b3d1-8a009c60a62c"),
        PortionSize = "quả nhỏ",
        PortionWeight = 12,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 124
    new Portion
    {
        PortionId = Guid.Parse("3c7d60d4-60da-4f51-9448-30877b126572"),
        PortionSize = "quả vừa",
        PortionWeight = 20,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    },
            #endregion

            #region Portion 125
    new Portion
    {
        PortionId = Guid.Parse("9c3399d1-72db-4e86-a518-2575033bb6a8"),
        PortionSize = "quả to",
        PortionWeight = 35,
        MeasurementUnit = "g",
        CreatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
        UpdatedAt = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null),
    }
    #endregion

            );
        }
    }
}
