using BugReport.EF_Core;
using BugReport.EF_Core.models;
using BugReport.Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugReport.Repository.report
{
    internal class Cache_ReportRepository : IReportRepository
    {
        public void CreateReport(DefectReport report)
        {
            throw new NotImplementedException();
        }

        public void DeleteReport(DefectReport report)
        {
            throw new NotImplementedException();
        }

        public List<DefectReport> GetReports()
        {
            throw new NotImplementedException();
        }

        public List<DefectReport> GetReports(bool demand)
        {
            throw new NotImplementedException();
        }

        public List<DefectReport> GetReports(bool demand, DateTime lastWriteTime)
        {
            throw new NotImplementedException();
        }

        public void UpdateReport(DefectReport report)
        {
            throw new NotImplementedException();
        }
    }
}
