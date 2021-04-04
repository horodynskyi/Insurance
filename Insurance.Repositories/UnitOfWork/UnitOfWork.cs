using Insurance.Repositories.Interfaces.IRepositories;
using Insurance.Repositories.UnitOfWork.Interfaces;

namespace Insurance.Repositories.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {
        public UnitOfWork(IRiskRepository riskRepository, IContractRepository contractRepository, IBranchRepository branchRepository, IReasonRepository reasonRepository, ITariffRepository tariffRepository, IBranchAgentRepository branchAgentRepository, ITerminatedContractRepository terminatedContractRepository, ITypeInsuranceRepository typeInsuranceRepository, IAgentRepository agentRepository)
        {
            RiskRepository = riskRepository;
            ContractRepository = contractRepository;
            BranchRepository = branchRepository;
            ReasonRepository = reasonRepository;
            TariffRepository = tariffRepository;
            BranchAgentRepository = branchAgentRepository;
            TerminatedContractRepository = terminatedContractRepository;
            TypeInsuranceRepository = typeInsuranceRepository;
            AgentRepository = agentRepository;
        }

        public IRiskRepository RiskRepository { get; }
        public IContractRepository ContractRepository { get; }
        public IBranchRepository BranchRepository { get; }
        public IReasonRepository ReasonRepository { get; }
        public ITariffRepository TariffRepository { get; }
        public IBranchAgentRepository BranchAgentRepository { get; }
        public ITerminatedContractRepository TerminatedContractRepository { get; }
        public ITypeInsuranceRepository TypeInsuranceRepository { get; }
        public IAgentRepository AgentRepository { get; }
    }
}