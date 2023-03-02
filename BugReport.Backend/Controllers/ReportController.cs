using BugReport.Backend.Models.ReponseData;
using BugReport.Core;
using BugReport.EF_Core.models;
using BugReport.Repository.interfaces;
using BugReport.Service;
using Microsoft.AspNetCore.Mvc;

namespace BugReport.Backend.Controllers
{
    public class ReportController : Controller
    {
        private DefectReportService _ReportService { get; }
        public ReportController(DefectReportService defectReportService)
        {
            _ReportService = defectReportService;
        }

        public IActionResult IssuePage()
        {
            return View();
        }

        [HttpPost("/CreateReport")]
        public JsonResult CreateReport([FromBody] DefectReport report)
        {
            CommonResponseData resData = new ();
            try
            {
                this._ReportService.CreateReport(report);
                resData.Message = ResponseMessages.Save;
                resData.Success = true;
                return Json(resData);
            }
            catch (Exception ex)
            {
                resData.ErrorCode = ErrorCode.DefaultError;
                resData.Message = ex.Message;
                resData.StackTrace = ex.StackTrace;
                return Json(resData);
            }
        }
    }
}
