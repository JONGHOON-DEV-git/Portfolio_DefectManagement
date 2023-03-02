using BugReport.EF_Core.models;
using BugReport.Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
