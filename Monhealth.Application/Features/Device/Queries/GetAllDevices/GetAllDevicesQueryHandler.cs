using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.UserDevice.Queries.GetAllUserDevices
{
    public class GetAllDevicesQueryHandler(IDeviceRepository deviceRepository, IMapper mapper) : IRequestHandler<GetAllDevicesQuery, PageResult<GetAllDevicesDTO>>
    {
        public async Task<PageResult<GetAllDevicesDTO>> Handle(GetAllDevicesQuery request, CancellationToken cancellationToken)
        {
            var userDevicesList = await deviceRepository.GetAllDevices(request.Page, request.Limit);
            var userDevicesListDto = mapper.Map<List<GetAllDevicesDTO>>(userDevicesList.Items);
            return new PageResult<GetAllDevicesDTO>()
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(userDevicesList.TotalCount / (double)request.Limit),
                TotalItems = userDevicesList.TotalCount,
                Items = userDevicesListDto
            };
        }
    }
}
