using Insurance.Repositories.Interfaces.IRepositories;

namespace Insurance.Repositories.UnitOfWork.Interfaces
{
    public interface IUnitOfWork
    {
        IRiskRepository RiskRepository { get; }
    }
}