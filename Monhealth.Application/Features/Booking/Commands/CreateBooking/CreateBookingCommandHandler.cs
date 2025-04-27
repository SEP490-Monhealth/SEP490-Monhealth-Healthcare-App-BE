using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Notification;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Application.Models.Meeting;
using System.Text.Json;

namespace Monhealth.Application.Features.Booking.Commands.CreateBooking
{
    public class CreateBookingCommandHandler(IMapper mapper, IBookingRepository bookingRepository
    , IConsultantRepository consultantRepository,
        IScheduleRepository scheduleRepository,
        IUserSubscriptionRepository userSubscriptionRepository,
        ISystemNotificationService systemNotificationService,
        IHttpClientFactory httpFactory,
        IUserRepository userRepository


        ) : IRequestHandler<CreateBookingCommand, Unit>
    {
        public async Task<Unit> Handle(CreateBookingCommand request, CancellationToken cancellationToken)
        {
            var booking = mapper.Map<Domain.Booking>(request);
            booking.CreatedAt = GetCurrentVietnamTime();
            booking.UpdatedAt = GetCurrentVietnamTime();
            bookingRepository.Add(booking);

            //plus amout booking for consultant
            var consultant = await consultantRepository.GetConsultantByConsultantId(booking.ConsultantId.Value)
                      ?? throw new BadRequestException("Không thấy chuyên viên tư vấn.");
            var member = await userRepository.GetUserByIdAsync(booking.UserId.Value)
                            ?? throw new BadRequestException("Không tìm thấy người dùng.");
            consultant.BookingCount++;
            consultant.UpdatedAt = DateTime.Now;

            //subtract amout remaining booking
            var sub = await userSubscriptionRepository.GetUserSubscriptionActiveOfUser(booking.UserId.Value)
              ?? throw new BadRequestException("Bạn đã hết số lượt có thể đặt lịch.");
            sub.RemainingBookings--;
            sub.UpdatedAt = DateTime.Now;

            // 2. Gọi n8n webhook để tạo Google Meet link
            var client = httpFactory.CreateClient("n8n");
            DateTime start = booking.Day.ToDateTime(booking.StartTime);
            DateTime end = booking.Day.ToDateTime(booking.EndTime);
            string qs = $"webhook/fadd4d24-2ff8-45fe-85ec-7a5bedb3b357"
                        + $"?startDate={Uri.EscapeDataString(start.ToString("o"))}"
                        + $"&endDate={Uri.EscapeDataString(end.ToString("o"))}"
                        + $"&summary={Uri.EscapeDataString("Monhealth Google Meet")}"
                        + $"&consultant={Uri.EscapeDataString(consultant?.AppUser?.Email ?? string.Empty)}"
                        + $"&member={Uri.EscapeDataString(member.Email ?? string.Empty)}";

            var resp = await client.GetAsync(qs, cancellationToken);
            //resp.EnsureSuccessStatusCode();

            var json = await resp.Content.ReadAsStringAsync(cancellationToken);
            var webhookResult = JsonSerializer.Deserialize<WebhookResponse>(json,
              new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            booking.MeetingUrl = webhookResult?.MeetingUrl ?? "";

            await bookingRepository.SaveChangeAsync(cancellationToken);

            //Notify booked user and consultant
            await systemNotificationService.NotifyNewBookingAsync(booking, cancellationToken);
            return Unit.Value;
        }
        private DateTime GetCurrentVietnamTime()
        {
            DateTime utcNow = DateTime.UtcNow;
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // Vietnam Time Zone
            return TimeZoneInfo.ConvertTimeFromUtc(utcNow, vietnamTimeZone);
        }
    }
}
