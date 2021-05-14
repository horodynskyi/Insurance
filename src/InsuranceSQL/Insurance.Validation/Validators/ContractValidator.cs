using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using Insurance.DAL.Models;
using Insurance.DTO.DTO;
using Insurance.Infrastracture.Infrastracture;

namespace Insurance.Validation.Validators
{
    public class ContractValidator : AbstractValidator<Contract>
    {
       private readonly InsuranceDbContext _context;

        public ContractValidator(InsuranceDbContext context)
        {
            _context = context;
            RuleFor(x => x.Agent).NotNull().WithMessage("Agent must be not null!")
                .MustAsync(IsExist).WithMessage("The entered agent  doesn`t exist");
            RuleFor(x => x.Risk).NotNull().WithMessage("Agent must be not null!")
                .MustAsync(IsExist).WithMessage("The entered risks  doesn`t exist");
            RuleFor(x => x.Tariff).NotNull().WithMessage("Agent must be not null!")
                .MustAsync(IsExist).WithMessage("The entered tariff  doesn`t exist");
            RuleFor(x => x.TypeInsurance).NotNull().WithMessage("Agent must be not null!")
                .MustAsync(IsExist).WithMessage("The entered tariff  doesn`t exist");
        }

        public async Task<bool> IsExist<TEntity>(TEntity entity,CancellationToken token) where TEntity:class
        {
            
            return await IsExistChecker.IsExist(_context, entity, token);
        }
    }
}