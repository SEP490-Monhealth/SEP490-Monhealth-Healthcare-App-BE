using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Identity.Models;

namespace Monhealth.Application.Features.Consultant.Commands.VeryfiedConsultant
{
    public class VeryfiedConsultantCommandHandler : IRequestHandler<VeryfiedConsultantCommand, bool>
    {
        private readonly IConsultantRepository _consultantRepository;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        public VeryfiedConsultantCommandHandler(IConsultantRepository consultantRepository, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _consultantRepository = consultantRepository;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<bool> Handle(VeryfiedConsultantCommand request, CancellationToken cancellationToken)
        {
            var consultant = await _consultantRepository.GetByIdAsync(request.ConsultantId);
            if (consultant == null)
            {
                return false;
            }
            var userToUpdateRoleConsultant = await _userManager.FindByIdAsync(consultant.UserId.ToString());
            if (userToUpdateRoleConsultant == null)
            {
                return false;
            }
            if(!consultant.IsVerified)
            {
                consultant.IsVerified = true;

                // xoa role
                var currentRole = await _userManager.GetRolesAsync(userToUpdateRoleConsultant);
                await _userManager.RemoveFromRolesAsync(userToUpdateRoleConsultant, currentRole);

                //them role moi
                await _userManager.AddToRoleAsync(userToUpdateRoleConsultant, "Consultant");
            }
            _consultantRepository.Update(consultant);
            await _consultantRepository.SaveChangeAsync();
            return true;
        }
    }
}
