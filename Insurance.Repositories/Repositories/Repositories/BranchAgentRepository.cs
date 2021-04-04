using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Insurance.DAL.Models;
using Insurance.Infrastracture.Infrastracture;
using Insurance.Repositories.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Insurance.Repositories.Repositories.Repositories
{
    public class BranchAgentRepository:IBranchAgentRepository
    {
        private readonly InsuranceDbContext _context;

        public BranchAgentRepository(InsuranceDbContext context)
        {
            _context = context;
        }

        public async Task Create(BranchAgent branchAgent)
        {
            await _context.Set<BranchAgent>().AddAsync(branchAgent);
        }

        public async Task<IEnumerable<BranchAgent>> Get()
        {
            return await _context.Set<BranchAgent>().ToListAsync();
        }

        public async Task<BranchAgent> GetById(int agentId)
        {
            return await _context.Set<BranchAgent>().FindAsync(agentId);
        }

        public async Task Update(BranchAgent branchAgent, int agentId)
        {
            _context.Set<BranchAgent>().Update(branchAgent);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int agentId)
        {
            var result = await _context.Set<TerminatedContract>().FindAsync(agentId);
            _context.Set<TerminatedContract>().Remove(result);
        }
    }
}