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

        public List<DefectReportView> GetReports(int page, int row);

        public DefectReportView GetReport(int id);

        public List<DefectReportView> GetReports(bool demand);

        public List<DefectReportView> GetReports(bool demand, DateTime lastWriteTime);

        public void UpdateReport(int defectId, DefectReport report);

        public void DeleteReport(int defectId);
    }
}
