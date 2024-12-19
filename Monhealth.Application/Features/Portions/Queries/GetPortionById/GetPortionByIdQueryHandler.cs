using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Portions.Queries.GetPortionById
{
    public class GetPortionByIdQueryHandler : IRequestHandler<GetPortionByIdQuery, GetPortionByIdDto>
    {
        private readonly IPortionRepository _portionRepository;
        private readonly IMapper _mapper;
        public GetPortionByIdQueryHandler(IPortionRepository portionRepository, IMapper mapper)
        {
            _mapper = mapper;
            _portionRepository = portionRepository;
        }
        public async Task<GetPortionByIdDto> Handle(GetPortionByIdQuery request, CancellationToken cancellationToken)
        {
            var portion = await _portionRepository.GetByIdAsync(request.PortionId);
            if (portion == null)
            {
                throw new Exception("Không tìm thấy khẩu phần ăn.");
            }
            return _mapper.Map<GetPortionByIdDto>(portion);
        }
    }
}
