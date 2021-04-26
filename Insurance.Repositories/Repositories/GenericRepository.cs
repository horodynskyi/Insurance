using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Insurance.Infrastracture.Infrastracture;
using Insurance.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Insurance.Repositories.Repositories
{
    public class GenericRepository<TEntity,TId>:IGenericRepository<TEntity,TId> where TEntity:class
    {
        protected readonly InsuranceDbContext _context;
        public GenericRepository(InsuranceDbContext context)
        {
            _context = context;
        }
        public async Task Create(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> Get()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(TId id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task Update(TEntity entity, TId id)
        {
             _context.Set<TEntity>().Update(entity);
             await _context.SaveChangesAsync();
        }

        public async Task Delete(TId id)
        {
            var result = await _context.Set<TEntity>().FindAsync(id);
            _context.Set<TEntity>().Remove(result);
            await _context.SaveChangesAsync();
        }
    }
}