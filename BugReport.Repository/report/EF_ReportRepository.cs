using BugReport.Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugReport.Repository.report
{
    public class EF_ReportRepository : IReportRepository
    {
        public void CreateReport(EF_Core.BugReport report)
        {
            throw new NotImplementedException();
        }

        public void DeleteReport(EF_Core.BugReport report)
        {
            throw new NotImplementedException();
        }

        public List<EF_Core.BugReport> GetReports()
        {
            throw new NotImplementedException();
        }

        public List<EF_Core.BugReport> GetReports(bool demand)
        {
            throw new NotImplementedException();
        }

        public List<EF_Core.BugReport> GetReports(bool demand, DateTime lastWriteTime)
        {
            throw new NotImplementedException();
        }

        public void UpdateReport(EF_Core.BugReport report)
        {
            throw new NotImplementedException();
        }
    }
}
