using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Portions.Queries.GetPortionsByFoodId
{
    public class GetPortionsByFoodIdDto
    {
        public Guid PortionId { get; set; }
        public string PortionSize { get; set; } = string.Empty;
        public float PortionWeight { get; set; }
        public string MeasurementUnit { get; set; } = string.Empty;
    }
}
