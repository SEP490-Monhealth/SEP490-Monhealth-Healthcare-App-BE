using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Consultant.Queries.GetAllConsultants
{
    public class GetAllConsultantsQueryHandler : IRequestHandler<GetAllConsultantsQuery, PageResult<GetAllConsultantsDTO>>
    {
        private readonly IConsultantRepository _consultantRepository;
        private readonly IMapper _mapper;
        public GetAllConsultantsQueryHandler(IConsultantRepository consultantRepository, IMapper mapper)
        {
            _consultantRepository = consultantRepository;
            _mapper = mapper;
        }
        public async Task<PageResult<GetAllConsultantsDTO>> Handle(GetAllConsultantsQuery request, CancellationToken cancellationToken)
        {
            var listConsultants = await _consultantRepository
                .GetAllConsultants(request.Page, request.Limit, request.Expertise, request.Search, request.Popular, request.Status, request.Verified);
            var listConsultantsDto = _mapper.Map<List<GetAllConsultantsDTO>>(listConsultants.Items);
            return new PageResult<GetAllConsultantsDTO>()
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(listConsultants.TotalCount / (double)request.Limit),
                TotalItems = listConsultants.TotalCount,
                Items = listConsultantsDto
            };
        }
    }
}
