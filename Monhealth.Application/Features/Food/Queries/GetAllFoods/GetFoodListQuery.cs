using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Food.Queries.GetAllFoods
{
    public class GetFoodListQuery : IRequest<PageResult<FoodDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public string CategoryName { get; set; }
        public string Search { get; set; }
        public bool? IsPublic { get; set; }
        public bool? Popular { get; set; }
        public bool? Status { get; set; }
        public GetFoodListQuery(int page, int limit, string? categoryName, string? search, bool? isPublic, bool? popular, bool? status)
        {
            Page = page;
            Limit = limit;
            CategoryName = categoryName;
            Search = search;
            IsPublic = isPublic;
            Popular = popular;
            Status = status;
        }
    }
}