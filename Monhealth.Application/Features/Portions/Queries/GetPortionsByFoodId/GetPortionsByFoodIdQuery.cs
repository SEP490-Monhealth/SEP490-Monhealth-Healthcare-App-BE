﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Portions.Queries.GetPortionsByFoodId
{
    public class GetPortionsByFoodIdQuery : IRequest<List<GetPortionsByFoodIdDto>>
    {
        public Guid FoodId { get; set; }
    }
}
