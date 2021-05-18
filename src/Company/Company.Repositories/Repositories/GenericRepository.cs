using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Company.DAL.SQLEntities.Interfaces;
using Company.Infrastracture;
using Company.Repositories.Repositories.Interfaces;
using Dapper;

namespace Company.Repositories.Repositories
{
    public class GenericRepository<TEntity,TId>:IGenericRepository<TEntity,TId> where TEntity:class, IEntity<TId>
    {
        protected IConnectionFactory _connectionFactory;
        protected readonly string TableName;
        private readonly bool _isSoftDelete;

        public GenericRepository(string tableName, IConnectionFactory connectionFactory)
        {
            TableName = tableName;
            _isSoftDelete = false;
            _connectionFactory = connectionFactory;
        }

        public async Task Create(TEntity entity)
        {
            var stringOfColumns = string.Join(", ", GetColumns());
            var stringOfProperties = string.Join(", ", GetProperties(entity));
            var query = "SP_InsertRecordToTable";

            using (var db = _connectionFactory.GetSqlConnection)
            {
                await db.QueryFirstOrDefaultAsync<TEntity>(
                    sql: query,
                    param: new { P_tableName = TableName, P_columnsString = stringOfColumns, P_propertiesString = stringOfProperties },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<TEntity>> Get()
        {
            var query = "SP_GetAllRecordsFromTable";

            using (var db = _connectionFactory.GetSqlConnection)
            {
                return await  db.QueryAsync<TEntity>(query,
                    new { P_tableName = TableName },
                    commandType: CommandType.StoredProcedure);
            }
        }
    
        public async Task<TEntity> GetById(TId id)
        {
            var query = "SP_GetRecordByIdFromTable";

            using (var db = _connectionFactory.GetSqlConnection)
            {
                return await db.QueryFirstOrDefaultAsync<TEntity>(query,
                    new { P_tableName = TableName, P_Id = id },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public async Task Update(TEntity entity, TId id)
        {
            var columns = GetColumns();
            var properties = GetProperties(entity);
            columns = columns.Zip(properties, (column, property) => column + " = " + property);
            var stringOfColumns = string.Join(", ", columns);

            using (var db = _connectionFactory.GetSqlConnection)
            {
                var query = "SP_UpdateRecordInTable";

                 await db.QueryFirstOrDefaultAsync<TEntity>(
                    sql: query,
                    param: new { P_tableName = TableName, P_columnsString = stringOfColumns, P_Id = id },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public async Task Delete(TId id)
        {
            if (_isSoftDelete)
            {
                var columns = GetColumns();
                var isActiveColumnUpdateString = columns.Where(e => e == "IsActive").Select(e => $"{e} = 0").FirstOrDefault();

                using (var db = _connectionFactory.GetSqlConnection)
                {
                    var query = "SP_UnActivateRecordStatementInTable";

                    var UnActivateStatement = await db.QueryFirstOrDefaultAsync<string>(
                        sql: query,
                        param: new { P_tableName = TableName, P_columnsString = isActiveColumnUpdateString, P_Id = id },
                        commandType: CommandType.StoredProcedure);

                     await db.QueryFirstOrDefaultAsync<TEntity>(
                        sql: UnActivateStatement,
                        param: id,
                        commandType: CommandType.Text);
                }
            }
            else
            {
                using (var db = _connectionFactory.GetSqlConnection)
                {
                    var query = "SP_DeleteRecordFromTable";
                     await db.QueryFirstOrDefaultAsync<TEntity>(
                        sql: query,
                        param: new { P_tableName = TableName, P_Id = id },
                        commandType: CommandType.StoredProcedure);
                }
            }
        }
        
        private IEnumerable<string> GetColumns()
        {
            return typeof(TEntity)
                .GetProperties()
                .Where(e => e.Name != "Id" && e.Name != "Duration" && !e.PropertyType.GetTypeInfo().IsGenericType)
                .Select(e => e.Name);
        }

        private IEnumerable<string> GetProperties(TEntity entity)
        {
            return typeof(TEntity)
                .GetProperties()
                .Where(e => e.Name != "Id" && e.Name != "Duration" && !e.PropertyType.GetTypeInfo().IsGenericType)
                .Select(e => '\'' + e.GetValue(entity).ToString() + '\'');
        }
    }
}