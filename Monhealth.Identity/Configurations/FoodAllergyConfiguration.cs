// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Metadata.Builders;
// using Monhealth.Core;

// namespace Monhealth.Identity.Configurations
// {
//     public class FoodAllergyConfiguration : IEntityTypeConfiguration<FoodAllergy>
//     {
//         public void Configure(EntityTypeBuilder<FoodAllergy> builder)
//         {
//             builder.HasData(

//             #region FoodAllergy 1
//             new FoodAllergy
//             {
//                 FoodAllergyId = Guid.NewGuid(),
//                 FoodId = Guid.Parse("08b5c5da-4b0c-48f3-98fc-33420bdf8163"),
//                 AllergyId = Guid.Parse("16acfb07-feee-4bb9-ad2b-05e5b93d18e6")
//             },
//             new FoodAllergy
//             {
//                 FoodAllergyId = Guid.NewGuid(),
//                 FoodId = Guid.Parse("08b5c5da-4b0c-48f3-98fc-33420bdf8163"),
//                 AllergyId = Guid.Parse("10127b02-786f-462b-8ee6-3df465903645")
//             },
//             #endregion

//             #region FoodAllergy 2
//             new FoodAllergy
//             {
//                 FoodAllergyId = Guid.NewGuid(),
//                 FoodId = Guid.Parse("c42e7f00-ea31-430a-ac28-8d6e749b7eca"),
//                 AllergyId = Guid.Parse("70fef89b-5b02-4d6c-81e0-40592eefcb2a")
//             },
//             #endregion

//             #region FoodAllergy 3
//             new FoodAllergy
//             {
//                 FoodAllergyId = Guid.NewGuid(),
//                 FoodId = Guid.Parse("021b651c-bb01-4965-95bc-3532fbacad3d"),
//                 AllergyId = Guid.Parse("d0127ea2-7f55-4515-b5ea-3db55af5774e")
//             },
//             #endregion

//             #region FoodAllergy 4
//             new FoodAllergy
//             {
//                 FoodAllergyId = Guid.NewGuid(),
//                 FoodId = Guid.Parse("a17722bf-899e-40e9-8e54-ae2fc8a34f44"),
//                 AllergyId = Guid.Parse("d0127ea2-7f55-4515-b5ea-3db55af5774e")
//             },
//             #endregion

//             #region FoodAllergy 5
//             new FoodAllergy
//             {
//                 FoodAllergyId = Guid.NewGuid(),
//                 FoodId = Guid.Parse("19bbab17-91c6-410f-b566-b509d067e76e"),
//                 AllergyId = Guid.Parse("3cd5347e-d38d-425c-af19-e9c4ba2646c6")
//             },
//             #endregion

//             #region FoodAllergy 6
//             new FoodAllergy
//             {
//                 FoodAllergyId = Guid.NewGuid(),
//                 FoodId = Guid.Parse("65c7b876-87e2-4307-ab76-c72ca277b78c"),
//                 AllergyId = Guid.Parse("16acfb07-feee-4bb9-ad2b-05e5b93d18e6")
//             },
//             #endregion

//             #region FoodAllergy 7
//             new FoodAllergy
//             {
//                 FoodAllergyId = Guid.NewGuid(),
//                 FoodId = Guid.Parse("2ebaa4b7-3477-46a8-a375-e7a80b1db5b0"),
//                 AllergyId = Guid.Parse("3cd5347e-d38d-425c-af19-e9c4ba2646c6")
//             },
//             #endregion

//             #region FoodAllergy 8
//             new FoodAllergy
//             {
//                 FoodAllergyId = Guid.NewGuid(),
//                 FoodId = Guid.Parse("05cfce09-72b4-482d-adcd-c0718015be3d"),
//                 AllergyId = Guid.Parse("16acfb07-feee-4bb9-ad2b-05e5b93d18e6")
//             },
//             #endregion

//             #region FoodAllergy 9
//             new FoodAllergy
//             {
//                 FoodAllergyId = Guid.NewGuid(),
//                 FoodId = Guid.Parse("a782e478-d5c5-4da6-b809-180b48ad08c3"),
//                 AllergyId = Guid.Parse("70fef89b-5b02-4d6c-81e0-40592eefcb2a")
//             },
//             #endregion

//             #region FoodAllergy 10
//             new FoodAllergy
//             {
//                 FoodAllergyId = Guid.NewGuid(),
//                 FoodId = Guid.Parse("f41484a3-c7df-4530-b7d2-060390103985"),
//                 AllergyId = Guid.Parse("70fef89b-5b02-4d6c-81e0-40592eefcb2a")
//             },
//             #endregion

