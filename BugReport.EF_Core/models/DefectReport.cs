using System;
using System.Collections.Generic;

namespace BugReport.EF_Core.models;

public partial class DefectReport
{
    public long Seq { get; set; }

    public long? ParentSeq { get; set; }

    public DateTime RegDtm { get; set; }

    public string RegIp { get; set; } = null!;

    public DateTime? ModfDtm { get; set; }

    public string? ModfIp { get; set; }

    public string Summary { get; set; } = null!;

    public string? Description { get; set; }

    public string? CategorySystemCode { get; set; }

    public int? Depth { get; set; }
}
