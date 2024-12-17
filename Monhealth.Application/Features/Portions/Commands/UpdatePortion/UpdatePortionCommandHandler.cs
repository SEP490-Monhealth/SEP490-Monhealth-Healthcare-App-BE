using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var portionToUpdate = await _portionRepository.GetByIdAsync(request.PortionId);
            if (portionToUpdate == null)
            {
                return false;
            }
            portionToUpdate.PortionSize = request.PortionSize;
            portionToUpdate.PortionWeight = request.PortionWeight;
            portionToUpdate.MeasurementUnit = request.MeasurementUnit;
            portionToUpdate.UpdatedAt = DateTime.Now;

            _portionRepository.Update(portionToUpdate);
            await _portionRepository.SaveChangesAsync();
            return true;
        }
    }
}
