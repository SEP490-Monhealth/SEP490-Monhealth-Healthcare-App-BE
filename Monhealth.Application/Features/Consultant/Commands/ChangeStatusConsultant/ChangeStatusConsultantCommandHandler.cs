﻿using MediatR;
using Microsoft.AspNetCore.Identity;
using Monhealth.Application.Contracts.Notification;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Consultant.Commands.ChangeStatusConsultant
{
    public class ChangeStatusConsultantCommandHandler : IRequestHandler<ChangeStatusConsultantCommand, bool>
    {
        private readonly IConsultantRepository _consultantRepository;
        private readonly IWalletRepository _walletRepository;
        private readonly IUserRepository _userRepository;
        private readonly ISystemNotificationService systemNotificationService;
        private readonly IUserRoleRepository _userRoleRepository;
        public ChangeStatusConsultantCommandHandler(IConsultantRepository consultantRepository, IWalletRepository walletRepository,
        IUserRoleRepository userRoleRepository, IUserRepository userRepository,
        ISystemNotificationService systemNotificationService
        )
        {
            _consultantRepository = consultantRepository;
            _walletRepository = walletRepository;
            _userRepository = userRepository;
            this.systemNotificationService = systemNotificationService;
            _userRoleRepository = userRoleRepository;

        }
        public async Task<bool> Handle(ChangeStatusConsultantCommand request, CancellationToken cancellationToken)
        {
            var consultant = await _consultantRepository.GetByIdAsync(request.ConsultantId);
            if (consultant == null)
            {
                throw new Exception("Không tìm thấy tư vấn viên");
            }
            var memberRole = await _userRoleRepository.GetRoleMember("Member");

            // xoa role
            var userRole = await _userRoleRepository.GetUserRoleByUserIdAsync((Guid)consultant.UserId);
            if (userRole != null)
            {
                // Nếu người dùng đã có role, xóa bản ghi cũ trước khi thêm role mới
                _userRoleRepository.Remove(userRole);
            }
            // Tạo bản ghi mới cho UserRole với RoleId mới
            var newUserRole = new IdentityUserRole<Guid>
            {
                UserId = (Guid)consultant.UserId,
                RoleId = memberRole.Id
            };
            _userRoleRepository.Add(newUserRole);

            consultant.Status = !consultant.Status;
            _consultantRepository.Update(consultant);


            var wallet = await _walletRepository.GetWalletByConsultantId(request.ConsultantId);
            if (wallet == null)
            {
                throw new Exception("Không tìm thấy ví");
            }
            wallet.Status = !wallet.Status;
            _walletRepository.Update(wallet);

            await _consultantRepository.SaveChangeAsync();

            //send notification 
            await systemNotificationService.NotifyConsultantStatusUpdateAsync(consultant, cancellationToken);

            return true;
        }
    }
}
