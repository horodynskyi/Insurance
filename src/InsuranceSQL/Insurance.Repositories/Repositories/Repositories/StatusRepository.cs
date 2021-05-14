using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.DAL.Models;
using Insurance.Helpers.Helpers;
using Insurance.Helpers.Params;
using Insurance.Infrastracture.Infrastracture;
using Insurance.Repositories.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Insurance.Repositories.Repositories.Repositories  
{
    public class StatusRepository:GenericRepository<Status,int>,IStatusRepository
    {
        public StatusRepository(InsuranceDbContext context) : base(context)
        {
       }

        public new async Task<IEnumerable<Status>> Get(GenericParams parameters)
        { 
            var result = await _context.Statuses
                .Include(s => s.Reason)
                .ToListAsync();
            return  PagedList<Status>.ToPagedList(result,
                parameters.PageNumber,
                parameters.PageSize);
        }

        public new async Task Create(Status status)
        {
            status.Reason =await _context.Reasons.FindAsync(status.Reason.Id);
            await _context.Statuses.AddAsync(status);
            await _context.SaveChangesAsync();
        }
    }
}