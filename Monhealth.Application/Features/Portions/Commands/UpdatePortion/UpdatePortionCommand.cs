using MediatR;
using Monhealth.Application.Features.Portions.Commands.UpdatePortion;

namespace Monhealth.Application.Features.Portions.Commands.UpdateFoodPortion
{
    public class UpdatePortionCommand : IRequest<bool>
    {
        public Guid PortionId { get; set; }
        public string? PortionSize { get; set; }
        public float PortionWeight { get; set; }
        public string MeasurementUnit { get; set; }
        public UpdatePortionCommand(Guid portionId, UpdatePortionRequest update)
        {
            PortionId = portionId;
            PortionSize = update.PortionSize;
            PortionWeight = update.PortionWeight;
            MeasurementUnit = update.MeasurementUnit;
        }
    }
}
