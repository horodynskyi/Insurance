using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Bogus.DataSets;
using Insurance.DAL.Models;
using Insurance.Helpers.Helpers;
using Insurance.Helpers.Params;
using Insurance.Infrastracture.Infrastracture;
using Insurance.Repositories.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Insurance.Repositories.Repositories.Repositories
{
    public class AgentRepository:GenericRepository<Agent,int> , IAgentRepository
    {
        
        public AgentRepository(InsuranceDbContext context) : base(context)
        {
            
        }

        public new async Task Create(Agent agent)
        {
            agent.Branch = await Context.Branches.FindAsync(agent.Branch.Id);
            await Context.Agents.AddAsync(agent);
            await Context.SaveChangesAsync();
        }
        public async Task GetCountContracts(AgentParams agentParams)
        {
            
        }

        public async Task<IEnumerable<Agent>> GetAll()
        {
            return await Context.Agents
                .Include(x => x.Branch)
                .ToListAsync();
        }

        public new async Task Delete(int id)
        {
            var result = await Context.Set<Agent>().FindAsync(id);
            result.Branch = new Branch();
            result.Branch = await Context.Branches.FindAsync(result.Branch.Id);
            Context.Set<Agent>().Remove(result);
            await Context.SaveChangesAsync();
        }

        public new async Task<IEnumerable<Agent>> Get(GenericParams parameters)
        {
            var result = Context.Agents
                .Include(x => x.Branch)
                .AsQueryable();
            return PagedList<Agent>.ToPagedList(result,parameters.PageNumber,parameters.PageSize);
        }
        public new async Task<Agent> GetById(int id)
        {
            return await Context.Agents
                .Include(x => x.Branch)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public new async Task Update(Agent agent, int id)
        {
            agent.Branch = await Context.Branches.FindAsync(agent.Branch.Id);
            Context.Agents.Update(agent);
            await Context.SaveChangesAsync();
        }
        
    }
}