using System;
using System.Collections.Generic;

namespace BugReport.EF_Core.models;

public partial class vw_UserInfo
{
    public vw_UserInfo(string? userId, string username)
    {
        UserId = userId;
        Username = username;
    }

    public string? UserId { get; set; }

    public string Username { get; set; } = null!;
}
