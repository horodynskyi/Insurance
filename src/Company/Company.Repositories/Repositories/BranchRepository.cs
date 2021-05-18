using Company.DAL.SQLEntities;
using Company.Infrastracture;
using Company.Repositories.Repositories.Interfaces;

namespace Company.Repositories.Repositories
{
    public class BranchRepository:GenericRepository<SqlBranch,int>,IBranchRepository
    {
        public BranchRepository(IConnectionFactory connectionFactory) : base("Branches", connectionFactory)
        {
        }
    }
}