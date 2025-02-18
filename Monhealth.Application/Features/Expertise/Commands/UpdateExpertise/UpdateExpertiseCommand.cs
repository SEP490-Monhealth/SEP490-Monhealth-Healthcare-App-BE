using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Expertise.Commands.UpdateExpertise
{
    public class UpdateExpertiseCommand : IRequest<bool>
    {
        public Guid ExpertiseId { get; set; }
        public UpdateExpertiseDTO UpdateExpertiseDTO { get; set; }
        public UpdateExpertiseCommand(Guid expertiseId, UpdateExpertiseDTO updateExpertiseDTO)
        {
            ExpertiseId = expertiseId;
            UpdateExpertiseDTO = updateExpertiseDTO;
        }
    }
}
