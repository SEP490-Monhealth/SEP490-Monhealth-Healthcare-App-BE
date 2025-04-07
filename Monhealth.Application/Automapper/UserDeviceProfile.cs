using AutoMapper;
using Monhealth.Application.Features.UserDevice.Commands.CreateUserDevice;
using Monhealth.Application.Features.UserDevice.Commands.UpdateUserDevice;
using Monhealth.Application.Features.UserDevice.Queries.GetAllUserDevices;
using Monhealth.Application.Features.UserDevice.Queries.GetUserDeviceById;
using Monhealth.Application.Features.UserDevice.Queries.GetUserDeviceByUserId;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class UserDeviceProfile : Profile
    {
        public UserDeviceProfile()
        {
            CreateMap<Device, GetAllUserDevicesDTO>().ReverseMap();
            CreateMap<Device, GetUserDeviceByIdDTO>().ReverseMap();
            CreateMap<Device, GetUserDeviceByUserIdDTO>().ReverseMap();

            CreateMap<Device, CreateUserDeviceDTO>().ReverseMap();
            CreateMap<Device, UpdateUserDeviceDTO>().ReverseMap();
        }
    }
}
