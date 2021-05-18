using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Company.Repositories.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity,TId>
    {
        Task Create(TEntity entity);
        Task<IEnumerable<TEntity>> Get();
        Task<TEntity> GetById(TId id);
        Task Update(TEntity entity, TId id);
        Task Delete(TId id);
    }
}