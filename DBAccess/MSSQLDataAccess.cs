using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DBAccess
{
    public class MSSQLDataAccess : IDBAccess
    {
        #region Construction

        private readonly string ConnectionString;

        public MSSQLDataAccess(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }

        #endregion


        public async Task<int> GetCount<U>(string query, U parameters)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var data = await connection.QuerySingleOrDefaultAsync<int>(query, parameters);
                return data;
            }
        }

        public async Task<List<T>> GetList<T, U>(string query, U parameters)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var data = await connection.QueryAsync<T>(query, parameters);
                return data.ToList();
            }
        }

        public async Task<T> Get<T, U>(string query, U parameters)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var data = await connection.QuerySingleOrDefaultAsync<T>(query, parameters);
                return data;
            }
        }

        public async Task<string> Execute<T>(string query, T parameters)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var data = await connection.ExecuteOutputParamAsync(query, parameters);
                return data.ToString();
            }
        }

    }
}
