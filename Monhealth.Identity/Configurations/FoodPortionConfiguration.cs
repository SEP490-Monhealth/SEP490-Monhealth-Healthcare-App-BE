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
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("599cfc95-4108-4dcc-9c5a-077173251f8b"),
                PortionId = Guid.Parse("1808de3e-ae43-41a6-b9ce-bfe89131be5a"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("599cfc95-4108-4dcc-9c5a-077173251f8b"),
                PortionId = Guid.Parse("40991196-f258-43f1-ac84-0381afa83477"),
            },
            #endregion

            #region FoodPortion 2
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("a989c8db-7506-467f-8aba-dce042f68eea"),
                PortionId = Guid.Parse("28b06cf6-6367-4786-bccb-89c43dd3ce3a"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("a989c8db-7506-467f-8aba-dce042f68eea"),
                PortionId = Guid.Parse("91524cc2-db22-4cab-abb7-700725232f1f"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("a989c8db-7506-467f-8aba-dce042f68eea"),
                PortionId = Guid.Parse("1b56833b-1ff5-4a90-aea9-074de2d0dd67"),
            },
            #endregion

            #region FoodPortion 3
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("c42e7f00-ea31-430a-ac28-8d6e749b7eca"),
                PortionId = Guid.Parse("c605aa91-495e-4977-9876-b2a198ce356e"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("c42e7f00-ea31-430a-ac28-8d6e749b7eca"),
                PortionId = Guid.Parse("7be0e4d3-1e50-4de1-931d-08adb85f628b"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("c42e7f00-ea31-430a-ac28-8d6e749b7eca"),
                PortionId = Guid.Parse("698c67ad-a726-435b-b9d2-c5690a79eb5a"),
            },
            #endregion

            #region FoodPortion 4
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("021b651c-bb01-4965-95bc-3532fbacad3d"),
                PortionId = Guid.Parse("399eee61-90b5-464f-b3f7-7ddc1077ab0d"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("021b651c-bb01-4965-95bc-3532fbacad3d"),
                PortionId = Guid.Parse("6f34350b-8f99-446e-9de9-e0c6277b10f3"),
            },
            #endregion

            #region FoodPortion 5
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("8fa26c41-16b2-49f8-a284-856024a5f947"),
                PortionId = Guid.Parse("41ae956e-14fc-44af-bc6a-e5ba77661cee"),
            },
            #endregion

            #region FoodPortion 6
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("1387c20d-27a6-495b-a3a0-efbb715f6430"),
                PortionId = Guid.Parse("a1589990-affa-4805-a1e0-73de1ffa8516"),
            },
            #endregion

            #region FoodPortion 7
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("7dba3127-1fd5-426f-ac21-5ffd5fa8cc42"),
                PortionId = Guid.Parse("4e9013c8-d6f7-4740-80d5-e95d318873b9"),
            },
            #endregion

            #region FoodPortion 8
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("eac10b91-8509-4986-b689-7ee3a3757a18"),
                PortionId = Guid.Parse("1bf9c3e0-7a2c-46f5-8187-82e5ad1af649"),
            },
            #endregion

            #region FoodPortion 9
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("85822a08-7189-4e08-8f55-25c73698af92"),
                PortionId = Guid.Parse("faec7c41-2e11-4092-8ab9-cc9c152d858f"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("85822a08-7189-4e08-8f55-25c73698af92"),
                PortionId = Guid.Parse("36398f6d-0668-4d37-8850-9f9ee89b8b92"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("85822a08-7189-4e08-8f55-25c73698af92"),
                PortionId = Guid.Parse("c6e853f0-06bd-4cda-8b43-cbe66fea98c8"),
            },
            #endregion

            #region FoodPortion 10
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("c2a6e33a-917f-4c09-a5e3-6b8a9c12a25f"),
                PortionId = Guid.Parse("268e00a0-2da3-4e5c-8ea7-5ad8923cfd52"),
            },
            #endregion

            #region FoodPortion 11
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("a17722bf-899e-40e9-8e54-ae2fc8a34f44"),
                PortionId = Guid.Parse("40bbc8c4-f383-4ae6-979a-3ac83c275881"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("a17722bf-899e-40e9-8e54-ae2fc8a34f44"),
                PortionId = Guid.Parse("26096793-894d-47c1-a06f-cf9133f8089d"),
            },
            #endregion

            #region FoodPortion 12
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("21a4b410-e26d-444b-8b99-bf8b490e5dcf"),
                PortionId = Guid.Parse("de5d78a3-c5b1-4e2a-b9eb-f3757c999024"),
            },
            #endregion

            #region FoodPortion 13
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("de097440-db5c-4d91-bd55-76618d70599d"),
                PortionId = Guid.Parse("92e149ff-8491-48cf-a4e8-8106b1e95c4c"),
            },
            #endregion

            #region FoodPortion 14
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("2f8f9f4c-cd2a-482a-ac48-18c2e06f73bc"),
                PortionId = Guid.Parse("3f77fd90-591c-45f3-8bbc-87d0bb49e461"),
            },
            #endregion

            #region FoodPortion 15
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("a47b1646-3576-46f0-a3b6-763a9c3f889b"),
                PortionId = Guid.Parse("6792c392-3c86-4162-be91-4fc8646f861d"),
            },
            #endregion

            #region FoodPortion 16
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("48113ca0-a1e7-4181-85fa-be6538a70873"),
                PortionId = Guid.Parse("c4fc900f-5a92-4228-ac03-57285fff159e"),
            },
            #endregion

            #region FoodPortion 17
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("f77e03de-4ed3-41ca-8fa1-0a4947c67384"),
                PortionId = Guid.Parse("cd0a9e6f-bf5b-40b3-bb6c-22ccb8e6ab6a"),
            },
            #endregion

            #region FoodPortion 18
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("d4df84f2-2d79-41e6-b313-28e89e3785ba"),
                PortionId = Guid.Parse("a33065fe-80ad-4879-9333-424aadc6734f"),
            },
            #endregion

            #region FoodPortion 19
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"),
                PortionId = Guid.Parse("eceaaa32-4023-4eab-abb6-9172c908f77c"),
            },
            #endregion

            #region FoodPortion 20
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"),
                PortionId = Guid.Parse("31e9bda5-8ec3-4444-a23a-908e84da6a14"),
            },
            #endregion

            #region FoodPortion 21
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("94097f31-9a0e-41a3-b44f-4bb7c6b7c756"),
                PortionId = Guid.Parse("93984b54-2044-4ea9-8364-a03c6568e358"),
            },
            #endregion

            #region FoodPortion 22
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("da89578e-9470-4b18-af4f-0bdcc011882f"),
                PortionId = Guid.Parse("749b288c-112b-4b7b-8750-0daff63d9ab3"),
            },
            #endregion

            #region FoodPortion 23
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("37a66f5c-437f-4520-90ec-4376e0093061"),
                PortionId = Guid.Parse("1500876f-ef20-40de-baae-de0336bdc47b"),
            },
            #endregion

            // #region FoodPortion 24
            // new FoodPortion
            // {
            //     FoodPortionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("d9fa8f03-5825-4e83-88d3-1a7c49e39a7d"),
            //     PortionId = Guid.Parse("e4e4252f-ad38-4190-aba5-8989e3cca994"),
            // },
            // #endregion

            #region FoodPortion 25
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("05cfce09-72b4-482d-adcd-c0718015be3d"),
                PortionId = Guid.Parse("24a4ed15-69e4-4fb5-8dd2-1695de52c264"),
            },
            #endregion

            #region FoodPortion 26
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("0fba6ca5-e0a0-4b13-b265-aa37af1b055c"),
                PortionId = Guid.Parse("bfc705ab-d7e9-44c9-9447-c0b39bc76ca1"),
            },
            #endregion

            #region FoodPortion 27
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("dfa879e8-d77d-4199-b07b-16b37f1cbde1"),
                PortionId = Guid.Parse("b6623163-4c27-4d0c-99ef-12a67b87635f"),
            },
            #endregion

            #region FoodPortion 28
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("30355638-a0e2-4126-93ae-beb7aa9b5758"),
                PortionId = Guid.Parse("a88faa7c-6eab-4ecb-8a75-b078a9cf7834"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("30355638-a0e2-4126-93ae-beb7aa9b5758"),
                PortionId = Guid.Parse("218b9709-852d-4a1f-ad8b-c9410b49fea6"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("30355638-a0e2-4126-93ae-beb7aa9b5758"),
                PortionId = Guid.Parse("e5cc2785-6d62-4b5f-8fc1-e6ab45babd76"),
            },
            #endregion

            // #region FoodPortion 29
            // new FoodPortion
            // {
            //     FoodPortionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("c5822776-96df-4208-82b2-02f22594063b"),
            //     PortionId = Guid.Parse("3d7eafa9-9fcc-4f49-b8fb-2a5c629ae6eb"),
            // },
            // #endregion

            #region FoodPortion 30
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("fb7d87aa-2bb8-4065-bd31-b54239057405"),
                PortionId = Guid.Parse("22f0a09e-6816-410e-a5a2-c802103b089b"),
            },
            #endregion

            #region FoodPortion 31
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("9122357a-179f-45f4-9106-67eea24d48ab"),
                PortionId = Guid.Parse("5feca670-1f15-430d-9b04-7ac86a329a6c"),
            },
            #endregion

            #region FoodPortion 32
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"),
                PortionId = Guid.Parse("f483bb75-84f0-4ecc-8a06-f366a488c6bf"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"),
                PortionId = Guid.Parse("17c9d30f-bd85-4e58-bfc0-6b6d70b2e5fe"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"),
                PortionId = Guid.Parse("52c86d57-0909-41c3-b513-e770e6f6d104"),
            },
            #endregion

            #region FoodPortion 33
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("87225215-43af-49f2-a40b-a5ebb087d27b"),
                PortionId = Guid.Parse("a9385e8a-e9b9-484f-beeb-bc35529cf91a"),
            },
            #endregion

            #region FoodPortion 34
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("23443efa-dc06-4e7a-949c-5c823ee6e575"),
                PortionId = Guid.Parse("8a81e20e-ea16-4073-957e-29508a8f7419"),
            },
            #endregion

            #region FoodPortion 35
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("08b5c5da-4b0c-48f3-98fc-33420bdf8163"),
                PortionId = Guid.Parse("84793ef9-fcd0-42df-ab0d-9380dfa18630"),
            },
            #endregion

            #region FoodPortion 36
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("77fe5e06-7fee-486d-a1a7-c031f2065490"),
                PortionId = Guid.Parse("255ba0f6-14cc-4049-add8-138f27055b49"),
            },
            #endregion

            #region FoodPortion 37
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("6a48ebe2-443c-4c78-9f96-de8ccfbd77db"),
                PortionId = Guid.Parse("f7b36043-9ca9-42c3-8a00-e9e235b56bb3"),
            },
            #endregion

            #region FoodPortion 38
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"),
                PortionId = Guid.Parse("18809fb3-b78a-4f67-b9f9-8bb6ab95ab00"),
            },
            #endregion

            #region FoodPortion 39
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("85822a08-7189-4e08-8f55-25c73698af92"),
                PortionId = Guid.Parse("cd0b1476-44a8-4350-a6a1-3de8747a5ebc"),
            },
            #endregion

            #region FoodPortion 40
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"),
                PortionId = Guid.Parse("5afaa147-398e-4be8-b0d1-8dcabe6ed18c"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"),
                PortionId = Guid.Parse("d3850e1b-4780-490d-8c0c-ced1a9aa323b"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("5d84fcf7-a1ad-4c81-97ea-a0babdaf2bdf"),
                PortionId = Guid.Parse("e09c493c-5806-4b14-bbef-e26e19e1d8d5"),
            },
            #endregion

            #region FoodPortion 41
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("7b3216ff-858e-423e-b8db-a85571aa5488"),
                PortionId = Guid.Parse("5f7f859a-f20a-4f6c-8b8c-ecfbb1ff522e"),
            },
            #endregion

            // #region FoodPortion 42
            // new FoodPortion
            // {
            //     FoodPortionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("f70172ed-7784-47ec-8aa2-a862ee56a13a"),
            //     PortionId = Guid.Parse("2c7ac6ee-f7fe-4ec8-974f-11f62a5f60b9"),
            // },
            // #endregion

            #region FoodPortion 43
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("42883b21-4cbd-40ce-850f-b0723f1766fe"),
                PortionId = Guid.Parse("f0e8f9cd-d133-49cf-be7d-d427b630e05a"),
            },
            #endregion

            #region FoodPortion 44
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("e7221c53-2ea1-485f-ac33-bddf3dc47ae9"),
                PortionId = Guid.Parse("ef6b8c43-9ab5-497c-a9a8-e31f0a349527"),
            },
            #endregion

            #region FoodPortion 45
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("845454d0-967a-4e48-aef3-bd8458775500"),
                PortionId = Guid.Parse("1cddc91d-209a-4948-8e9f-9017252d5423"),
            },
            #endregion

            #region FoodPortion 46
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("a41a3bc6-0f34-409f-9045-0807fbb4469b"),
                PortionId = Guid.Parse("d09266d3-9e7d-46a6-ad3a-7c608ec802d1"),
            },
            #endregion

            #region FoodPortion 47
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("f0132626-5535-4f30-9af4-7e89e086aaaf"),
                PortionId = Guid.Parse("5384aebd-4eab-4a44-8cbb-7ec2c04f1401"),
            },
            #endregion

            #region FoodPortion 48
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("65c7b876-87e2-4307-ab76-c72ca277b78c"),
                PortionId = Guid.Parse("222e1fa2-3910-42ac-9a5c-f371dded16eb"),
            },
            #endregion

            #region FoodPortion 49
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("74181cd5-4b0b-48a9-9042-16d8789483d4"),
                PortionId = Guid.Parse("eff728af-c8f0-4bb5-a985-d079cbadb6b5"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("74181cd5-4b0b-48a9-9042-16d8789483d4"),
                PortionId = Guid.Parse("a5dbb27a-4856-44be-a239-76eb073c3e41"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("74181cd5-4b0b-48a9-9042-16d8789483d4"),
                PortionId = Guid.Parse("a7936b9f-b6f8-4295-8b6e-6fe1b096f437"),
            },
            #endregion

            #region FoodPortion 50
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("a3074169-6441-49cc-9ea7-79e240f6dda3"),
                PortionId = Guid.Parse("e23d4491-73d1-45b5-8010-0385d7185c98"),
            },
            #endregion

            // #region FoodPortion 51
            // new FoodPortion
            // {
            //     FoodPortionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("ede931f5-092e-4e41-8ce1-5a95bff2772a"),
            //     PortionId = Guid.Parse("0336a88f-f5cd-4cc2-8478-980467aa91aa"),
            // },
            // #endregion

            #region FoodPortion 52
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("d30f804f-c59b-4a59-bf4c-5196b302d1ed"),
                PortionId = Guid.Parse("bdd1ee1e-3a93-421f-855e-0993c7e6f767"),
            },
            #endregion

            #region FoodPortion 53
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("7268b449-cb54-4f3d-9709-f42b9966d707"),
                PortionId = Guid.Parse("c4993d6a-a2e0-4ddd-821a-0629541e019c"),
            },
            #endregion

            #region FoodPortion 54
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("77243d82-a633-4fe8-84c9-61a4b6cd4428"),
                PortionId = Guid.Parse("5a1bc1cb-ed0b-49bf-9c1a-5494db962d27"),
            },
            #endregion

            #region FoodPortion 55
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"),
                PortionId = Guid.Parse("8ecbc063-8d6e-450d-af39-0ba28bc572bf"),
            },
            #endregion

            #region FoodPortion 56
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"),
                PortionId = Guid.Parse("16dc894a-746e-497e-a2c5-2d58f7f83c4d"),
            },
            #endregion

            #region FoodPortion 57
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("dc8adf68-02d5-4668-ab6e-74d7ce44bae1"),
                PortionId = Guid.Parse("30f41ca6-c420-4f7d-9602-bf80735d5691"),
            },
            #endregion

            #region FoodPortion 58
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("fc85f2de-9aae-4ff4-a829-e01662a42976"),
                PortionId = Guid.Parse("1cf439ce-a31b-4b95-b092-b7f6edf8d40f"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("fc85f2de-9aae-4ff4-a829-e01662a42976"),
                PortionId = Guid.Parse("ad9ecd1e-40ec-414a-be69-b16e7013b377"),
            },
            #endregion

            #region FoodPortion 59
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("afe0a180-0077-4fdf-89e8-9513c6132f92"),
                PortionId = Guid.Parse("1802caa2-cfe0-48e7-8580-29165f84387d"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("afe0a180-0077-4fdf-89e8-9513c6132f92"),
                PortionId = Guid.Parse("21e32570-7d64-4cec-b711-873185c76523"),
            },
            #endregion

            #region FoodPortion 60
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("16066b9b-e61f-4354-803b-e2f9c9f5a5db"),
                PortionId = Guid.Parse("9c276c0b-84b6-4216-8dbb-ae2034ac2176"),
            },
            #endregion

            #region FoodPortion 61
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("e7468877-17ed-4bb9-9956-5e3cf6a58bde"),
                PortionId = Guid.Parse("d9dad801-145a-419d-bbe2-408acf97a273"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("e7468877-17ed-4bb9-9956-5e3cf6a58bde"),
                PortionId = Guid.Parse("bf0f7ca4-9089-4800-95d7-8d037d98b7fc"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("e7468877-17ed-4bb9-9956-5e3cf6a58bde"),
                PortionId = Guid.Parse("56681171-ccbd-4700-90bc-2233c1e661bb"),
            },
            #endregion

            #region FoodPortion 62
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("4d640470-857a-4765-905f-e49e98a281a1"),
                PortionId = Guid.Parse("709578ca-672f-461e-995d-dc78aeda8c4c"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("4d640470-857a-4765-905f-e49e98a281a1"),
                PortionId = Guid.Parse("f928b7a6-2558-478a-bc22-515516f4dc74"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("4d640470-857a-4765-905f-e49e98a281a1"),
                PortionId = Guid.Parse("23ce32a0-6597-4b60-b35c-98073ff595c6"),
            },
            #endregion

            #region FoodPortion 63
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("5ebbc839-81e6-496f-9e4d-8d90d732a906"),
                PortionId = Guid.Parse("bad70aff-4237-4c83-b412-460020a5ee44"),
            },
            #endregion

            //#region FoodPortion 64
            //new FoodPortion
            //{
            //    FoodPortionId = Guid.NewGuid(),
            //    FoodId = Guid.Parse("857b3565-b170-4162-a97b-c0184c4258aa"),
            //    PortionId = Guid.Parse("8c141b0b-f09b-486e-b75a-04fa194d412c"),
            //},
            //new FoodPortion
            //{
            //    FoodPortionId = Guid.NewGuid(),
            //    FoodId = Guid.Parse("857b3565-b170-4162-a97b-c0184c4258aa"),
            //    PortionId = Guid.Parse("f359ba3c-6597-40ad-9dbd-6719ff302994"),
            //},
            //new FoodPortion
            //{
            //    FoodPortionId = Guid.NewGuid(),
            //    FoodId = Guid.Parse("857b3565-b170-4162-a97b-c0184c4258aa"),
            //    PortionId = Guid.Parse("b6b0faee-84e8-4a16-a8f7-4b8719787e8a"),
            //},
            //#endregion

            #region FoodPortion 65
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"),
                PortionId = Guid.Parse("59589114-7d6a-4c80-8681-db5c554ab38f"),
            },
            #endregion

            // #region FoodPortion 66
            // new FoodPortion
            // {
            //     FoodPortionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("27dd8629-4564-478a-b049-6c4b81ee3cf1"),
            //     PortionId = Guid.Parse("13672611-5453-40a0-9b58-33c2e552bf57"),
            // },
            // new FoodPortion
            // {
            //     FoodPortionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("27dd8629-4564-478a-b049-6c4b81ee3cf1"),
            //     PortionId = Guid.Parse("f01f8da7-9d7b-4893-999f-cf30e719e010"),
            // },
            // #endregion

            #region FoodPortion 67
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("16bf44f2-711d-4b64-a409-995c6b0c13ce"),
                PortionId = Guid.Parse("c65d34ee-8c0c-43bb-9d4e-aa39955a4768"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("16bf44f2-711d-4b64-a409-995c6b0c13ce"),
                PortionId = Guid.Parse("f9bc9ae8-e42e-4e8b-84d3-f2bc36037552"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("16bf44f2-711d-4b64-a409-995c6b0c13ce"),
                PortionId = Guid.Parse("bd16f0ec-5ae1-42f4-a302-b4bce8f0db28"),
            },
            #endregion

            #region FoodPortion 68
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("58fe08ca-5c52-4847-800e-b9970c3782f0"),
                PortionId = Guid.Parse("549d664a-eb1c-4b9a-8ad7-fab9e1482e5b"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("58fe08ca-5c52-4847-800e-b9970c3782f0"),
                PortionId = Guid.Parse("e45c2156-a98c-4121-90b4-25097e8a5cd1"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("58fe08ca-5c52-4847-800e-b9970c3782f0"),
                PortionId = Guid.Parse("7b138bd4-4d3a-426c-9ab0-d66699b762d2"),
            },
            #endregion

            #region FoodPortion 69
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("1d0feb2f-0735-4333-87ce-09e22304ad0d"),
                PortionId = Guid.Parse("2892c25f-bd50-4bb4-a845-997395ef6693"),
            },
            #endregion

            #region FoodPortion 70
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("a782e478-d5c5-4da6-b809-180b48ad08c3"),
                PortionId = Guid.Parse("03a92c0b-b7f6-4283-8109-a35898d5d3c5"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("a782e478-d5c5-4da6-b809-180b48ad08c3"),
                PortionId = Guid.Parse("fc245902-ef53-4363-b4ce-0e598e1dd4a4"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("a782e478-d5c5-4da6-b809-180b48ad08c3"),
                PortionId = Guid.Parse("da254ee7-d229-4769-bad5-a617d09676d4"),
            },
            #endregion

            #region FoodPortion 71
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("c16aac77-64ee-476d-a646-a3029da83e41"),
                PortionId = Guid.Parse("3d6d946f-8d9f-479a-b27e-3d78dc354db0"),
            },
            #endregion

            #region FoodPortion 72
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"),
                PortionId = Guid.Parse("424ebe64-6570-4d88-9052-08c06dc0a2c8"),
            },
            #endregion

            #region FoodPortion 73
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("8893c58d-06fd-4c34-9e77-2f50779642dd"),
                PortionId = Guid.Parse("5adcb96d-70ef-403d-89c6-cc3aa807b6a7"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("8893c58d-06fd-4c34-9e77-2f50779642dd"),
                PortionId = Guid.Parse("5a9ac478-aa65-48ea-9387-1ad92f6c76b1"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("8893c58d-06fd-4c34-9e77-2f50779642dd"),
                PortionId = Guid.Parse("113f6a04-87c4-43c6-8263-920bd099c8e0"),
            },
            #endregion

            #region FoodPortion 74
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("80ba2672-d26a-4703-98f0-d246a50f92f1"),
                PortionId = Guid.Parse("d2e88505-bbd6-4af6-9a88-535896c5d587"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("80ba2672-d26a-4703-98f0-d246a50f92f1"),
                PortionId = Guid.Parse("3f19ef5c-3c60-4a11-b1b3-5158859f1286"),
            },
            #endregion

            #region FoodPortion 75
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("22d1cbad-a884-400c-b681-30b17d98bf1c"),
                PortionId = Guid.Parse("7e071bd6-6afa-483d-8688-28b31b9a8bef"),
            },
            #endregion

            #region FoodPortion 76
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("c81a404a-ec10-428e-acec-dd56ec1d3607"),
                PortionId = Guid.Parse("d6c41cdb-4735-4b9e-85ae-1f48f33b7d6c"),
            },
            #endregion

            // #region FoodPortion 77
            // new FoodPortion
            // {
            //     FoodPortionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("01708b02-6cc1-41f6-ae4a-95c4085e1839"),
            //     PortionId = Guid.Parse("b9423874-3290-4fda-9996-7c13d7c61d96"),
            // },
            // #endregion

            // #region FoodPortion 78
            // new FoodPortion
            // {
            //     FoodPortionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("436d8364-15fd-47a2-9b72-c3841db0da2e"),
            //     PortionId = Guid.Parse("2b7a3473-9f67-4938-b419-7cafa8f72a41"),
            // },
            // #endregion

            #region FoodPortion 79
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("55bd2b96-0e5f-4be4-acae-25f5e3e25244"),
                PortionId = Guid.Parse("a43d7637-6fc7-421b-86f1-f83e691431a4"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("55bd2b96-0e5f-4be4-acae-25f5e3e25244"),
                PortionId = Guid.Parse("6e98f2be-9196-4c4e-8279-b02010f853f1"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("55bd2b96-0e5f-4be4-acae-25f5e3e25244"),
                PortionId = Guid.Parse("e00ed683-11ff-4c21-8b1c-576b448726c9"),
            },
            #endregion

            // #region FoodPortion 80
            // new FoodPortion
            // {
            //     FoodPortionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("db3cd633-2350-4143-ae1f-ccc853583755"),
            //     PortionId = Guid.Parse("509da3d8-ed0f-4cd0-be26-3a896b9500b3"),
            // },
            // new FoodPortion
            // {
            //     FoodPortionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("db3cd633-2350-4143-ae1f-ccc853583755"),
            //     PortionId = Guid.Parse("8bffc4ad-afcc-436b-953c-444f1e8ce533"),
            // },
            // new FoodPortion
            // {
            //     FoodPortionId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("db3cd633-2350-4143-ae1f-ccc853583755"),
            //     PortionId = Guid.Parse("28f6a369-f694-437d-82eb-944b09d5e369"),
            // },
            // #endregion

            #region FoodPortion 81
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("aaeb8b86-48b3-454c-a299-ec5a627f7047"),
                PortionId = Guid.Parse("63d10d95-7983-455e-b920-29c1f0c88d85"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("aaeb8b86-48b3-454c-a299-ec5a627f7047"),
                PortionId = Guid.Parse("919c7f66-53e5-46bd-b181-558f6052b953"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("aaeb8b86-48b3-454c-a299-ec5a627f7047"),
                PortionId = Guid.Parse("87409e4f-4bea-4bba-855d-a3bfbc2f9c20"),
            },
            #endregion

            #region FoodPortion 82
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("2e641c82-56f7-480d-b216-63723b5a5e7d"),
                PortionId = Guid.Parse("26dcc6e0-67aa-40ed-b3d1-8a009c60a62c"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("2e641c82-56f7-480d-b216-63723b5a5e7d"),
                PortionId = Guid.Parse("3c7d60d4-60da-4f51-9448-30877b126572"),
            },
            new FoodPortion
            {
                FoodPortionId = Guid.NewGuid(),
                FoodId = Guid.Parse("2e641c82-56f7-480d-b216-63723b5a5e7d"),
                PortionId = Guid.Parse("9c3399d1-72db-4e86-a518-2575033bb6a8"),
            }
            #endregion
           );
        }
    }
}
