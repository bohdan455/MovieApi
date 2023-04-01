using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess.Access
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;
        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }
        public async Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U props, string connectionId = "Default")
        {
            using IDbConnection conn = new SqlConnection(_config.GetConnectionString(connectionId));
            return await conn.QueryAsync<T>(storedProcedure, props, commandType: CommandType.StoredProcedure);
        }
        public async Task PostData<T>(string storedProcedure, T props, string connectionId = "Default")
        {
            using IDbConnection conn = new SqlConnection(_config.GetConnectionString(connectionId));
            await conn.ExecuteAsync(storedProcedure, props, commandType: CommandType.StoredProcedure);
        }
    }
}
