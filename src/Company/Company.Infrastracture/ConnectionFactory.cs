using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Company.Infrastracture
{
    public class ConnectionFactory:IConnectionFactory
    {
        
        private static string _connectionString;
        private readonly IConfiguration _configuration;

        public ConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void SetConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection GetSqlConnection
        {
            get
            {
                SqlConnection connection;

                if (!string.IsNullOrEmpty(_connectionString))
                    connection = new SqlConnection(_connectionString);
                else
                    connection = new SqlConnection(_configuration.GetConnectionString("SQLConnection"));

                connection.Open();

                return connection;
            }
            
        }
    }
}