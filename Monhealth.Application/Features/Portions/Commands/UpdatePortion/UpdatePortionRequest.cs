using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Portions.Commands.UpdatePortion
{
    public class UpdatePortionRequest
    {
        public string? PortionSize { get; set; }
        public float PortionWeight { get; set; }
        public string MeasurementUnit { get; set; }
    }
}
