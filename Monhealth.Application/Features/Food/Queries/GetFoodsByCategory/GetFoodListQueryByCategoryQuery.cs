using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Food.Queries.GetFoodsByCategory
{
    public class GetFoodListQueryByCategoryQuery : IRequest<List<GetFoodByCategoryDTO>>
    {
        public string CategoryName { get; set; }
    }
}