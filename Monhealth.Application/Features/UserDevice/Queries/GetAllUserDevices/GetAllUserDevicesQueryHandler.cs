using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.UserDevice.Queries.GetAllUserDevices
{
    public class GetAllUserDevicesQueryHandler(IUserDeviceRepository userDeviceRepository, IMapper mapper) : IRequestHandler<GetAllUserDevicesQuery, PageResult<GetAllUserDevicesDTO>>
    {
        public async Task<PageResult<GetAllUserDevicesDTO>> Handle(GetAllUserDevicesQuery request, CancellationToken cancellationToken)
        {
            var userDevicesList = await userDeviceRepository.GetAllUserDevices(request.Page, request.Limit);
            var userDevicesListDto = mapper.Map<List<GetAllUserDevicesDTO>>(userDevicesList.Items);
            return new PageResult<GetAllUserDevicesDTO>()
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(userDevicesList.TotalCount / (double)request.Limit),
                TotalItems = userDevicesList.TotalCount,
                Items = userDevicesListDto
            };
        }
    }
}