//             #region FoodAllergy 11
//             new FoodAllergy
//             {
//                 FoodAllergyId = Guid.NewGuid(),
//                 FoodId = Guid.Parse("e7468877-17ed-4bb9-9956-5e3cf6a58bde"),
//                 AllergyId = Guid.Parse("b8f6417e-2aac-442e-aac4-de4d809c572c")
//             },
//             new FoodAllergy
//             {
//                 FoodAllergyId = Guid.NewGuid(),
//                 FoodId = Guid.Parse("e7468877-17ed-4bb9-9956-5e3cf6a58bde"),
//                 AllergyId = Guid.Parse("0d352b08-ada9-40f6-a23e-6f6f170a9cd4")
//             },
//             #endregion

//             #region FoodAllergy 12
//             new FoodAllergy
//             {
//                 FoodAllergyId = Guid.NewGuid(),
//                 FoodId = Guid.Parse("46b9f487-dc6d-4c1d-9729-9f707ac28202"),
//                 AllergyId = Guid.Parse("16acfb07-feee-4bb9-ad2b-05e5b93d18e6")
//             },
//             #endregion

//             #region FoodAllergy 13
//             new FoodAllergy
//             {
//                 FoodAllergyId = Guid.NewGuid(),
//                 FoodId = Guid.Parse("d4e129d5-27c2-494f-8b9c-3485c3a8ea3c"),
//                 AllergyId = Guid.Parse("70fef89b-5b02-4d6c-81e0-40592eefcb2a")
//             },
//             #endregion

//             #region FoodAllergy 14
//             new FoodAllergy
//             {
//                 FoodAllergyId = Guid.NewGuid(),
//                 FoodId = Guid.Parse("faf19891-525a-4308-9222-992e83de7ce7"),
//                 AllergyId = Guid.Parse("b8f6417e-2aac-442e-aac4-de4d809c572c")
//             },
//             new FoodAllergy
//             {
//                 FoodAllergyId = Guid.NewGuid(),
//                 FoodId = Guid.Parse("faf19891-525a-4308-9222-992e83de7ce7"),
//                 AllergyId = Guid.Parse("eb5cadbb-94e2-4bf9-8764-ddef8779ebd8")
//             },
//             #endregion

//             #region FoodAllergy 15
//             new FoodAllergy
//             {
//                 FoodAllergyId = Guid.NewGuid(),
//                 FoodId = Guid.Parse("a53672e7-8593-4779-bd02-9f02ae81f915"),
//                 AllergyId = Guid.Parse("b8f6417e-2aac-442e-aac4-de4d809c572c")
//             },
//             #endregion

//             #region FoodAllergy 16
//             new FoodAllergy
//             {
//                 FoodAllergyId = Guid.NewGuid(),
//                 FoodId = Guid.Parse("dd1482e7-b3dd-4b17-80f6-5618a640c671"),
//                 AllergyId = Guid.Parse("eb5cadbb-94e2-4bf9-8764-ddef8779ebd8")
//             },
//             #endregion

//             #region FoodAllergy 17
//             new FoodAllergy
//             {
//                 FoodAllergyId = Guid.NewGuid(),
//                 FoodId = Guid.Parse("ef8b0ee3-a4d5-4883-af63-33c83d102bea"),
//                 AllergyId = Guid.Parse("70fef89b-5b02-4d6c-81e0-40592eefcb2a")
//             },
//             #endregion

//             #region FoodAllergy 18
//             new FoodAllergy
//             {
//                 FoodAllergyId = Guid.NewGuid(),
//                 FoodId = Guid.Parse("22d1cbad-a884-400c-b681-30b17d98bf1c"),
//                 AllergyId = Guid.Parse("3cd5347e-d38d-425c-af19-e9c4ba2646c6")
//             },
//             #endregion

//             #region FoodAllergy 19
//             new FoodAllergy
//             {
//                 FoodAllergyId = Guid.NewGuid(),
//                 FoodId = Guid.Parse("c81a404a-ec10-428e-acec-dd56ec1d3607"),
//                 AllergyId = Guid.Parse("b82f4697-2ad0-4777-a29b-094c99f46d10")
//             },
//             #endregion

//             #region FoodAllergy 20
//             new FoodAllergy
//             {
//                 FoodAllergyId = Guid.NewGuid(),
//                 FoodId = Guid.Parse("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"),
//                 AllergyId = Guid.Parse("b8f6417e-2aac-442e-aac4-de4d809c572c")
//             },
//             new FoodAllergy
//             {
//                 FoodAllergyId = Guid.NewGuid(),
//                 FoodId = Guid.Parse("81c3c321-4d4d-4e56-93ca-5dac5e69adb4"),
//                 AllergyId = Guid.Parse("eb5cadbb-94e2-4bf9-8764-ddef8779ebd8")
//             }
//             #endregion
//             );
//         }
//     }
// }
