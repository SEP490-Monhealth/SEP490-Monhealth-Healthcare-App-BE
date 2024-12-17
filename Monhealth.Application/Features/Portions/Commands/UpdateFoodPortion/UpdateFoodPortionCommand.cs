using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Portions.Commands.UpdateFoodPortion
{
    public class UpdateFoodPortionCommand : IRequest<Unit>
    {
        public Guid FoodPortionId { get; set; }
        public string PortionSize { get; set; } = string.Empty;
        public string PortionWeight { get; set; } = string.Empty;
        public string MeasurementUnit { get; set; } = string.Empty;
        public Guid FoodId { get; set; }
    }
}
