using System.Threading;
using System.Threading.Tasks;
using Insurance.Infrastracture.Infrastracture;
using Microsoft.EntityFrameworkCore;

namespace Insurance.Validation
{
    public static class IsExistChecker
    {
        public static async Task<bool> IsExist<TEntity>(InsuranceDbContext context, TEntity entity,
            CancellationToken cancellationToken) where TEntity : class
        {
            return await context.Set<TEntity>().ContainsAsync(entity, cancellationToken);
        }
    }
}