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
    internal class MemoryReportRepository : IReportRepository
    {
        public void CreateReport(DefectReport report)
        {
            throw new NotImplementedException();
        }

        public void DeleteReport(int defectId)
        {
            throw new NotImplementedException();
        }

        public vw_DefectReportInfo GetReport(int id)
        {
            throw new NotImplementedException();
        }

        public List<vw_DefectReportInfo> GetReports(int page, int row)
        {
            throw new NotImplementedException();
        }

        public List<vw_DefectReportInfo> GetReports(bool demand)
        {
            throw new NotImplementedException();
        }

        public List<vw_DefectReportInfo> GetReports(bool demand, DateTime lastWriteTime)
        {
            throw new NotImplementedException();
        }

        public void UpdateReport(int defectId, DefectReport report)
        {
            throw new NotImplementedException();
        }
    }
}
