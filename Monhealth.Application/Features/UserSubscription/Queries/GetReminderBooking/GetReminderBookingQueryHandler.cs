using MediatR;
using Monhealth.Application.Contracts.Persistence;
namespace Monhealth.Application
{
    public class GetReminderBookingQueryHandler(IUserSubscriptionRepository userSubscriptionRepository) : IRequestHandler<GetReminderBookingQuery, GetReminderBookingDTO>
    {
        public async Task<GetReminderBookingDTO> Handle(GetReminderBookingQuery request, CancellationToken cancellationToken)
        {
            var user = await userSubscriptionRepository.GetByUserIdAsync(request.UserId);
            if (user == null)
            {
                throw new Exception("Không tìm thấy người dùng");
            }
            return new GetReminderBookingDTO
            {
                RemainingBookings = user.RemainingBookings
            };
        }
    }
}