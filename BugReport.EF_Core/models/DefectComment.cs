using System;
using System.Collections.Generic;

namespace BugReport.EF_Core.models;

public partial class DefectComment
{
    public long Id { get; set; }

    public long DefectReportId { get; set; }

    public string? Comment { get; set; }

    public string? BeforeStatusCode { get; set; }

    public string? AfterStatusCode { get; set; }

    public DateTime? RegDtm { get; set; }

    public int? RegId { get; set; }

    public DateTime? ModfDtm { get; set; }

    public int? ModfId { get; set; }
}
