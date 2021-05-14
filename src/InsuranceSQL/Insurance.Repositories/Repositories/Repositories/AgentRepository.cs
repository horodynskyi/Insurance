using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Bogus.DataSets;
using Insurance.DAL.Models;
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
            agent.Branch = await _context.Branches.FindAsync(agent.Branch.Id);
            await _context.Agents.AddAsync(agent);
            await _context.SaveChangesAsync();
        }
        public async Task GetCountContracts(AgentParams agentParams)
        {
            
        }
    }
}