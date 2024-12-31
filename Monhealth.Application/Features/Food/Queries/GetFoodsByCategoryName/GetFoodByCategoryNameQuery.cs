using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Food.Queries.GetFoodsByCategoryName
{
    public class GetFoodByCategoryNameQuery : IRequest<List<GetFoodByCategoryNameDTO>>
    {
        public string[] categoryNames { get; set; }
       


    }
}