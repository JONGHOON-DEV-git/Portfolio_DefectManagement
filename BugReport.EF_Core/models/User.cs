using System;
using System.Collections.Generic;

namespace BugReport.EF_Core.models;

public partial class User
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime RegDtm { get; set; }

    public DateTime ModfDtm { get; set; }
}
