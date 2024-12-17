using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Portions.Commands.UpdateFoodPortion
{
    public class UpdateFoodPortionCommandHandler : IRequestHandler<UpdateFoodPortionCommand, Unit>
    {
        public Task<Unit> Handle(UpdateFoodPortionCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
