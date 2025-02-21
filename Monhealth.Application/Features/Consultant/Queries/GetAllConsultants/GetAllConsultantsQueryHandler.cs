using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Consultant.Queries.GetAllConsultants
{
    public class GetAllConsultantsQueryHandler : IRequestHandler<GetAllConsultantsQuery, List<GetAllConsultantsDTO>>
    {
        private readonly IConsultantRepository _consultantRepository;
        private readonly IMapper _mapper;
        public GetAllConsultantsQueryHandler(IConsultantRepository consultantRepository, IMapper mapper)
        {
            _consultantRepository = consultantRepository;
            _mapper = mapper;
        }
        public async Task<List<GetAllConsultantsDTO>> Handle(GetAllConsultantsQuery request, CancellationToken cancellationToken)
        {
            var listConsultant = await _consultantRepository.GetAllAsync();
            return _mapper.Map<List<GetAllConsultantsDTO>>(listConsultant);
        }
    }
}
