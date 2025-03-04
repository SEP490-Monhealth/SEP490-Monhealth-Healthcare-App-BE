using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Consultant.Commands.ChangeVeryfiedConsultant
{
    public class ChangeVeryfiedConsultantCommandHandler : IRequestHandler<ChangeVeryfiedConsultantCommand, bool>
    {
        private readonly IConsultantRepository _consultantRepository;
        public ChangeVeryfiedConsultantCommandHandler(IConsultantRepository consultantRepository)
        {
            _consultantRepository = consultantRepository;
        }
        public async Task<bool> Handle(ChangeVeryfiedConsultantCommand request, CancellationToken cancellationToken)
        {
            var consultant = await _consultantRepository.GetByIdAsync(request.ConsultantId);
            if (consultant == null)
            {
                return false;
            }
            if(consultant.IsVerified == false)
            {
                consultant.IsVerified = true;
            } else
            {
                consultant.IsVerified = false;
            }
            _consultantRepository.Update(consultant);
            await _consultantRepository.SaveChangeAsync();
            return true;
        }
    }
}
