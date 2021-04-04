using Insurance.Repositories.Interfaces.IRepositories;
using Insurance.Repositories.UnitOfWork.Interfaces;

namespace Insurance.Repositories.UnitOfWork
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