using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Insurance.DAL.Models;
using Insurance.Infrastracture.Infrastracture;
using Insurance.Repositories.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Insurance.Repositories.Repositories.Repositories
{
    public class TerminatedContractRepository : ITerminatedContractRepository
    {
        private readonly InsuranceDbContext _context;

        public TerminatedContractRepository(InsuranceDbContext context)
        {
            _context = context;
        }

        public async Task Create(TerminatedContract contract)
        {
            contract.Contract = await _context.Contracts.FindAsync(contract.Contract.Id);
            contract.Reason = await _context.Reasons.FindAsync(contract.Reason.Id);
            await _context.TerminatedContracts.AddAsync(contract);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TerminatedContract>> Get()
        {
            var result = await _context.TerminatedContracts
                .Include(t => t.Contract)
                .Include(c => c.Contract.Agent)
                .Include(c => c.Contract.Risk)
                .Include(c => c.Contract.Branch)
                .Include(c => c.Contract.Tariff)
                .Include(c => c.Contract.TypeInsurance)
                .Include(t => t.Reason)
                .ToListAsync();
            return result;
        }


        public async Task<TerminatedContract> GetById(int contractId)
        {
            return await _context.TerminatedContracts
                .Include(t => t.Contract)
                .Include(t => t.Reason)
                .FirstOrDefaultAsync(c => c.Id == contractId);
            ;
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