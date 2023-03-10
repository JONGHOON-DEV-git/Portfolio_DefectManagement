using BugReport.Core;
using BugReport.EF_Core;
using BugReport.EF_Core.models;
using BugReport.EF_Core.storedprocedures;
using BugReport.Repository.interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BugReport.Repository.user
{
    public class EFCoreUserRepository : IUserRepository
    {
        
        public bool AuthenticateUser(string loginID, string password)
        {
            using (ReportDbContext db = new ())
            {
                UserManagementProcedure sp_User = new (db);
                return sp_User.CheckAuthenticateUser(loginID, password);
            }
        }

        public void CreateUser(string loginID, string password, string userNm)
        {
            using (ReportDbContext db = new ())
            {
                if (db.Users.Where(x => x.UserId == loginID).FirstOrDefault() != null) 
                    throw new Exception(ExceptionMessages.ContainsId);

                UserManagementProcedure sp_User = new (db);
                sp_User.CreateUser(loginID, password, userNm);
            }
        }

        public User GetUser(string loginID)
        {
            using (ReportDbContext db = new ())
            {
                var org = db.Users.Where(x => x.UserId == loginID).FirstOrDefault();
                if (org == null) throw new Exception(ExceptionMessages.NotFoundUser);
                return org;
            }
        }

    }
}
