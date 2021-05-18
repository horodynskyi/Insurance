using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using Insurance.Infrastracture.Infrastracture;
using Microsoft.EntityFrameworkCore;

namespace Insurance.Validation.Validators
{
    public class GenericValidator<TEntity>:AbstractValidator<TEntity> where TEntity:class
    {
        protected readonly InsuranceDbContext _context;
        public GenericValidator(InsuranceDbContext context)
        {
            _context = context;
        }

        public async Task<bool> IsExist<TEntity>(TEntity entity, CancellationToken cancellationToken) where TEntity : class
        {
            return await _context.Set<TEntity>().ContainsAsync(entity, cancellationToken);
        }

        public async Task<bool> IsNotExist<TEntity>(TEntity entity, CancellationToken cancellationToken) where TEntity : class
        {
            return !await _context.Set<TEntity>().ContainsAsync(entity, cancellationToken);
        }
    }
}