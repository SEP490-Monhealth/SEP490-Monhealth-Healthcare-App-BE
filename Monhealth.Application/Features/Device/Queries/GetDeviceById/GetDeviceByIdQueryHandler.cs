using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.UserDevice.Queries.GetUserDeviceById
{
    public class GetDeviceByIdQueryHandler(IDeviceRepository deviceRepository, IMapper mapper) : IRequestHandler<GetDeviceByIdQuery, GetDeviceByIdDTO>
    {
        public async Task<GetDeviceByIdDTO> Handle(GetDeviceByIdQuery request, CancellationToken cancellationToken)
        {
            var userDevice = await deviceRepository.GetByIdAsync(request.DeviceId);
            return mapper.Map<GetDeviceByIdDTO>(userDevice);
        }
    }
}
