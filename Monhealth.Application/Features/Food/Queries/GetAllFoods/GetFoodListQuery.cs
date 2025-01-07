using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Food.Queries.GetAllFoods
{
    public class GetFoodListQuery : IRequest<PageResult<FoodDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public string Search { get; set; }
        public string CategoryName { get; set; }
        public string FoodType { get; set; }
        public bool? Popular {get; set;}
        public bool? Status { get; set; }
        public GetFoodListQuery(int page, int limit, string? search, string? categoryName, string foodType,bool? popular, bool? status ) 
        {
            Page = page;
            Limit = limit;
            Search = search;
            Status = status;
            CategoryName = categoryName;
            FoodType = foodType;
            Popular = popular;
        }
    }
}