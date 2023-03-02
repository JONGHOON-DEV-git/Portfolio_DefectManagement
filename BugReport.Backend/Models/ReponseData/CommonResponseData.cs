namespace BugReport.Backend.Models.ReponseData
{
    public class CommonResponseData
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public string? StackTrace { get; set; }
        public string? ErrorCode { get; set; }
        public dynamic? Data { get; set; }
        public dynamic? SubData { get; set; }
    }
}
