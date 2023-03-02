using BugReport.Core;
using BugReport.EF_Core.models;
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
        private readonly IUserRepository _UserRepository;

        public UserManagementService(IUserRepository userRepository)
        {
            this._UserRepository = userRepository;
        }

        /// <summary>
        /// 로그인 체크후 사용자 정보 반환
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public UserInfoMessage AuthenticateUser(string userId, string password)
        {
            if (_UserRepository.AuthenticateUser(userId, password))
            {
                var user = _UserRepository.GetUser(userId);
                var userInfo = new vw_UserInfo(user.UserId!, user.Username);
                return new UserInfoMessage() { UserData = userInfo, Success = true, Message = ExceptionMessages.NotMatchedIdOrPassword };
            }
            else
            {
                return new UserInfoMessage() { Success = false, Message = ExceptionMessages.NotMatchedIdOrPassword };
            }
        }

        public void CreateUser(string userId, string password, string userNm)
            => _UserRepository.CreateUser(userId, password, userNm);
    }
}
