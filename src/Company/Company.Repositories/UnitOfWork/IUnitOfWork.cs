using Company.Repositories.Repositories.Interfaces;

namespace Company.Repositories.UnitOfWork
{
    public interface IUnitOfWork
    {
        IAgentRepository AgentRepository { get; }
        IBranchRepository BranchRepository { get; }
    }
}