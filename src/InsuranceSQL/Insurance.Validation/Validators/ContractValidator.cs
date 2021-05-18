using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using Insurance.DAL.Models;
using Insurance.DTO.DTO;
using Insurance.Infrastracture.Infrastracture;

namespace Insurance.Validation.Validators
{
    public class ContractValidator : GenericValidator<Contract>
    {
        public ContractValidator(InsuranceDbContext context) : base(context)
        {
            RuleFor(x => x.Agent).NotNull().WithMessage("Agent must be not null!")
                .MustAsync(IsExist).WithMessage("The entered agent  doesn`t exist");
            RuleFor(x => x.Risk).NotNull().WithMessage("Agent must be not null!")
                .MustAsync(IsExist).WithMessage("The entered risks  doesn`t exist");
            RuleFor(x => x.Tariff).NotNull().WithMessage("Agent must be not null!")
                .MustAsync(IsExist).WithMessage("The entered tariff  doesn`t exist");
            RuleFor(x => x.TypeInsurance).NotNull().WithMessage("Agent must be not null!")
                .MustAsync(IsExist).WithMessage("The entered tariff  doesn`t exist");
            RuleFor(x => x.DateTime).NotNull();
        }
    }
}