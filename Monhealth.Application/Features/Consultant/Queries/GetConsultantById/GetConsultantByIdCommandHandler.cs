using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Consultant.Queries.GetConsultantById
{
    public class GetConsultantByIdCommandHandler : IRequestHandler<GetConsultantByIdCommand, GetConsultantByIdDTO>
    {
        private readonly IConsultantRepository _consultantRepository;
        public GetConsultantByIdCommandHandler(IConsultantRepository consultantRepository)
        {
            _consultantRepository = consultantRepository;
        }
        public Task<GetConsultantByIdDTO> Handle(GetConsultantByIdCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
