using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RDLCReports.Contents;
using RDLCReports.Data.StudentsTable;

namespace RDLCReports.Pages.Student
{
    public class StudentModalModel : PageModel
    {
       
        public List<GetAllDto> getAllStudents { get; set; }
        private readonly IStudentAppService _studentAppService;
        public StudentModalModel(IStudentAppService studentAppService)
        {
            _studentAppService = studentAppService;
        }
        public async void OnGet()
        {
            var data = await _studentAppService.GetAllListAsync();
            getAllStudents = data;
        }
    }
}
