using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace BugReport.EF_Core.StoredProcedure
{
    public partial class ReportDbContext : DbContext
    {
        public bool CheckAuthenticateUser(string userName, string password)
        {
            FormattableString query = $"AuthenticateUser {userName},{password}";
            return Database.SqlQuery<bool>(query).FirstOrDefault();
        }
    }
}
