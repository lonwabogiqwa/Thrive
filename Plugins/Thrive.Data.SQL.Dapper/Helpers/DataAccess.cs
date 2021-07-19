using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace Thrive.Data.SQL.Dapper.Helpers
{
    public class DataAccess : IDataAccess
    {
        private readonly string _connectionString;

        public DataAccess(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public List<T> Query<T, TU>(string sql, TU parameters)
        {
            using IDbConnection conn = new SqlConnection(_connectionString);
            return conn.Query<T>(sql, parameters).ToList();
        }

        public T QuerySingle<T, TU>(string sql, TU parameters)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                return conn.QuerySingle<T>(sql, parameters);
            }
        }

        public void ExecuteCommand<T>(string sql, T parameters)
        {
            using IDbConnection conn = new SqlConnection(_connectionString);
            conn.Execute(sql, parameters);
        }
    }
}
