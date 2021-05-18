using Insurance.Repositories.Interfaces.IRepositories;

namespace Insurance.Repositories.UnitOfWork.Interfaces
{
    public interface IUnitOfWork
    {
        IRiskRepository RiskRepository { get; }
        IStatusRepository StatusRepository { get; }
        IContractRepository ContractRepository { get; }
        IBranchRepository BranchRepository { get; }
        IReasonRepository ReasonRepository { get; }
        ITariffRepository TariffRepository { get; }
        ITypeInsuranceRepository TypeInsuranceRepository { get; }
        IAgentRepository AgentRepository { get; }
    }
}