using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Consultant.Commands.UpdateConsultant
{
    public class UpdateConsultantCommandHandler : IRequestHandler<UpdateConsultantCommand, bool>
    {
        private readonly IConsultantRepository _consultantRepository;
        private readonly IExpertiseRepository _expertiseRepository;
        private readonly IMapper _mapper;
        public UpdateConsultantCommandHandler(IConsultantRepository consultantRepository, IExpertiseRepository expertiseRepository, IMapper mapper)
        {
            _consultantRepository = consultantRepository;
            _expertiseRepository = expertiseRepository;
            _mapper = mapper;
        }
        public Task<bool> Handle(UpdateConsultantCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
