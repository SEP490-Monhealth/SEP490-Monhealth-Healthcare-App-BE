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
        public string PortionSize { get; set; } = string.Empty;
        public string PortionWeight { get; set; } = string.Empty;
        public string MeasurementUnit { get; set; } = string.Empty;
        public List<Guid> FoodIds { get; set; }
        //public DateTime? CreatedAt { get; set; }
        //public DateTime? UpdatedAt { get; set; }
        //public Guid? CreatedBy { get; set; }
        //public Guid? UpdatedBy { get; set; }
    }
}
