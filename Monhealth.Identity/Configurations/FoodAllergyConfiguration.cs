using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class FoodAllergyConfiguration : IEntityTypeConfiguration<FoodAllergy>
    {
        public void Configure(EntityTypeBuilder<FoodAllergy> builder)
        {
            builder.HasData(

            #region FoodAllergy 1
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("08b5c5da-4b0c-48f3-98fc-33420bdf8163"),
                AllergyId = Guid.Parse("1ada29ad-354a-44aa-b402-3f8a9c854e56")
            },
            #endregion

            #region FoodAllergy 2
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("c42e7f00-ea31-430a-ac28-8d6e749b7eca"),
                AllergyId = Guid.Parse("ea406418-19d1-43dc-96a2-9abf97b9d2a5")
            },
            #endregion

            #region FoodAllergy 3
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("021b651c-bb01-4965-95bc-3532fbacad3d"),
                AllergyId = Guid.Parse("b52d2f0a-e728-42dc-90c6-bd0310bc0de6")
            },
            #endregion

            #region FoodAllergy 4
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("a41a3bc6-0f34-409f-9045-0807fbb4469b"),
                AllergyId = Guid.Parse("91df2b87-a28d-4e89-a779-d4220d68a0f8")
            },
            #endregion

            #region FoodAllergy 5
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("7378ca5f-f1a8-4c23-a019-50af3012526f"),
                AllergyId = Guid.Parse("1ada29ad-354a-44aa-b402-3f8a9c854e56")
            },
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("7378ca5f-f1a8-4c23-a019-50af3012526f"),
                AllergyId = Guid.Parse("ea406418-19d1-43dc-96a2-9abf97b9d2a5")
            },
            #endregion

            #region FoodAllergy 6
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("a17722bf-899e-40e9-8e54-ae2fc8a34f44"),
                AllergyId = Guid.Parse("b52d2f0a-e728-42dc-90c6-bd0310bc0de6")
            },
            #endregion

            #region FoodAllergy 7
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("19bbab17-91c6-410f-b566-b509d067e76e"),
                AllergyId = Guid.Parse("c87bd979-3dde-4a47-9f1c-7eef88c6c041")
            },
            #endregion

            #region FoodAllergy 8
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("21a4b410-e26d-444b-8b99-bf8b490e5dcf"),
                AllergyId = Guid.Parse("1ada29ad-354a-44aa-b402-3f8a9c854e56")
            },
            #endregion

            #region FoodAllergy 9
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("65c7b876-87e2-4307-ab76-c72ca277b78c"),
                AllergyId = Guid.Parse("1ada29ad-354a-44aa-b402-3f8a9c854e56")
            },
            #endregion

            #region FoodAllergy 10
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("f77e03de-4ed3-41ca-8fa1-0a4947c67384"),
                AllergyId = Guid.Parse("b52d2f0a-e728-42dc-90c6-bd0310bc0de6")
            },
            #endregion

            #region FoodAllergy 11
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("d4df84f2-2d79-41e6-b313-28e89e3785ba"),
                AllergyId = Guid.Parse("91df2b87-a28d-4e89-a779-d4220d68a0f8")
            },
            #endregion

            #region FoodAllergy 12
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("6c3f28ec-f25a-4471-ba9b-f46568e1ccee"),
                AllergyId = Guid.Parse("91df2b87-a28d-4e89-a779-d4220d68a0f8")
            },
            #endregion

            #region FoodAllergy 13
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("df4de54d-ff6c-4db0-9169-b3a0f6eb0865"),
                AllergyId = Guid.Parse("b52d2f0a-e728-42dc-90c6-bd0310bc0de6")
            },
            #endregion

            #region FoodAllergy 14
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"),
                AllergyId = Guid.Parse("c87bd979-3dde-4a47-9f1c-7eef88c6c041")
            },
            #endregion

            #region FoodAllergy 15
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"),
                AllergyId = Guid.Parse("1ada29ad-354a-44aa-b402-3f8a9c854e56")
            },
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("75e6c0f1-a11a-4e2c-a59e-bbe2930c5ebb"),
                AllergyId = Guid.Parse("ea406418-19d1-43dc-96a2-9abf97b9d2a5")
            },
            #endregion

            #region FoodAllergy 16
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("16bf44f2-711d-4b64-a409-995c6b0c13ce"),
                AllergyId = Guid.Parse("b52d2f0a-e728-42dc-90c6-bd0310bc0de6")
            },
            #endregion

            #region FoodAllergy 17
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("fa445aa4-7b0d-4d47-8ba7-f919dd123637"),
                AllergyId = Guid.Parse("b52d2f0a-e728-42dc-90c6-bd0310bc0de6")
            },
            #endregion

            #region FoodAllergy 18
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("05cfce09-72b4-482d-adcd-c0718015be3d"),
                AllergyId = Guid.Parse("1ada29ad-354a-44aa-b402-3f8a9c854e56")
            },
            #endregion

            // #region FoodAllergy 19
            // new FoodAllergy
            // {
            //     FoodAllergyId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("a782e478-d5c5-4da6-b809-180b48ad08c3"),
            //     AllergyId = Guid.Parse("ea406418-19d1-43dc-96a2-9abf97b9d2a5")
            // },
            // #endregion

            // #region FoodAllergy 20
            // new FoodAllergy
            // {
            //     FoodAllergyId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("f41484a3-c7df-4530-b7d2-060390103985"),
            //     AllergyId = Guid.Parse("ea406418-19d1-43dc-96a2-9abf97b9d2a5")
            // },
            // #endregion

            #region FoodAllergy 21
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("e7468877-17ed-4bb9-9956-5e3cf6a58bde"),
                AllergyId = Guid.Parse("91df2b87-a28d-4e89-a779-d4220d68a0f8")
            },
            #endregion

            #region FoodAllergy 22
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("dfa879e8-d77d-4199-b07b-16b37f1cbde1"),
                AllergyId = Guid.Parse("91df2b87-a28d-4e89-a779-d4220d68a0f8")
            },
            #endregion

            #region FoodAllergy 23
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("c16aac77-64ee-476d-a646-a3029da83e41"),
                AllergyId = Guid.Parse("1ada29ad-354a-44aa-b402-3f8a9c854e56")
            },
            #endregion

            #region FoodAllergy 24
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("48b3d9d3-1ea4-4c96-a3e0-68268d108d2b"),
                AllergyId = Guid.Parse("91df2b87-a28d-4e89-a779-d4220d68a0f8")
            },
            #endregion

            #region FoodAllergy 25
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("5ff26461-880d-4b94-bfd0-e8badc77fe33"),
                AllergyId = Guid.Parse("ea406418-19d1-43dc-96a2-9abf97b9d2a5")
            },
            #endregion

            #region FoodAllergy 26
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("d30f804f-c59b-4a59-bf4c-5196b302d1ed"),
                AllergyId = Guid.Parse("ea406418-19d1-43dc-96a2-9abf97b9d2a5")
            },
            #endregion

            #region FoodAllergy 27
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"),
                AllergyId = Guid.Parse("91df2b87-a28d-4e89-a779-d4220d68a0f8")
            },
            #endregion

            #region FoodAllergy 28
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("2600b6c1-8365-47ae-adc7-e7de2ccb18ad"),
                AllergyId = Guid.Parse("1ada29ad-354a-44aa-b402-3f8a9c854e56")
            },
            #endregion

            #region FoodAllergy 29
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("faf19891-525a-4308-9222-992e83de7ce7"),
                AllergyId = Guid.Parse("9e356dc9-ab35-4b54-aa35-37e35d2cc41f")
            },
            #endregion

            #region FoodAllergy 30
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("a53672e7-8593-4779-bd02-9f02ae81f915"),
                AllergyId = Guid.Parse("91df2b87-a28d-4e89-a779-d4220d68a0f8")
            },
            #endregion

            #region FoodAllergy 31
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("7268b449-cb54-4f3d-9709-f42b9966d707"),
                AllergyId = Guid.Parse("91df2b87-a28d-4e89-a779-d4220d68a0f8")
            },
            #endregion

            #region FoodAllergy 32
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("dd1482e7-b3dd-4b17-80f6-5618a640c671"),
                AllergyId = Guid.Parse("9e356dc9-ab35-4b54-aa35-37e35d2cc41f")
            },
            #endregion

            #region FoodAllergy 33
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("ef8b0ee3-a4d5-4883-af63-33c83d102bea"),
                AllergyId = Guid.Parse("1ada29ad-354a-44aa-b402-3f8a9c854e56")
            },
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("ef8b0ee3-a4d5-4883-af63-33c83d102bea"),
                AllergyId = Guid.Parse("ea406418-19d1-43dc-96a2-9abf97b9d2a5")
            },
            #endregion

            #region FoodAllergy 34
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("22d1cbad-a884-400c-b681-30b17d98bf1c"),
                AllergyId = Guid.Parse("c87bd979-3dde-4a47-9f1c-7eef88c6c041")
            },
            #endregion

            #region FoodAllergy 35
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"),
                AllergyId = Guid.Parse("9e356dc9-ab35-4b54-aa35-37e35d2cc41f")
            },
            #endregion

            #region FoodAllergy 36
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("16066b9b-e61f-4354-803b-e2f9c9f5a5db"),
                AllergyId = Guid.Parse("c87bd979-3dde-4a47-9f1c-7eef88c6c041")
            },
            #endregion

            #region FoodAllergy 37
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("edb9d5d0-01f3-4607-a406-9e04bbff85fb"),
                AllergyId = Guid.Parse("9e356dc9-ab35-4b54-aa35-37e35d2cc41f")
            },
            #endregion

            #region FoodAllergy 38
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("4d640470-857a-4765-905f-e49e98a281a1"),
                AllergyId = Guid.Parse("91df2b87-a28d-4e89-a779-d4220d68a0f8")
            },
            #endregion

            #region FoodAllergy 39
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("adeb902f-fb34-44eb-aa60-76eaeb0ed70b"),
                AllergyId = Guid.Parse("9e356dc9-ab35-4b54-aa35-37e35d2cc41f")
            },
            #endregion

            #region FoodAllergy 40
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("3fa8cf38-d835-4279-a113-a8f44cd013e6"),
                AllergyId = Guid.Parse("c87bd979-3dde-4a47-9f1c-7eef88c6c041")
            },
            #endregion

            #region FoodAllergy 41
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("d3392e5d-a48f-4b5a-968d-31b98bd47835"),
                AllergyId = Guid.Parse("b52d2f0a-e728-42dc-90c6-bd0310bc0de6")
            },
            #endregion

            #region FoodAllergy 42
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("5ebbc839-81e6-496f-9e4d-8d90d732a906"),
                AllergyId = Guid.Parse("9e356dc9-ab35-4b54-aa35-37e35d2cc41f")
            },
            #endregion

            #region FoodAllergy 43
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("50c0adac-c878-4a21-8b5f-01478e7e4852"),
                AllergyId = Guid.Parse("c87bd979-3dde-4a47-9f1c-7eef88c6c041")
            },
            #endregion

            #region FoodAllergy 44
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("a23f6c85-1a80-4255-a9a1-d08c1d60e753"),
                AllergyId = Guid.Parse("9e356dc9-ab35-4b54-aa35-37e35d2cc41f")
            },
            #endregion

            // #region FoodAllergy 45
            // new FoodAllergy
            // {
            //     FoodAllergyId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("b0f051be-5972-4e7a-a77d-47ec28d58993"),
            //     AllergyId = Guid.Parse("0eec9d43-391c-43c6-9635-01ca2d6fc66c")
            // },
            // #endregion

            #region FoodAllergy 46
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("8da16f72-42a9-4da2-b217-811903e340c4"),
                AllergyId = Guid.Parse("c87bd979-3dde-4a47-9f1c-7eef88c6c041")
            },
            #endregion

            // #region FoodAllergy 47
            // new FoodAllergy
            // {
            //     FoodAllergyId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("59988378-901f-4ec4-bd6c-9fdc28ca97a1"),
            //     AllergyId = Guid.Parse("0eec9d43-391c-43c6-9635-01ca2d6fc66c")
            // },
            // #endregion

            #region FoodAllergy 48
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("98b3945a-9169-4581-b1a5-da82f2ebd8d4"),
                AllergyId = Guid.Parse("b52d2f0a-e728-42dc-90c6-bd0310bc0de6")
            },
            #endregion

            // #region FoodAllergy 49
            // new FoodAllergy
            // {
            //     FoodAllergyId = Guid.NewGuid(),
            //     FoodId = Guid.Parse("4e46f955-4413-496f-97b4-968a38ee3e11"),
            //     AllergyId = Guid.Parse("0eec9d43-391c-43c6-9635-01ca2d6fc66c")
            // },
            // #endregion

            #region FoodAllergy 50
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("404a286a-90c5-4c54-8e27-3ddeba55ada3"),
                AllergyId = Guid.Parse("0eec9d43-391c-43c6-9635-01ca2d6fc66c")
            },
            #endregion

            #region FoodAllergy 51
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("d3c360a2-441e-4700-a6ec-4310b5976901"),
                AllergyId = Guid.Parse("9e356dc9-ab35-4b54-aa35-37e35d2cc41f")
            },
            #endregion

            #region FoodAllergy 52
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("731974ef-495e-4c08-ba95-20589d60c20c"),
                AllergyId = Guid.Parse("0eec9d43-391c-43c6-9635-01ca2d6fc66c")
            },
            #endregion

            #region FoodAllergy 53
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("5f848972-c5ae-45fc-8ba2-103b24d8a23a"),
                AllergyId = Guid.Parse("91df2b87-a28d-4e89-a779-d4220d68a0f8")
            },
            #endregion

            #region FoodAllergy 54
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("63045676-0e70-425f-aa96-e348a4e88c3a"),
                AllergyId = Guid.Parse("91df2b87-a28d-4e89-a779-d4220d68a0f8")
            },
            #endregion

            #region FoodAllergy 55
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("0ece5f0f-9fec-4f74-b948-90dce7ce6ce3"),
                AllergyId = Guid.Parse("9e356dc9-ab35-4b54-aa35-37e35d2cc41f")
            },
            #endregion

            #region FoodAllergy 56
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("d65c7826-78c0-4991-b3b6-1e2b25437f61"),
                AllergyId = Guid.Parse("91df2b87-a28d-4e89-a779-d4220d68a0f8")
            },
            #endregion

            #region FoodAllergy 57
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("90099162-15e0-4ef0-b93e-59d409678b63"),
                AllergyId = Guid.Parse("91df2b87-a28d-4e89-a779-d4220d68a0f8")
            },
            #endregion

            #region FoodAllergy 58
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("9669cdf4-c133-476f-b2bd-f3c091346c52"),
                AllergyId = Guid.Parse("9e356dc9-ab35-4b54-aa35-37e35d2cc41f")
            },
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("9669cdf4-c133-476f-b2bd-f3c091346c52"),
                AllergyId = Guid.Parse("1ada29ad-354a-44aa-b402-3f8a9c854e56")
            },
            #endregion

            #region FoodAllergy 59
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("61b2c4d9-6de2-4fb2-af3b-fe9fabee0bd4"),
                AllergyId = Guid.Parse("91df2b87-a28d-4e89-a779-d4220d68a0f8")
            },
            #endregion

            #region FoodAllergy 60
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("ea63d4c3-41f7-4f89-bf33-e8a16c5d6956"),
                AllergyId = Guid.Parse("91df2b87-a28d-4e89-a779-d4220d68a0f8")
            },
            #endregion

            #region FoodAllergy 61
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("56513d2d-2472-4fa4-80bc-2f54002b187f"),
                AllergyId = Guid.Parse("9e356dc9-ab35-4b54-aa35-37e35d2cc41f")
            },
            #endregion

            #region FoodAllergy 62
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("2d821db4-3e99-4877-b979-bc82d34b3b01"),
                AllergyId = Guid.Parse("1ada29ad-354a-44aa-b402-3f8a9c854e56")
            },
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("2d821db4-3e99-4877-b979-bc82d34b3b01"),
                AllergyId = Guid.Parse("ea406418-19d1-43dc-96a2-9abf97b9d2a5")
            },
            #endregion

            #region FoodAllergy 63
            new FoodAllergy
            {
                FoodAllergyId = Guid.NewGuid(),
                FoodId = Guid.Parse("a1ff09f1-9d02-40a8-84de-8da9aad67c58"),
                AllergyId = Guid.Parse("91df2b87-a28d-4e89-a779-d4220d68a0f8")
            }
            #endregion
            );
        }
    }
}
