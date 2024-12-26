using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Food.Queries.GetAllFoodsByUserId
{
    public class GetFoodListByUserIdQuery : IRequest<PageResult<FoodsByUserIdDTO>>
    {
        public Guid UserId { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
        public GetFoodListByUserIdQuery(Guid userId, int page, int limit)
        {
            UserId = userId;
            Page = page;
            Limit = limit;
        }
    }
}