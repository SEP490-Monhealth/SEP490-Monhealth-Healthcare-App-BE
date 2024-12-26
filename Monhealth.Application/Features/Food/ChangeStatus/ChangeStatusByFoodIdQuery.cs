using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Food.ChangeStatus
{
    public class ChangeStatusByFoodIdQuery : IRequest<bool>
    {
        public Guid FoodId { get; set; }
    }
}