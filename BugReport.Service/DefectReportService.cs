using BugReport.EF_Core.models;
using BugReport.Repository.interfaces;

namespace BugReport.Service
{
    public class DefectReportService
    {
        private readonly IReportRepository reportRepository;
        public DefectReportService(IReportRepository reportRepository)
        {
            this.reportRepository = reportRepository;
        }

        public void CreateReport(DefectReport report)
        {
            this.reportRepository.CreateReport(report);
        }
    }
}
