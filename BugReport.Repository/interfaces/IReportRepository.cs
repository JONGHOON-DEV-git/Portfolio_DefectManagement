using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ef_model = BugReport.EF_Core;

namespace BugReport.Repository.interfaces
{
    public interface IReportRepository
    {
        public void CreateReport(ef_model.BugReport report);

        public List<ef_model.BugReport> GetReports();

        public List<ef_model.BugReport> GetReports(bool demand);

        public List<ef_model.BugReport> GetReports(bool demand, DateTime lastWriteTime);

        public void UpdateReport(ef_model.BugReport report);

        public void DeleteReport(ef_model.BugReport report);
    }
}
