using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Food.Queries.GetFoodById
{
    public class GetFoodByIdQuery : IRequest<GetFoodByIdDTO>
    {
        public Guid FoodId { get; set; }

    }
}