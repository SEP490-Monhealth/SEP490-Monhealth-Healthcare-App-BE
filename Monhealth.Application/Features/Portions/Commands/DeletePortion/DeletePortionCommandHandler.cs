using MediatR;
using Monhealth.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Portions.Commands.DeletePortion
{
    public class DeletePortionCommandHandler : IRequestHandler<DeletePortionCommand, bool>
    {
        private readonly IPortionRepository _portionRepository;
        public DeletePortionCommandHandler(IPortionRepository portionRepository)
        {
            _portionRepository = portionRepository;
        }
        public async Task<bool> Handle(DeletePortionCommand request, CancellationToken cancellationToken)
        {
            var portionToDelete = await _portionRepository.GetByIdAsync(request.PortionId);
            if (portionToDelete == null)
            {
                return false;
            }
            _portionRepository.Remove(portionToDelete);
            await _portionRepository.SaveChangesAsync();
            return true;
        }
    }
}
