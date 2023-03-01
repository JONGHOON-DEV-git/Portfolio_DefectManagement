﻿using BugReport.EF_Core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugReport.Service.interfaces
{
    public interface IUserManagementService
    {
        //가입
        public void CreateUser(string userId, string password, string userNm);

        public bool AuthenticateUser(string userId, string password);
        //삭제
        public void DeleteUser(int id);

        //정보 수정
        public void UpdateUser(int id);
        
    }
}
