using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BugReport.Core
{
    public class ExceptionMessages
    {
        public static readonly string NotFoundUser = @"Not Found User";

        public static readonly string NotMatchedIdOrPassword = @"아이디 또는 패스워드가 맞지 않습니다.";
        
        public static readonly string ContainsId = @"이 아이디는 이미 존재합니다.";
    }
}
