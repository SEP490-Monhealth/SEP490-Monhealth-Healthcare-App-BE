using MediatR;

namespace Monhealth.Application.Features.Food.Queries.GetFoodsByCategoryName
{
    public class GetFoodByCategoryNameQuery : IRequest<List<GetFoodByCategoryNameDTO>>
    {
        public string[] categoryNames { get; set; }



    }
}