using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IDailyWaterIntakesRepository : IGenericRepository<DailyWaterIntake, Guid>
    {
        Task<DailyWaterIntake> GetDailyWaterIntakeByUserAndDate(DateTime createAt, Guid userId);
        Task<DailyWaterIntake> GetDailyWaterIntakesByUser(Guid userId, DateTime date);
        Task<int> SaveChangeAsync();
    }
}