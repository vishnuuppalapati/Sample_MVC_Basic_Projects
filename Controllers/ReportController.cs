using AspNetCore.Reporting;
using Microsoft.AspNetCore.Mvc;
using RDLCReports.Data.StudentsTable;

namespace RDLCReports.Controllers
{
    public class ReportController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        public ReportController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("Report/GetReport")]
        public async Task<IActionResult> GetReport()
        {
            var result =await _studentRepository.GetAll();
            return StatusCode(StatusCodes.Status200OK, result);
        }
        [HttpGet]
        [Route("Report/GetRDLCReport/{reportName}")]
        public async Task<IActionResult> GetRDLCReport(string reportName)
        {
            var returnString = _studentRepository.GenerateReportAsync(reportName);
            return StatusCode(StatusCodes.Status200OK);
        }
    }
}
