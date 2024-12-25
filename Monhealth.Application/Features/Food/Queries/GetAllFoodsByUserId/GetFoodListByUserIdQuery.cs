using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Food.Queries.GetAllFoodsByUserId
{
    public class GetFoodListByUserIdQuery : IRequest<List<FoodsByUserIdDTO>>
    {
        public Guid UserId { get; set; }
    }
}