using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using Insurance.DAL.Models;
using Insurance.DTO.DTO;
using Insurance.Infrastracture.Infrastracture;

namespace Insurance.Validation.Validators
{
    public class ContractValidator : AbstractValidator<ContractDTO>
    {
       //private readonly InsuranceDbContext _context;

        public ContractValidator(InsuranceDbContext context)
        {
            /*_context = context;
            RuleFor(x => x.agentId).NotEqual(0).WithMessage("Agent must be not null!")
                .MustAsync(IsExist).WithMessage("The entered agent  doesn`t exist");
            RuleFor(x => x.riskId).NotEqual(0).WithMessage("Agent must be not null!")
                .MustAsync(IsExist).WithMessage("The entered risks  doesn`t exist");
            RuleFor(x => x.branchId).NotEqual(0).WithMessage("Branch must be not null!")
                .MustAsync(IsExist).WithMessage("The entered branch  doesn`t exist");
            RuleFor(x => x.tariffId).NotEqual(0).WithMessage("Agent must be not null!")
                .MustAsync(IsExist).WithMessage("The entered tariff  doesn`t exist");
            RuleFor(x => x.typeInsuranceId).NotEqual(0).WithMessage("Agent must be not null!")
                .MustAsync(IsExist).WithMessage("The entered tariff  doesn`t exist");*/
        }

        /*public async Task<bool> IsExist<TEntity>(TEntity entity,CancellationToken token) where TEntity:class
        {
            return true;
            //return await IsExistChecker.IsExist(_context, entity, token);
        }*/
    }
}