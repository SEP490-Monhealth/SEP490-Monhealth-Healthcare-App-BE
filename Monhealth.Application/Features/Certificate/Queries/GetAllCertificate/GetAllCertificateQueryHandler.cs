using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application.Features.Certificate.Queries.GetAllCertificate
{
    public class GetAllCertificateQueryHandler(ICertificateRepository certificateRepository, IMapper mapper) : IRequestHandler<GetAllCertificateQuery, PageResult<CertificateDto>>
    {
        public async Task<PageResult<CertificateDto>> Handle(GetAllCertificateQuery request, CancellationToken cancellationToken)
        {
            var pagingCertificates = await certificateRepository.GetAllCertificateAsync(request.Page, request.Limit, request.Search, request.Status);
            return new PageResult<CertificateDto>()
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(pagingCertificates.TotalCount / (double)request.Limit),
                TotalItems = pagingCertificates.TotalCount,
                Items = mapper.Map<List<CertificateDto>>(pagingCertificates.Items)
            };
        }
    }
}
