using Insurance.Repositories.Interfaces;
using Insurance.Repositories.Interfaces.IRepositories;

namespace Insurance.Repositories.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {
        public UnitOfWork(IRiskRepository riskRepository)
        {
            RiskRepository = riskRepository;
        }

        public IRiskRepository RiskRepository { get; }
    }
}