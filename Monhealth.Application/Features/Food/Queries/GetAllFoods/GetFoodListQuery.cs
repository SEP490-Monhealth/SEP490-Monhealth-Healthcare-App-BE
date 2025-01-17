using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Food.Queries.GetAllFoods
{
    public class GetFoodListQuery : IRequest<PageResult<FoodDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public string CategoryName { get; set; }
        public string FoodType { get; set; }
        public string Search { get; set; }
        public bool? Popular { get; set; }
        public bool? Status { get; set; }
        public GetFoodListQuery(int page, int limit, string? categoryName, string foodType, string? search, bool? popular, bool? status)
        {
            Page = page;
            Limit = limit;
            CategoryName = categoryName;
            FoodType = foodType;
            Search = search;
            Status = status;
            Popular = popular;
        }
    }
}