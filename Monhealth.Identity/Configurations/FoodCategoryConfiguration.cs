using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Core;

namespace Monhealth.Identity.Configurations
{
    public class FoodCategoryConfiguration : IEntityTypeConfiguration<FoodCategory>
    {
        public void Configure(EntityTypeBuilder<FoodCategory> builder)
        {
           builder.HasData(
            new FoodCategory{
                 FoodCategoryId = Guid.Parse("17d4b096-43fb-4ead-aa15-b4f3796a0095"),
                 CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                 FoodId = Guid.Parse("b6fa82bc-715c-42da-af22-93290d3f2421")
            },
            new FoodCategory{
                 FoodCategoryId = Guid.Parse("a82c5ca4-16d0-4f8c-aca7-0c8a8eb9c195"),
                 CategoryId = Guid.Parse("22ee062d-4904-4c64-a783-74b3e142aac7"),
                 FoodId = Guid.Parse("a3be942d-a225-44fb-9c98-22a109995145")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("c412b3ae-23d1-4f64-9cb2-b4208f29c1c4"),
                 CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                 FoodId = Guid.Parse("f789601f-8026-499b-98cb-0f189926094a")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("714cb573-594e-47d0-a017-2f51d1588bf8"),
                 CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                 FoodId = Guid.Parse("f789601f-8026-499b-98cb-0f189926094a")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("ecd2cc49-a429-4f77-b074-d5bdf407b720"),
                 CategoryId = Guid.Parse("fe3a3546-b294-4665-9c82-092d4ab5a187"),
                 FoodId = Guid.Parse("52c7f28c-1d5a-470e-87cd-2be1ab0ac3db")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("b534c4d6-bd93-4825-8866-05a8d7a282cb"),
                 CategoryId = Guid.Parse("22ee062d-4904-4c64-a783-74b3e142aac7"),
                 FoodId = Guid.Parse("52c7f28c-1d5a-470e-87cd-2be1ab0ac3db")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("d340e3a2-f56c-48be-b33b-93e1c655abd4"),
                 CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                 FoodId = Guid.Parse("c82a256d-5573-4d27-b045-a411db42e694")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("542ed436-d4ab-44e9-971d-f3fd64b1d305"),
                 CategoryId = Guid.Parse("ee39be57-cf88-4420-8e19-606b2ed4dc6d"),
                 FoodId = Guid.Parse("c567f8a9-71e4-4167-839d-a839ece79427")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("400db0ab-1a3e-4de5-b0e0-68a01663c2e7"),
                 CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                 FoodId = Guid.Parse("c567f8a9-71e4-4167-839d-a839ece79427")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("c8f19b8c-8487-4c74-acc9-5e6c1cf5a80b"),
                 CategoryId = Guid.Parse("19fe32e8-9e15-486b-9398-f0116cd5019a"),
                 FoodId = Guid.Parse("00a16b6c-9396-4389-95fd-205f72fe5164")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("54f2de38-ce45-4168-80e7-74b1574f6401"),
                 CategoryId = Guid.Parse("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"),
                 FoodId = Guid.Parse("80c5e605-307f-4fef-bdf8-9967a800eab9")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("008dbfb1-2fa6-4bb6-8313-0d15afb5a217"),
                 CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                 FoodId = Guid.Parse("d65bff7e-4a2d-498b-97b2-676d4dd92a90")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("232587aa-9171-4816-80de-3f2ca21e7809"),
                 CategoryId = Guid.Parse("cd017b8a-fbed-4399-99ed-b59eec9b9551"),
                 FoodId = Guid.Parse("ced123e2-0b86-444b-ac83-7dba6860e354")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("c4e7cbb0-fe65-4fee-bcce-bc43ef5aab15"),
                 CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                 FoodId = Guid.Parse("d4f8f2c7-5318-4f07-803d-2b093be4d6c7")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("cc1a2489-196e-4f98-b68e-785f9842b4e5"),
                 CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                 FoodId = Guid.Parse("d4f8f2c7-5318-4f07-803d-2b093be4d6c7")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("7b42248c-c0c4-46b7-aa60-2bf7f7dcc2c7"),
                 CategoryId = Guid.Parse("78651ea5-2013-4e50-a55f-714de91a712d"),
                 FoodId = Guid.Parse("d4f8f2c7-5318-4f07-803d-2b093be4d6c7")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("38e471a8-d7f3-4885-9873-8ace803a6e26"),
                 CategoryId = Guid.Parse("78651ea5-2013-4e50-a55f-714de91a712d"),
                 FoodId = Guid.Parse("e34e9f9b-2d65-4e94-bcf0-37f5903c38b9")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("da9f39bb-9e03-447a-8874-220b14b2bea7"),
                 CategoryId = Guid.Parse("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"),
                 FoodId = Guid.Parse("e34e9f9b-2d65-4e94-bcf0-37f5903c38b9")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("4584e6b9-8c30-490f-af08-52f093f1d294"),
                 CategoryId = Guid.Parse("78651ea5-2013-4e50-a55f-714de91a712d"),
                 FoodId = Guid.Parse("e1b0767d-4b3b-42ea-820f-2154f7883ab9")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("2f71d694-34fa-4e27-9a45-c85636ae80c4"),
                 CategoryId = Guid.Parse("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"),
                 FoodId = Guid.Parse("e1b0767d-4b3b-42ea-820f-2154f7883ab9")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("f6e1ebb2-9c7a-424a-803c-2b7cb7747fce"),
                 CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                 FoodId = Guid.Parse("62cd0ff3-f69e-4a5f-bc8d-94f1f94e4552")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("cab91050-7489-4967-93c7-62bd2cd64a9f"),
                 CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                 FoodId = Guid.Parse("62cd0ff3-f69e-4a5f-bc8d-94f1f94e4552")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("4f80dc13-5a25-48ae-8563-5c3e998aaf63"),
                 CategoryId = Guid.Parse("78651ea5-2013-4e50-a55f-714de91a712d"),
                 FoodId = Guid.Parse("dd918def-34c2-4f5c-b402-6d51d8a1c604")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("b88c6718-9bbd-4efa-8cac-6aafdc1e27f8"),
                 CategoryId = Guid.Parse("bd21fd3f-8b19-4756-9da8-8ea32fc646d6"),
                 FoodId = Guid.Parse("dd918def-34c2-4f5c-b402-6d51d8a1c604")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("46f54659-1d67-4107-96a5-124a5302d873"),
                 CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                 FoodId = Guid.Parse("b2fe4b42-56e1-4630-99e1-bb74d6d5ab2f")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("a4927114-6501-4c79-a466-42ae40364b9d"),
                 CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                 FoodId = Guid.Parse("b2fe4b42-56e1-4630-99e1-bb74d6d5ab2f")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("ff7d6a78-5d2d-4475-910a-154e395c5426"),
                 CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                 FoodId = Guid.Parse("b2fe4b42-56e1-4630-99e1-bb74d6d5ab2f")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("e7265736-1531-47b1-a665-bcecdac73bd2"),
                 CategoryId = Guid.Parse("22ee062d-4904-4c64-a783-74b3e142aac7"),
                 FoodId = Guid.Parse("c4f9e44d-b7f6-4530-8b2e-b64c8f993f2a")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("71cd5ed0-003e-4185-8001-ab4bfba3cd21"),
                 CategoryId = Guid.Parse("f63dd434-9796-46ab-95ad-759bfac51e26"),
                 FoodId = Guid.Parse("97a2fdd1-ff1f-4f5b-85cf-9f68b0cf2b91")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("4528e935-231a-4069-b5ee-f07c99b14170"),
                 CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                 FoodId = Guid.Parse("97a2fdd1-ff1f-4f5b-85cf-9f68b0cf2b91")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("bdcd6f3c-4844-418b-9ed9-95a58fe9c518"),
                 CategoryId = Guid.Parse("78651ea5-2013-4e50-a55f-714de91a712d"),
                 FoodId = Guid.Parse("97a2fdd1-ff1f-4f5b-85cf-9f68b0cf2b91")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("8dbd85a6-ab87-43db-a763-81ee66f10dd0"),
                 CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                 FoodId = Guid.Parse("3b372064-e2a9-4729-b725-635e54e11c5d")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("2824c391-f2a7-4b96-b54d-72d49d224c6c"),
                 CategoryId = Guid.Parse("4c35b262-4c08-4624-900b-e22ba8988c92"),
                 FoodId = Guid.Parse("3b372064-e2a9-4729-b725-635e54e11c5d")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("448b576b-aeb6-43ea-9040-09d47c5eaa42"),
                 CategoryId = Guid.Parse("99052f16-54f5-4456-80f8-1691db7c90f2"),
                 FoodId = Guid.Parse("a3c8f7f1-dfe7-4e1e-9e9d-36a3c6b395b7")
            },new FoodCategory{
                 FoodCategoryId = Guid.Parse("e0ff9c14-ff0e-46ce-b1e2-b4eec545f188"),
                 CategoryId = Guid.Parse("fc7f66aa-8c09-46db-a679-be440e3ed91f"),
                 FoodId = Guid.Parse("a3c8f7f1-dfe7-4e1e-9e9d-36a3c6b395b7")
            }
           );
        }
    }
}