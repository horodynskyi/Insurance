using Company.Repositories.Repositories.Interfaces;

namespace Company.Repositories.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {
        public UnitOfWork(IAgentRepository agentRepository, IBranchRepository branchRepository)
        {
            AgentRepository = agentRepository;
            BranchRepository = branchRepository;
        }

        public IAgentRepository AgentRepository { get; }
        public IBranchRepository BranchRepository { get; }
    }
}