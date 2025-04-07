using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.UserDevice.Queries.GetUserDeviceByUserId
{
    public class GetUserDeviceByUserIdQueryHandler(IUserDeviceRepository userDeviceRepository, IMapper mapper) : IRequestHandler<GetUserDeviceByUserIdQuery, List<GetUserDeviceByUserIdDTO>>
    {
        public async Task<List<GetUserDeviceByUserIdDTO>> Handle(GetUserDeviceByUserIdQuery request, CancellationToken cancellationToken)
        {
            var userDevicesList = await userDeviceRepository.GetUserDevicesByUserId(request.UserId);
            return mapper.Map<List<GetUserDeviceByUserIdDTO>>(userDevicesList);
        }
    }
}
