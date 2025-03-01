using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Activity.Commands.CreateActivity
{
    public class CreateActivityCommand : IRequest<Unit>
    {
        public CreateActivityDTO CreateActivityDTO { get; set; }
        public CreateActivityCommand(CreateActivityDTO createActivityDTO)
        {
            CreateActivityDTO = createActivityDTO;
        }
    }
}
