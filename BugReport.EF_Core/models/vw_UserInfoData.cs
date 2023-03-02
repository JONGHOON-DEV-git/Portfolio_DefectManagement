using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugReport.EF_Core.models
{
#pragma warning disable IDE1006 // 명명 스타일
    public class vw_UserInfoData
    {
        public vw_UserInfoData(string loginID, string userName)
        {
            LoginID = loginID;
            UserName = userName;
        }

        public string LoginID { get; set; } 
        public string UserName { get; set; }
    }
}
