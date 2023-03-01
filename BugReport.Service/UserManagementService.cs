using BugReport.Repository.interfaces;
using BugReport.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugReport.Service
{
    public class UserManagementService : IUserManagementService
    {
        private readonly IUserRepository userRepository;
        
        public UserManagementService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public bool AuthenticateUser(string userId, string password)
        {
            return true;
        }

        public void CreateUser(string userId, string password, string userNm)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
