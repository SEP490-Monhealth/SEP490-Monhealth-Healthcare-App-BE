using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Food.Queries.GetAllFoods
{
    public class GetFoodListQuery : IRequest<List<FoodDTO>>
    {
        
    }
}