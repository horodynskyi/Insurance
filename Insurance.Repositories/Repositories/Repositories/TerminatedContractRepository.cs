using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Insurance.DAL.Models;
using Insurance.Infrastracture.Infrastracture;
using Insurance.Repositories.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Insurance.Repositories.Repositories.Repositories
{
    public class TerminatedContractRepository:ITerminatedContractRepository
    {
        private readonly InsuranceDbContext _context;

        public TerminatedContractRepository(InsuranceDbContext context)
        {
            _context = context;
        }

        public async Task Create(TerminatedContract contract)
        {
            await _context.Set<TerminatedContract>().AddAsync(contract);
        }

        public async Task<IEnumerable<TerminatedContract>> Get()
        {
            return await _context.Set<TerminatedContract>().ToListAsync();
        }

        public async Task<TerminatedContract> GetById(int contractId)
        {
            return await _context.Set<TerminatedContract>().FindAsync(contractId);
        }

        public async Task Update(TerminatedContract contract, int contractId)
        {
             _context.Set<TerminatedContract>().Update(contract);
             await _context.SaveChangesAsync();
        }

        public async Task Delete(int contractId)
        {
            var result = await _context.Set<TerminatedContract>().FindAsync(contractId);
            _context.Set<TerminatedContract>().Remove(result);
        }
    }
}