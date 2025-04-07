using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.UserDevice.Commands.UpdateUserDevice
{
    public class UpdateUserDeviceCommandHandler(IUserDeviceRepository userDeviceRepository, IMapper mapper) : IRequestHandler<UpdateUserDeviceCommand, bool>
    {
        public async Task<bool> Handle(UpdateUserDeviceCommand request, CancellationToken cancellationToken)
        {
            var userDevice = await userDeviceRepository.GetByIdAsync(request.UserDeviceId);
            var userDeviceToUpdate = mapper.Map(request.UpdateUserDeviceDTO, userDevice);
            userDeviceToUpdate.UpdatedAt = DateTime.Now;
            userDeviceRepository.Update(userDeviceToUpdate);
            await userDeviceRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
