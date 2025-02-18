using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Expertise.Commands.DeleteExpertise
{
    public class DeleteExpertiseCommand : IRequest<bool>
    {
        public Guid ExpertiseId { get; set; }
    }
}
