using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Portions.Commands.CreateFoodPortion
{
    public class CreatePortionCommand : IRequest<Unit>
    {
        public string? PortionSize { get; set; }
        public float PortionWeight { get; set; }
        public string MeasurementUnit { get; set; }
        public Guid FoodId { get; set; }
    }
}
