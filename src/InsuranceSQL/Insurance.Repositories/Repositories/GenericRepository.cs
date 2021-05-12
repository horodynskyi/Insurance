using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Insurance.Helpers.Helpers;
using Insurance.Helpers.Params;
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

        public async Task<IEnumerable<TEntity>> Get(GenericParams parameters)
        {
            var result =  _context.Set<TEntity>().AsQueryable();
            //return 
            return  PagedList<TEntity>.ToPagedList(result,
                parameters.PageNumber,
                parameters.PageSize);
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

        public async Task<IQueryable<TEntity>> FindByCondition(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}