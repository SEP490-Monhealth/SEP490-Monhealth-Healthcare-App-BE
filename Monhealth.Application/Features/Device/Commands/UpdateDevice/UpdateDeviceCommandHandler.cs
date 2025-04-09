using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.UserDevice.Commands.UpdateUserDevice
{
    public class UpdateDeviceCommandHandler(IDeviceRepository deviceRepository, IMapper mapper) : IRequestHandler<UpdateDeviceCommand, bool>
    {
        public async Task<bool> Handle(UpdateDeviceCommand request, CancellationToken cancellationToken)
        {
            var userDevice = await deviceRepository.GetByIdAsync(request.DeviceId);
            var userDeviceToUpdate = mapper.Map(request.UpdateDeviceDTO, userDevice);
            userDeviceToUpdate.UpdatedAt = DateTime.Now;
            deviceRepository.Update(userDeviceToUpdate);
            await deviceRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
