using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Nutrition.Queries.GetNutritionDetail
{
    public class GetNutritionDetailQuery : IRequest<NutritionDetailDto>
    {
        public Guid NutritionId { get; set; }
    }
}