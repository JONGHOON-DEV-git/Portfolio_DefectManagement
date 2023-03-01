using BugReport.EF_Core;
using BugReport.EF_Core.models;
using BugReport.EF_Core.storedprocedures;
using BugReport.Repository.interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugReport.Repository.user
{
    public class EF_UserRepository : IUserRepository
    {
        
        public bool AuthenticateUser(string userId, string password)
        {
            using (ReportDbContext db = new ReportDbContext())
            using (UserManagementProcedure sp_User = new UserManagementProcedure(db))
            {
                return sp_User.CheckAuthenticateUser(userId, password);
            }
        }

        public void CreateUser(string userId, string password, string userNm)
        {
            using (ReportDbContext db = new ReportDbContext())
            using (UserManagementProcedure sp_User = new UserManagementProcedure(db))
            {
                sp_User.CreateUser(userId, password, userNm);
            }
        }

        public void DeleteUser(int id)
        {
            using (ReportDbContext db = new ReportDbContext())
            {
                var org = db.Users.Where(x => x.Id == id).FirstOrDefault();
                if (org == null) throw new Exception("Login Failed");
                
            }
        }

        public User GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUser(string userId)
        {
            using (ReportDbContext db = new ReportDbContext())
            {
                var org = db.Users.Where(x => x.UserId == userId).FirstOrDefault();
                if (org == null) throw new Exception("Not Found User");
                return org;
            }
        }

        public void UpdateUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
