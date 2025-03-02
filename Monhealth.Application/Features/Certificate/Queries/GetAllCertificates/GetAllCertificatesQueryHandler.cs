using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Certificate.Queries.GetAllCertificates
{
    public class GetAllCertificatesQueryHandler : IRequestHandler<GetAllCertificatesQuery, List<GetAllCertificatesDTO>>
    {
        private readonly ICertificateRepository _certificateRepository;
        private readonly IMapper _mapper;
        public GetAllCertificatesQueryHandler(ICertificateRepository certificateRepository, IMapper mapper)
        {
            _certificateRepository = certificateRepository;
            _mapper = mapper;
        }
        public async Task<List<GetAllCertificatesDTO>> Handle(GetAllCertificatesQuery request, CancellationToken cancellationToken)
        {
            var listCertificates = await _certificateRepository.GetAllAsync();
            return _mapper.Map<List<GetAllCertificatesDTO>>(listCertificates);
        }
    }
}
