using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Insurance.DAL.Models;
using Insurance.Helpers.Helpers;
using Insurance.Helpers.Helpers.Interfaces;
using Insurance.Helpers.Params;
using Insurance.Infrastracture.Infrastracture;
using Insurance.Repositories.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Insurance.Repositories.Repositories.Repositories
{
    public class ContractRepository : GenericRepository<Contract, int>, IContractRepository
    {
        private readonly ISortHelper<Contract> _sortHelper;

        public ContractRepository(InsuranceDbContext context, ISortHelper<Contract> sortHelper) : base(context)
        {
            _sortHelper = sortHelper;
        }

        public new async Task Create(Contract contract)
        {
            contract.Agent = await _context.Agents.FindAsync(contract.Agent.Id);
            contract.Risk = await _context.Risks.FindAsync(contract.Risk.Id);
            contract.Tariff = await _context.Tariffs.FindAsync(contract.Tariff.Id);
            contract.TypeInsurance = await _context.TypeInsurances.FindAsync(contract.TypeInsurance.Id);
            contract.Status = await _context.Statuses.FindAsync(contract.Status.Id);
            await _context.Contracts.AddAsync(contract);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Contract>> Get(ContractParams parameters)
        {
            var result = _context.Contracts
                .Include(p => p.Agent)
                .Include(p => p.Risk)
                .Include(p => p.Tariff)
                .Include(p => p.TypeInsurance)
                .AsNoTracking();

            var sortedAccounts = _sortHelper.ApplySort(result, parameters.OrderBy);

            return PagedList<Contract>.ToPagedList(sortedAccounts,
                parameters.PageNumber,
                parameters.PageSize);
        }

        public new async Task<Contract> GetById(int id)
        {
            return await _context.Contracts
                .Include(c => c.Agent)
                .Include(c => c.Risk)
                .Include(c => c.Tariff)
                .Include(c => c.TypeInsurance)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task GetCountContracts(AgentParams agentParams)
        {
            
           
        }
    }
}