using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Portions.Commands.UpdateFoodPortion
{
    public class UpdatePortionCommand : IRequest<bool>
    {
        public Guid PortionId { get; set; }
        public string? PortionSize { get; set; }
        public string PortionWeight { get; set; }
        public string MeasurementUnit { get; set; }
        public UpdatePortionCommand(string portionSize, string portionWeight, string measurementUnit)
        {
            PortionSize = portionSize;
            PortionWeight = portionWeight;
            MeasurementUnit = measurementUnit;
        }
    }
}
