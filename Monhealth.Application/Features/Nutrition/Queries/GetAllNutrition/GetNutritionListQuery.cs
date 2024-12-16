using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Nutrition.Queries.GetAllNutrition
{
    public class GetNutritionListQuery : IRequest<List<NutritionDto>>
    {
        
    }
}