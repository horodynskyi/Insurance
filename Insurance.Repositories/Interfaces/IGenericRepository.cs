using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Insurance.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity,TId> where TEntity:class
    {
        Task Create(TEntity entity);
        Task<IEnumerable<TEntity>> Get();
        Task<TEntity> GetById(TId id);
        Task Update(TEntity entity, TId id);
        Task Delete(TId id);
    }
}