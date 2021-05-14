using Insurance.Repositories.Interfaces.IRepositories;
using Insurance.Repositories.UnitOfWork.Interfaces;

namespace Insurance.Repositories.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IRiskRepository riskRepository, IContractRepository contractRepository, IBranchRepository branchRepository, IReasonRepository reasonRepository, ITariffRepository tariffRepository,  ITypeInsuranceRepository typeInsuranceRepository, IAgentRepository agentRepository)
        {
            RiskRepository = riskRepository;
            ContractRepository = contractRepository;
            BranchRepository = branchRepository;
            ReasonRepository = reasonRepository;
            TariffRepository = tariffRepository;
         
            TypeInsuranceRepository = typeInsuranceRepository;
            AgentRepository = agentRepository;
        }
        
        public IRiskRepository RiskRepository { get; }
        public IContractRepository ContractRepository { get; }
        public IBranchRepository BranchRepository { get; }
        public IReasonRepository ReasonRepository { get; }
        public ITariffRepository TariffRepository { get; }
        public ITypeInsuranceRepository TypeInsuranceRepository { get; }
        public IAgentRepository AgentRepository { get; }
    }
}