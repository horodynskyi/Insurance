using Insurance.Repositories.Interfaces.IRepositories;

namespace Insurance.Repositories.UnitOfWork.Interfaces
{
    public interface IUnitOfWork
    {
        IRiskRepository RiskRepository { get; }
        IContractRepository ContractRepository { get; }
        IBranchRepository BranchRepository { get; }
        IReasonRepository ReasonRepository { get; }
        ITariffRepository TariffRepository { get; }
        IBranchAgentRepository BranchAgentRepository { get; }
        ITerminatedContractRepository TerminatedContractRepository { get; }
        ITypeInsuranceRepository TypeInsuranceRepository { get; }
        IAgentRepository AgentRepository { get; }
    }
}