using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Allergy.Queries.GetAll
{
    public class GetAllergyQueryHandler : IRequestHandler<GetAllergyQuery, PageResult<AllergyDTO>>
    {
        private readonly IAllergyRepository _allergyRepository;
        private readonly IMapper _mapper;
        public GetAllergyQueryHandler(IAllergyRepository allergyRepository,
        IMapper mapper)
        {
            _allergyRepository = allergyRepository;
            _mapper = mapper;
        }

        public async Task<PageResult<AllergyDTO>> Handle(GetAllergyQuery request, CancellationToken cancellationToken)
        {
            var pagingAllergries = await _allergyRepository.GetAllAlleriesAsync(request.Page, request.Limit, request.Search);
            return new PageResult<AllergyDTO>
            {
                Items = _mapper.Map<List<AllergyDTO>>(pagingAllergries.Items),
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(pagingAllergries.TotalCount / (double)request.Limit),
                TotalItems = pagingAllergries.TotalCount,
            };
        }
    }
}