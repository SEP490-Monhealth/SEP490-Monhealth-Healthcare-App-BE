//using MediatR;
//using Monhealth.Application.Contracts.Persistence;

//namespace Monhealth.Application.Features.ConsultantBank.Commands.ChangeIsVerifiedConsultantBank
//{
//    public class ChangeIsVerifiedConsultantBankCommandHandler(IConsultantBankRepository consultantBankRepository) : IRequestHandler<ChangeIsVerifiedConsultantBankCommand, bool>
//    {
//        public async Task<bool> Handle(ChangeIsVerifiedConsultantBankCommand request, CancellationToken cancellationToken)
//        {
//            var consultantBank = await consultantBankRepository.GetByIdAsync(request.ConsultantBankId);
//            if (consultantBank == null)
//            {
//                return false;
//            }
//            consultantBank.IsVerified = !consultantBank.IsVerified;
//            consultantBankRepository.Update(consultantBank);
//            await consultantBankRepository.SaveChangeAsync(cancellationToken);
//            return true;
//        }
//    }
//}
