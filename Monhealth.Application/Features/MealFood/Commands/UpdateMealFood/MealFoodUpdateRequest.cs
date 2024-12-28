using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.MealFood.Commands.UpdateMealFood
{
    public class MealFoodUpdateRequest : IRequest<bool>
    {
        public int Quantity { get; set; }
    }
}