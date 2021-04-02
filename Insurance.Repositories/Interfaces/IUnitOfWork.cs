using Insurance.Repositories.Interfaces.IRepositories;

namespace Insurance.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IRiskRepository RiskRepository { get; }
    }
}