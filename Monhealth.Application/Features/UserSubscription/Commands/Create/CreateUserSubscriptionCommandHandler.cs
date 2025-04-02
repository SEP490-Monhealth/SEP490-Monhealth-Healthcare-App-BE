using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Core.Enum;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Models;

namespace Monhealth.Application.Features.UserSubscription.Commands.Create
{
    public class CreateUserSubscriptionCommandHandler : IRequestHandler<CreateUserSubscriptionCommand, Unit>
    {
        private readonly IUserSubscriptionRepository _userSubscriptionRepository;
        private readonly ISubscriptionRepository _subscriptionRepository;
      
        private readonly IUserRepository _userRepository;
        private readonly ILogger<CreateUserSubscriptionCommandHandler> _logger;
        private readonly IUserRoleRepository _userRoleRepository;
        public CreateUserSubscriptionCommandHandler(IUserSubscriptionRepository userSubscriptionRepository,
        ISubscriptionRepository subscriptionRepository,
        ILogger<CreateUserSubscriptionCommandHandler> logger,
        IUserRepository userRepository,
        IUserRoleRepository userRoleRepository)
        {
            _userSubscriptionRepository = userSubscriptionRepository;
            _subscriptionRepository = subscriptionRepository;
         
            _logger = logger;
            _userRepository = userRepository;
            _userRoleRepository = userRoleRepository;
        }

        public async Task<Unit> Handle(CreateUserSubscriptionCommand request, CancellationToken cancellationToken)
        {
            var user = request.UserId;
            var subscription = await _subscriptionRepository.GetByIdAsync(request.SubscriptionId);
            if (subscription is null)
            {
                _logger.LogError("Subscription not found.");
                throw new Exception("Subscription not found.");
            }
            var durationDays = subscription.DurationDays;
            var today = DateTime.Now;
            var model = new Domain.UserSubscription
            {
                SubscriptionId = request.SubscriptionId,
                UserId = user,
                StartedAt = today,
                Status = Core.Enum.UserSubscriptionStatus.Active,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                ExpiresAt = today.AddDays(durationDays),
                RemainingBookings = subscription.BookingAllowance
            };
            _userSubscriptionRepository.Add(model);
            // Lấy thông tin người dùng
            var subscriptionRole = await _userRoleRepository.GetRoleByNameAsync("Subscription Member");
            if (subscriptionRole == null)
            {
                _logger.LogError("Role 'Subscription Member' does not exist.");
                return Unit.Value;
            }
            var userRole = await _userRoleRepository.GetUserRoleByUserIdAsync(user);


            if (userRole != null)
            {
                // Nếu người dùng đã có role, xóa bản ghi cũ trước khi thêm role mới
                _userRoleRepository.Remove(userRole);
                await _userRepository.SaveChangesAsync();
                _logger.LogInformation($"Removed old role for UserId {user}");
            }

            // Tạo bản ghi mới cho UserRole với RoleId mới
            var newUserRole = new IdentityUserRole<Guid>
            {
                UserId = user,
                RoleId = subscriptionRole.Id
            };

            // Thêm vào bảng UserRoles
            _userRoleRepository.Add(newUserRole);
            await _userRepository.SaveChangesAsync();
            return Unit.Value;
        }

     
    }
}