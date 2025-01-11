using Monhealth.Core;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IAllergyRepository : IGenericRepository<Allergy, Guid>
    {
          Task<int>SaveChangeAsync();
    }
}