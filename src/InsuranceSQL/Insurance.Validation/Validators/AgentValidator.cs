using FluentValidation;
using Insurance.DAL.Models;
using Insurance.Infrastracture.Infrastracture;

namespace Insurance.Validation.Validators
{
    public class AgentValidator:GenericValidator<Agent>
    {
        public AgentValidator(InsuranceDbContext context) : base(context)
        {
            RuleFor(x => x.Branch)
                .NotNull().WithMessage("Branch must be not Null")
                .MustAsync(IsExist).WithMessage("The entered Branch dosnt`t exist");
            RuleFor(x => x.FirstName)
                .NotNull().WithMessage("First Name must be not Null");
            RuleFor(x => x.SecondName).NotNull().WithMessage("Second Name must be not null");
        }
    }
}