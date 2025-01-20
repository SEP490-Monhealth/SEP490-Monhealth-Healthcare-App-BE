using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class FoodPortionConfiguration : IEntityTypeConfiguration<FoodPortion>
    {
        public void Configure(EntityTypeBuilder<FoodPortion> builder)
        {
            builder.HasData(
            #region FoodPortion 1
new FoodPortion
{
    FoodPortionId = Guid.Parse("6956e07b-da21-481e-ac76-65255fd9587f"),
    FoodId = Guid.Parse("599cfc95-4108-4dcc-9c5a-077173251f8b"),
    PortionId = Guid.Parse("1808de3e-ae43-41a6-b9ce-bfe89131be5a"),
},
    new FoodPortion
    {
        FoodPortionId = Guid.Parse("8c85d7a4-bace-4691-ab0f-e1628f24bfd3"),
        FoodId = Guid.Parse("599cfc95-4108-4dcc-9c5a-077173251f8b"),
        PortionId = Guid.Parse("40991196-f258-43f1-ac84-0381afa83477"),
    },
            #endregion

            #region FoodPortion 2
new FoodPortion
{
    FoodPortionId = Guid.Parse("c15e4bd1-ddaa-4330-8ae5-dbf1549a8f9c"),
    FoodId = Guid.Parse("a989c8db-7506-467f-8aba-dce042f68eea"),
    PortionId = Guid.Parse("28b06cf6-6367-4786-bccb-89c43dd3ce3a"),
},
    new FoodPortion
    {
        FoodPortionId = Guid.Parse("9fcf8d40-47b2-45fb-8197-e77bf2071542"),
        FoodId = Guid.Parse("a989c8db-7506-467f-8aba-dce042f68eea"),
        PortionId = Guid.Parse("91524cc2-db22-4cab-abb7-700725232f1f"),
    },
    new FoodPortion
    {
        FoodPortionId = Guid.Parse("db166416-f2d4-4e69-98b2-4b14ac28f725"),
        FoodId = Guid.Parse("a989c8db-7506-467f-8aba-dce042f68eea"),
        PortionId = Guid.Parse("1b56833b-1ff5-4a90-aea9-074de2d0dd67"),
    },
            #endregion

            #region FoodPortion 3
new FoodPortion
{
    FoodPortionId = Guid.Parse("00b508dc-fd72-46b5-8fd0-71caa552cf8d"),
    FoodId = Guid.Parse("c42e7f00-ea31-430a-ac28-8d6e749b7eca"),
    PortionId = Guid.Parse("c605aa91-495e-4977-9876-b2a198ce356e"),
},
    new FoodPortion
    {
        FoodPortionId = Guid.Parse("aac2bdea-12f2-4a18-970b-53f31238c765"),
        FoodId = Guid.Parse("c42e7f00-ea31-430a-ac28-8d6e749b7eca"),
        PortionId = Guid.Parse("7be0e4d3-1e50-4de1-931d-08adb85f628b"),
    },
    new FoodPortion
    {
        FoodPortionId = Guid.Parse("99a56d5b-3a27-437b-b2dd-9ed46689be76"),
        FoodId = Guid.Parse("c42e7f00-ea31-430a-ac28-8d6e749b7eca"),
        PortionId = Guid.Parse("698c67ad-a726-435b-b9d2-c5690a79eb5a"),
    },
            #endregion

            #region FoodPortion 4
new FoodPortion
{
    FoodPortionId = Guid.Parse("b915f9fe-df4f-4b9a-aeee-746a7206a297"),
    FoodId = Guid.Parse("021b651c-bb01-4965-95bc-3532fbacad3d"),
    PortionId = Guid.Parse("399eee61-90b5-464f-b3f7-7ddc1077ab0d"),
},
    new FoodPortion
    {
        FoodPortionId = Guid.Parse("6dfc62b1-fc62-4aea-a8f4-aa93dcfb10fe"),
        FoodId = Guid.Parse("021b651c-bb01-4965-95bc-3532fbacad3d"),
        PortionId = Guid.Parse("6f34350b-8f99-446e-9de9-e0c6277b10f3"),
    },
            #endregion

            #region FoodPortion 5
new FoodPortion
{
    FoodPortionId = Guid.Parse("b38e1bf5-f34c-422f-bc6a-456eb9f1439f"),
    FoodId = Guid.Parse("8fa26c41-16b2-49f8-a284-856024a5f947"),
    PortionId = Guid.Parse("41ae956e-14fc-44af-bc6a-e5ba77661cee"),
},
            #endregion

            #region FoodPortion 6
new FoodPortion
{
    FoodPortionId = Guid.Parse("63c7b97d-ad3e-47c0-a294-fc74ae5c312e"),
    FoodId = Guid.Parse("1387c20d-27a6-495b-a3a0-efbb715f6430"),
    PortionId = Guid.Parse("a1589990-affa-4805-a1e0-73de1ffa8516"),
},
            #endregion

            #region FoodPortion 7
new FoodPortion
{
    FoodPortionId = Guid.Parse("7a61797f-8c44-44f2-87d7-9d14946e91e0"),
    FoodId = Guid.Parse("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"),
    PortionId = Guid.Parse("4e9013c8-d6f7-4740-80d5-e95d318873b9"),
},
            #endregion

            #region FoodPortion 8
new FoodPortion
{
    FoodPortionId = Guid.Parse("e07e4ccc-de61-4564-a047-d5f29395e765"),
    FoodId = Guid.Parse("eac10b91-8509-4986-b689-7ee3a3757a18"),
    PortionId = Guid.Parse("1bf9c3e0-7a2c-46f5-8187-82e5ad1af649"),
},
            #endregion

            #region FoodPortion 9
new FoodPortion
{
    FoodPortionId = Guid.Parse("77ff6660-2d5b-45db-bd7b-524a3eac0a98"),
    FoodId = Guid.Parse("85822a08-7189-4e08-8f55-25c73698af92"),
    PortionId = Guid.Parse("faec7c41-2e11-4092-8ab9-cc9c152d858f"),
},
            #endregion

            #region FoodPortion 10
new FoodPortion
{
    FoodPortionId = Guid.Parse("ea36ca31-4756-426f-8f30-116a401871ff"),
    FoodId = Guid.Parse("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"),
    PortionId = Guid.Parse("268e00a0-2da3-4e5c-8ea7-5ad8923cfd52"),
},
            #endregion

            #region FoodPortion 11
new FoodPortion
{
    FoodPortionId = Guid.Parse("da959267-1066-4a30-84a6-c5975af7c398"),
    FoodId = Guid.Parse("a17722bf-899e-40e9-8e54-ae2fc8a34f44"),
    PortionId = Guid.Parse("40bbc8c4-f383-4ae6-979a-3ac83c275881"),
},
            #endregion

            #region FoodPortion 12
new FoodPortion
{
    FoodPortionId = Guid.Parse("49e440ff-31d5-49a0-8f8b-98c9a9d95cf9"),
    FoodId = Guid.Parse("21a4b410-e26d-444b-8b99-bf8b490e5dcf"),
    PortionId = Guid.Parse("de5d78a3-c5b1-4e2a-b9eb-f3757c999024"),
},
            #endregion

            #region FoodPortion 13
new FoodPortion
{
    FoodPortionId = Guid.Parse("8d47ad59-d162-4777-81dc-c2bec9e72f22"),
    FoodId = Guid.Parse("de097440-db5c-4d91-bd55-76618d70599d"),
    PortionId = Guid.Parse("92e149ff-8491-48cf-a4e8-8106b1e95c4c"),
},
            #endregion

            #region FoodPortion 14
new FoodPortion
{
    FoodPortionId = Guid.Parse("bdfe0d61-37a3-4062-bff8-b1ab5d7959cc"),
    FoodId = Guid.Parse("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"),
    PortionId = Guid.Parse("3f77fd90-591c-45f3-8bbc-87d0bb49e461"),
},
            #endregion

            #region FoodPortion 15
new FoodPortion
{
    FoodPortionId = Guid.Parse("d5d5889a-bbc4-408c-9884-d194e1f48346"),
    FoodId = Guid.Parse("a47b1646-3576-46f0-a3b6-763a9c3f889b"),
    PortionId = Guid.Parse("6792c392-3c86-4162-be91-4fc8646f861d"),
},
            #endregion

            #region FoodPortion 16
new FoodPortion
{
    FoodPortionId = Guid.Parse("cfab2fdb-5a1a-4b4c-8e85-5247c64e3492"),
    FoodId = Guid.Parse("48113ca0-a1e7-4181-85fa-be6538a70873"),
    PortionId = Guid.Parse("c4fc900f-5a92-4228-ac03-57285fff159e"),
},
            #endregion

            #region FoodPortion 17
new FoodPortion
{
    FoodPortionId = Guid.Parse("3dcc2c21-c974-4827-b8bf-224881a2af24"),
    FoodId = Guid.Parse("f77e03de-4ed3-41ca-8fa1-0a4947c67384"),
    PortionId = Guid.Parse("cd0a9e6f-bf5b-40b3-bb6c-22ccb8e6ab6a"),
},
            #endregion

            #region FoodPortion 18
new FoodPortion
{
    FoodPortionId = Guid.Parse("55ed9075-67ec-4a5e-8d67-71b778fb480f"),
    FoodId = Guid.Parse("d4df84f2-2d79-41e6-b313-28e89e3785ba"),
    PortionId = Guid.Parse("a33065fe-80ad-4879-9333-424aadc6734f"),
},
            #endregion

            #region FoodPortion 19
new FoodPortion
{
    FoodPortionId = Guid.Parse("50cd88da-4abe-448a-bf7f-4c50bd4d1bc3"),
    FoodId = Guid.Parse("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"),
    PortionId = Guid.Parse("eceaaa32-4023-4eab-abb6-9172c908f77c"),
},
            #endregion

            #region FoodPortion 20
new FoodPortion
{
    FoodPortionId = Guid.Parse("29be3e7f-31f6-459d-bcb5-2342e7e0a250"),
    FoodId = Guid.Parse("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"),
    PortionId = Guid.Parse("31e9bda5-8ec3-4444-a23a-908e84da6a14"),
},
            #endregion

            #region FoodPortion 21
new FoodPortion
{
    FoodPortionId = Guid.Parse("3cea29a7-afbb-4d5d-9755-6f514ae1a0a2"),
    FoodId = Guid.Parse("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"),
    PortionId = Guid.Parse("93984b54-2044-4ea9-8364-a03c6568e358"),
},
            #endregion

            #region FoodPortion 22
new FoodPortion
{
    FoodPortionId = Guid.Parse("eef1a8f0-25f1-4695-b6ff-c57662e845cd"),
    FoodId = Guid.Parse("da89578e-9470-4b18-af4f-0bdcc011882f"),
    PortionId = Guid.Parse("749b288c-112b-4b7b-8750-0daff63d9ab3"),
},
            #endregion

            #region FoodPortion 23
new FoodPortion
{
    FoodPortionId = Guid.Parse("e428756d-f4a5-4ea2-a168-409faa856d57"),
    FoodId = Guid.Parse("37a66f5c-437f-4520-90ec-4376e0093061"),
    PortionId = Guid.Parse("1500876f-ef20-40de-baae-de0336bdc47b"),
},
            #endregion

            #region FoodPortion 24
new FoodPortion
{
    FoodPortionId = Guid.Parse("034c5f36-35f5-4fb4-b567-4631a20c99b6"),
    FoodId = Guid.Parse("d9fa8f03-5825-4e83-88d3-1a7c49e39a7d"),
    PortionId = Guid.Parse("e4e4252f-ad38-4190-aba5-8989e3cca994"),
},
            #endregion

            #region FoodPortion 25
new FoodPortion
{
    FoodPortionId = Guid.Parse("689236b2-c41a-4581-97f4-9943a8bf619f"),
    FoodId = Guid.Parse("05cfce09-72b4-482d-adcd-c0718015be3d"),
    PortionId = Guid.Parse("24a4ed15-69e4-4fb5-8dd2-1695de52c264"),
},
            #endregion

            #region FoodPortion 26
new FoodPortion
{
    FoodPortionId = Guid.Parse("79f8e00a-8627-4c17-ad1b-1f2e30152cf7"),
    FoodId = Guid.Parse("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"),
    PortionId = Guid.Parse("bfc705ab-d7e9-44c9-9447-c0b39bc76ca1"),
},
            #endregion

            #region FoodPortion 27
new FoodPortion
{
    FoodPortionId = Guid.Parse("ff83c895-9e7c-497d-ba90-48a0b27ac753"),
    FoodId = Guid.Parse("dfa879e8-d77d-4199-b07b-16b37f1cbde1"),
    PortionId = Guid.Parse("b6623163-4c27-4d0c-99ef-12a67b87635f"),
},
            #endregion

            #region FoodPortion 28
new FoodPortion
{
    FoodPortionId = Guid.Parse("05d20084-3157-48d2-bbdf-59bd4be2d7f9"),
    FoodId = Guid.Parse("30355638-a0e2-4126-93ae-beb7aa9b5758"),
    PortionId = Guid.Parse("a88faa7c-6eab-4ecb-8a75-b078a9cf7834"),
},
            #endregion

            #region FoodPortion 29
new FoodPortion
{
    FoodPortionId = Guid.Parse("6488aed8-d811-4054-aa55-1419362b89f6"),
    FoodId = Guid.Parse("c5822776-96df-4208-82b2-02f22594063b"),
    PortionId = Guid.Parse("3d7eafa9-9fcc-4f49-b8fb-2a5c629ae6eb"),
},
            #endregion

            #region FoodPortion 30
new FoodPortion
{
    FoodPortionId = Guid.Parse("ef7605fb-2047-4fd6-b9eb-bcaa4265dcfa"),
    FoodId = Guid.Parse("fb7d87aa-2bb8-4065-bd31-b54239057405"),
    PortionId = Guid.Parse("22f0a09e-6816-410e-a5a2-c802103b089b"),
},
            #endregion

            #region FoodPortion 31
new FoodPortion
{
    FoodPortionId = Guid.Parse("c5c017a3-f52c-4e61-b3f5-d36fc3da9438"),
    FoodId = Guid.Parse("9122357a-179f-45f4-9106-67eea24d48ab"),
    PortionId = Guid.Parse("5feca670-1f15-430d-9b04-7ac86a329a6c"),
},
            #endregion

            #region FoodPortion 32
new FoodPortion
{
    FoodPortionId = Guid.Parse("166bdafd-3440-45db-af3c-9f254f75381d"),
    FoodId = Guid.Parse("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"),
    PortionId = Guid.Parse("f483bb75-84f0-4ecc-8a06-f366a488c6bf"),
},
            #endregion

            #region FoodPortion 33
new FoodPortion
{
    FoodPortionId = Guid.Parse("624eeb3d-b90c-41de-aaac-82aac1278366"),
    FoodId = Guid.Parse("87225215-43af-49f2-a40b-a5ebb087d27b"),
    PortionId = Guid.Parse("a9385e8a-e9b9-484f-beeb-bc35529cf91a"),
},
            #endregion

            #region FoodPortion 34
new FoodPortion
{
    FoodPortionId = Guid.Parse("4601ad5c-3b27-4b7b-a4c1-4e2c0acbd844"),
    FoodId = Guid.Parse("23443efa-dc06-4e7a-949c-5c823ee6e575"),
    PortionId = Guid.Parse("8a81e20e-ea16-4073-957e-29508a8f7419"),
}
#endregion
                );
        }
    }
}
