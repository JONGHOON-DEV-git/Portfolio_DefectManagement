using BugReport.EF_Core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugReport.Repository.interfaces
{
    //작업필요 
    public interface IUserRepository
    {
        //Create User Info
        public void CreateUser(string userId, string password, string userNm);

        //Authenticate
        public bool AuthenticateUser(string userId, string password);


        public User GetUser(string userId);
    }
}
