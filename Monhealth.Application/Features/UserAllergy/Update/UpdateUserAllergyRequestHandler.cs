using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;

namespace Monhealth.Application
{
    public class UpdateUserAllergyRequestHandler : IRequestHandler<UpdateUserAllergyRequest, bool>
    {
        private readonly IUserAllergyRepository _userAllergyRepository;
        private readonly IAllergyRepository _allergyRepository;

        public UpdateUserAllergyRequestHandler(IUserAllergyRepository userAllergyRepository, IAllergyRepository allergyRepository)
        {
            _userAllergyRepository = userAllergyRepository;
            _allergyRepository = allergyRepository;
        }

        public async Task<bool> Handle(UpdateUserAllergyRequest request, CancellationToken cancellationToken)
        {
            // Lấy danh sách dị ứng hiện có của người dùng.
            var currentUserAllergies = await _userAllergyRepository.GetUserAllergiesByUserId(request.UserId);

            var newAllergies = await _allergyRepository.GetAllergiesByList(request.Request.Allergies);

            // Nếu đã có dị ứng hiện tại, xóa toàn bộ trước khi cập nhật.
            if (currentUserAllergies != null && currentUserAllergies.Any())
            {
                _userAllergyRepository.RemoveRange(currentUserAllergies);
            }

            // Thêm các dị ứng mới vào danh sách của người dùng.
            foreach (var allergy in newAllergies)
            {
                var userAllergy = new UserAllergy
                {
                    UserId = request.UserId,
                    AllergyId = allergy.AllergyId
                };

                _userAllergyRepository.Add(userAllergy);
            }
            await _userAllergyRepository.SaveChangeAsync();
            return true;
        }
    }
}
