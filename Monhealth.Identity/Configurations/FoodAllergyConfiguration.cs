using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Core;

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
                FoodAllergyId = Guid.Parse("12536007-f0ee-4103-ac40-596416fbb64c"),
                FoodId = Guid.Parse("08b5c5da-4b0c-48f3-98fc-33420bdf8163"),
                AllergyId = Guid.Parse("16acfb07-feee-4bb9-ad2b-05e5b93d18e6")
            },
            #endregion

            #region FoodAllergy 2
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("32bc349f-caa3-4f23-90d1-15e174b56dae"),
                FoodId = Guid.Parse("08b5c5da-4b0c-48f3-98fc-33420bdf8163"),
                AllergyId = Guid.Parse("10127b02-786f-462b-8ee6-3df465903645")
            },
            #endregion

            #region FoodAllergy 3
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("575bf09f-9d81-4931-a987-de015da6b6fa"),
                FoodId = Guid.Parse("c42e7f00-ea31-430a-ac28-8d6e749b7eca"),
                AllergyId = Guid.Parse("70fef89b-5b02-4d6c-81e0-40592eefcb2a")
            },
            #endregion

            #region FoodAllergy 4
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("83143049-d2ba-4a1c-939c-ccba2cc7dec4"),
                FoodId = Guid.Parse("021b651c-bb01-4965-95bc-3532fbacad3d"),
                AllergyId = Guid.Parse("d0127ea2-7f55-4515-b5ea-3db55af5774e")
            },
            #endregion

            #region FoodAllergy 5
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("ac7c4180-49d8-45c6-b12c-ec0b9f3cd37f"),
                FoodId = Guid.Parse("a17722bf-899e-40e9-8e54-ae2fc8a34f44"),
                AllergyId = Guid.Parse("d0127ea2-7f55-4515-b5ea-3db55af5774e")
            },
            #endregion

            #region FoodAllergy 6
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("c5e7d22e-8b34-45de-bc87-020dcbeb307f"),
                FoodId = Guid.Parse("19bbab17-91c6-410f-b566-b509d067e76e"),
                AllergyId = Guid.Parse("3cd5347e-d38d-425c-af19-e9c4ba2646c6")
            },
            #endregion

            #region FoodAllergy 7
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("045893e3-36f1-4fbd-bdf5-0d0f15b03742"),
                FoodId = Guid.Parse("65c7b876-87e2-4307-ab76-c72ca277b78c"),
                AllergyId = Guid.Parse("16acfb07-feee-4bb9-ad2b-05e5b93d18e6")
            },
            #endregion

            #region FoodAllergy 8
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("b7ff2e39-8c5b-4198-bfeb-b2fa23745f67"),
                FoodId = Guid.Parse("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"),
                AllergyId = Guid.Parse("3cd5347e-d38d-425c-af19-e9c4ba2646c6")
            },
            #endregion

            #region FoodAllergy 9
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("1e61d22d-5a80-47a0-917c-c16b8df4b5b5"),
                FoodId = Guid.Parse("f412d88d-ce7e-4006-bc11-75af61438491"),
                AllergyId = Guid.Parse("10127b02-786f-462b-8ee6-3df465903645")
            },
            #endregion

            #region FoodAllergy 10
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("eff52e10-2e5d-48ea-9c53-f276634379bc"),
                FoodId = Guid.Parse("05cfce09-72b4-482d-adcd-c0718015be3d"),
                AllergyId = Guid.Parse("16acfb07-feee-4bb9-ad2b-05e5b93d18e6")
            },
            #endregion

            #region FoodAllergy 11
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("dbf35b97-4316-4f1a-b897-6ae644ad01bc"),
                FoodId = Guid.Parse("a782e478-d5c5-4da6-b809-180b48ad08c3"),
                AllergyId = Guid.Parse("70fef89b-5b02-4d6c-81e0-40592eefcb2a")
            },
            #endregion

            #region FoodAllergy 12
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("ca49c0a5-53b7-47b4-8f12-6545b5098da4"),
                FoodId = Guid.Parse("f41484a3-c7df-4530-b7d2-060390103985"),
                AllergyId = Guid.Parse("70fef89b-5b02-4d6c-81e0-40592eefcb2a")
            },
            #endregion

            #region FoodAllergy 13
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("06efb992-c2d6-4535-9c2d-1a0cb556df92"),
                FoodId = Guid.Parse("e7468877-17ed-4bb9-9956-5e3cf6a58bde"),
                AllergyId = Guid.Parse("b8f6417e-2aac-442e-aac4-de4d809c572c")
            },
            #endregion

            #region FoodAllergy 14
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("fa719ef6-9cb6-4292-92a8-e7a82d4b48d1"),
                FoodId = Guid.Parse("e7468877-17ed-4bb9-9956-5e3cf6a58bde"),
                AllergyId = Guid.Parse("0d352b08-ada9-40f6-a23e-6f6f170a9cd4")
            },
            #endregion

            #region FoodAllergy 15
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("847f29d6-b7d1-4b6b-9e77-2a477b982dd2"),
                FoodId = Guid.Parse("46b9f487-dc6d-4c1d-9729-9f707ac28202"),
                AllergyId = Guid.Parse("16acfb07-feee-4bb9-ad2b-05e5b93d18e6")
            },
            #endregion

            #region FoodAllergy 16
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("9fa8b5d3-d20b-4c7e-a2b8-6b163d3a9d7e"),
                FoodId = Guid.Parse("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"),
                AllergyId = Guid.Parse("70fef89b-5b02-4d6c-81e0-40592eefcb2a")
            },
            #endregion

            #region FoodAllergy 17
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("d3eaf6d0-073b-4385-9ff7-9c361f46a882"),
                FoodId = Guid.Parse("faf19891-525a-4308-9222-992e83de7ce7"),
                AllergyId = Guid.Parse("b8f6417e-2aac-442e-aac4-de4d809c572c")
            },
            #endregion

            #region FoodAllergy 18
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("837dbd30-cb43-414b-b50f-cf5b32255681"),
                FoodId = Guid.Parse("faf19891-525a-4308-9222-992e83de7ce7"),
                AllergyId = Guid.Parse("eb5cadbb-94e2-4bf9-8764-ddef8779ebd8")
            },
            #endregion

            #region FoodAllergy 19
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("7f5ae68b-7e60-44f4-bd13-d8b251cdfa3d"),
                FoodId = Guid.Parse("a53672e7-8593-4779-bd02-9f02ae81f915"),
                AllergyId = Guid.Parse("b8f6417e-2aac-442e-aac4-de4d809c572c")
            },
            #endregion

            #region FoodAllergy 20
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("5d72b3a1-bcd8-4951-9f0a-6b73bca63aa3"),
                FoodId = Guid.Parse("ede931f5-092e-4e41-8ce1-5a95bff2772a"),
                AllergyId = Guid.Parse("b8f6417e-2aac-442e-aac4-de4d809c572c")
            },
            #endregion

            #region FoodAllergy 21
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("bb419ec6-79f7-4bd7-aee7-5b3edcc29b42"),
                FoodId = Guid.Parse("ede931f5-092e-4e41-8ce1-5a95bff2772a"),
                AllergyId = Guid.Parse("0d352b08-ada9-40f6-a23e-6f6f170a9cd4")
            },
            #endregion

            #region FoodAllergy 22
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("dcf2b60b-b08e-4c1b-96d0-0ae5af6202c3"),
                FoodId = Guid.Parse("dd1482e7-b3dd-4b17-80f6-5618a640c671"),
                AllergyId = Guid.Parse("eb5cadbb-94e2-4bf9-8764-ddef8779ebd8")
            },
            #endregion

            #region FoodAllergy 23
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("2bd755e1-7ea6-47a8-8d29-dc9357a17063"),
                FoodId = Guid.Parse("ef8b0ee3-a4d5-4883-af63-33c83d102bea"),
                AllergyId = Guid.Parse("70fef89b-5b02-4d6c-81e0-40592eefcb2a")
            },
            #endregion

            #region FoodAllergy 24
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("1603c0e4-e0db-4b89-9f85-d120e87f4a6e"),
                FoodId = Guid.Parse("22d1cbad-a884-400c-b681-30b17d98bf1c"),
                AllergyId = Guid.Parse("3cd5347e-d38d-425c-af19-e9c4ba2646c6")
            },
            #endregion

            #region FoodAllergy 25
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("30192e2a-97ef-4398-87f2-5d4d31238e3a"),
                FoodId = Guid.Parse("c81a404a-ec10-428e-acec-dd56ec1d3607"),
                AllergyId = Guid.Parse("b82f4697-2ad0-4777-a29b-094c99f46d10")
            },
            #endregion

            #region FoodAllergy 26
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("dcb56844-ea6b-4e54-9898-5d9c9723844b"),
                FoodId = Guid.Parse("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"),
                AllergyId = Guid.Parse("b8f6417e-2aac-442e-aac4-de4d809c572c")
            },
            #endregion

            #region FoodAllergy 27
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("4251a67b-d828-46c1-a1e2-2795e6f63a8d"),
                FoodId = Guid.Parse("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"),
                AllergyId = Guid.Parse("eb5cadbb-94e2-4bf9-8764-ddef8779ebd8")
            },
            #endregion


            #region FoodAllergy 28
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("6b1f19c7-faa3-4926-bc45-d88bc44c99d5"),
                FoodId = Guid.Parse("01708b02-6cc1-41f6-ae4a-95c4085e1839"),
                AllergyId = Guid.Parse("13008773-dadd-4053-b64c-500b6050b2aa")
            },
            #endregion

            #region FoodAllergy 29
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("e8e22c46-7403-44a9-80f4-7c5d9af6da25"),
                FoodId = Guid.Parse("436d8364-15fd-47a2-9b72-c3841db0da2e"),
                AllergyId = Guid.Parse("d0127ea2-7f55-4515-b5ea-3db55af5774e")
            }
            #endregion

            );
        }
    }
}