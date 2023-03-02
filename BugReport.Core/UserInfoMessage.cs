using BugReport.EF_Core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugReport.Core
{
    public class UserInfoMessage
    {
        public UserInfoData? UserData { get; set; }
        public string? Message { get; set; }
        public bool Success { get; set; }
    }
}
