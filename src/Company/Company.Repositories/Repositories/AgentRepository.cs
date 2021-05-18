using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Company.DAL.SQLEntities;
using Company.Infrastracture;
using Company.Repositories.Repositories.Interfaces;
using Dapper;

namespace Company.Repositories.Repositories
{
    public class AgentRepository:GenericRepository<SqlAgent,int>,IAgentRepository
    {
        public AgentRepository(IConnectionFactory connectionFactory) : base("Agents", connectionFactory)
        {
        }
        
        public async Task<IEnumerable<SqlAgent>> GetByBranchId(int id)
        {
            var query = "SP_GetAgentByBranchId";

            using (var db = _connectionFactory.GetSqlConnection)
            {
                return await db.QueryAsync<SqlAgent>(query,
                    new { P_tableName = TableName, P_Id = id },
                    commandType: CommandType.StoredProcedure);
            }
        }
    }
}