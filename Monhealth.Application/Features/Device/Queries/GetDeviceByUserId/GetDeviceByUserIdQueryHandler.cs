using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.UserDevice.Queries.GetUserDeviceByUserId
{
    public class GetDeviceByUserIdQueryHandler(IDeviceRepository deviceRepository, IMapper mapper) : IRequestHandler<GetDeviceByUserIdQuery, List<GetDeviceByUserIdDTO>>
    {
        public async Task<List<GetDeviceByUserIdDTO>> Handle(GetDeviceByUserIdQuery request, CancellationToken cancellationToken)
        {
            var userDevicesList = await deviceRepository.GetDevicesByUserId(request.UserId);
            return mapper.Map<List<GetDeviceByUserIdDTO>>(userDevicesList);
        }
    }
}
