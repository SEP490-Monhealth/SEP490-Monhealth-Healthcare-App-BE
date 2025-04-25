using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Portions.Commands.UpdateFoodPortion
{
    public class UpdatePortionCommandHandler : IRequestHandler<UpdatePortionCommand, bool>
    {
        private readonly IMapper _mapper;
        private readonly IPortionRepository _portionRepository;
        public UpdatePortionCommandHandler(IMapper mapper, IPortionRepository portionRepository)
        {
            _portionRepository = portionRepository;
            _mapper = mapper;
        }
        public async Task<bool> Handle(UpdatePortionCommand request, CancellationToken cancellationToken)
        {
            // Kiem tra Portion 
            var existingPortion = await _portionRepository.CheckPortion(request.PortionSize, request.PortionWeight, request.MeasurementUnit);

            if (existingPortion != null && existingPortion.PortionId != request.PortionId)
            {
                // Neu da ton tai thi khong cap nhat
                return false;
            }
            var portionToUpdate = await _portionRepository.GetByIdAsync(request.PortionId);
            if (portionToUpdate == null)
            {
                return false;
            }
            portionToUpdate.PortionSize = request.PortionSize;
            portionToUpdate.PortionWeight = request.PortionWeight;
            portionToUpdate.MeasurementUnit = request.MeasurementUnit;
            portionToUpdate.UpdatedAt = DateTime.UtcNow;

            _portionRepository.Update(portionToUpdate);
            await _portionRepository.SaveChangesAsync();
            return true;
        }
    }
}
