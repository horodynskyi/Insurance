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
        protected readonly InsuranceDbContext Context;
        public GenericRepository(InsuranceDbContext context)
        {
            Context = context;
        }
        public async Task Create(TEntity entity)
        {
            await Context.Set<TEntity>().AddAsync(entity);
            await Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> Get(GenericParams parameters)
        {
            var result =  Context.Set<TEntity>().AsQueryable();
            //return 
            return  PagedList<TEntity>.ToPagedList(result,
                parameters.PageNumber,
                parameters.PageSize);
        }

        public async Task<TEntity> GetById(TId id)
        {
            return await Context.Set<TEntity>().FindAsync(id);
        }

        public async Task Update(TEntity entity, TId id)
        {
             Context.Set<TEntity>().Update(entity);
             await Context.SaveChangesAsync();
        }

        public async Task Delete(TId id)
        {
            var result = await Context.Set<TEntity>().FindAsync(id);
            Context.Set<TEntity>().Remove(result);
            await Context.SaveChangesAsync();
        }

        public async Task<IQueryable<TEntity>> FindByCondition(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}