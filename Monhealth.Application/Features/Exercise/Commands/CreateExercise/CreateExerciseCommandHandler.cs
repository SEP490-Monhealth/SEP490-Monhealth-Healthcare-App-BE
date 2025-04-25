using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Exercise.Commands.CreateExercise
{
    public class CreateExerciseCommandHandler : IRequestHandler<CreateExerciseCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IExerciseRepository _exerciseRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUserRepository _userRepository;
        public CreateExerciseCommandHandler(IMapper mapper, IExerciseRepository exerciseRepository, ICategoryRepository categoryRepository, IUserRepository userRepository)
        {
            _mapper = mapper;
            _exerciseRepository = exerciseRepository;
            _categoryRepository = categoryRepository;
            _userRepository = userRepository;
        }
        public async Task<Unit> Handle(CreateExerciseCommand request, CancellationToken cancellationToken)
        {
            var checkExerciseExisted = await _exerciseRepository.GetExerciseByNameAsync(request.CreateExerciseDTO.ExerciseName);
            if (checkExerciseExisted != null)
            {
                throw new Exception("Bài tập đã tồn tại.");
            }
            var user = await _userRepository.GetByIdAsync(request.CreateExerciseDTO.UserId);
            if (user == null)
            {
                throw new Exception("Người dùng không tồn tại");
            }
            var newExercise = _mapper.Map<Domain.Exercise>(request.CreateExerciseDTO);
            newExercise.ExerciseId = Guid.NewGuid();
            newExercise.Status = false;
            newExercise.CreatedAt = DateTime.UtcNow;
            newExercise.UpdatedAt = DateTime.UtcNow;
            _exerciseRepository.Add(newExercise);
            await _exerciseRepository.SaveChangeAsync();
            return Unit.Value;
        }
    }
}
