using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.UserDevice.Queries.GetUserDeviceById
{
    public class GetUserDeviceByIdQueryHandler(IUserDeviceRepository userDeviceRepository, IMapper mapper) : IRequestHandler<GetUserDeviceByIdQuery, GetUserDeviceByIdDTO>
    {
        public async Task<GetUserDeviceByIdDTO> Handle(GetUserDeviceByIdQuery request, CancellationToken cancellationToken)
        {
            var userDevice = await userDeviceRepository.GetByIdAsync(request.UserDeviceId);
            return mapper.Map<GetUserDeviceByIdDTO>(userDevice);
        }
    }
}
