using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BugReport.EF_Core.storedprocedures
{
    public class UserManagementProcedure : IDisposable
    {
        public UserManagementProcedure(DbContext dbContext)
        {
            DbContext = dbContext;
        }

        public DbContext DbContext { get; }

        public bool CheckAuthenticateUser(string userId, string password)
        {
            string query = "sp_AuthenticateUser @userId, @password";
            var connection = DbContext.Database.GetDbConnection() as SqlConnection;
            var result = connection?.QueryFirstOrDefault<string>(query, new { userId, password });

            if (result == "Success")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public void CreateUser(string userId, string password, string userNm)
        {
            FormattableString query = $"sp_CreateUser {userId},{password},{userNm}";
            DbContext.Database.ExecuteSql(query);
        }

        public void Dispose()
        {
            
        }
    }
}
