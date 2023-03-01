using BugReport.EF_Core;
using BugReport.EF_Core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BugReport.Repository.interfaces
{
    public interface IReportRepository
    {
        public void CreateReport(DefectReport report);

        public List<DefectReport> GetReports();

        public List<DefectReport> GetReports(bool demand);

        public List<DefectReport> GetReports(bool demand, DateTime lastWriteTime);

        public void UpdateReport(DefectReport report);

        public void DeleteReport(DefectReport report);
    }
}
