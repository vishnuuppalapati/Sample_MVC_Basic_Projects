using AspNetCore.Reporting;
using System.Reflection;
using System.Text;

namespace RDLCReports.Data.StudentsTable
{
    public class StudentRepository : IStudentRepository
    {
        private ApplicationDbContext _context;
        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<GetAllDto>> GetAll()
        {
            var studentsData = _context.Students.ToList();
            var studentsList = new List<GetAllDto>();
            foreach (var student in studentsData)
            {
                studentsList.Add(new GetAllDto() {
                Id = student.Id,
                StudentName = student.StudentName,
                Standard = student.Standard,
                Address = student.Address
                });
            }
            return studentsList;
        }

        public byte[] GenerateReportAsync(string reportName)
        {
            try
            {
                string fileDirPath = Assembly.GetExecutingAssembly().Location.Replace("RDLCReports.dll", string.Empty);
                string rdlcFilePath = string.Format("{0}ReportFiles\\{1}.rdlc", fileDirPath, reportName);
                Dictionary<string, string> parameters = new Dictionary<string, string>();
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                Encoding.GetEncoding("windows-1252");
                LocalReport report = new LocalReport(rdlcFilePath);
                var studentsData = _context.Students.ToList();
                var studentsList = new List<GetAllDto>();
                foreach (var student in studentsData)
                {
                    studentsList.Add(new GetAllDto()
                    {
                        Id = student.Id,
                        StudentName = student.StudentName,
                        Standard = student.Standard,
                        Address = student.Address
                    });
                }
                //List<UserDto> userList = new List<UserDto>();
                //userList.Add(new UserDto
                //{
                //    FirstName = "Alex",
                //    LastName = "Smith",
                //    Email = "alex.smith@gmail.com",
                //    Phone = "2345334432"
                //});

                //userList.Add(new UserDto
                //{
                //    FirstName = "John",
                //    LastName = "Legend",
                //    Email = "john.legend@gmail.com",
                //    Phone = "5633435334"
                //});

                //userList.Add(new UserDto
                //{
                //    FirstName = "Stuart",
                //    LastName = "Jones",
                //    Email = "stuart.jones@gmail.com",
                //    Phone = "3575328535"
                //});

                //report.AddDataSource("dsUsers", userList);
                report.AddDataSource("dsUsers", studentsList);
                var result = report.Execute(GetRenderType("pdf"), 1, parameters);
                return result.MainStream;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        private RenderType GetRenderType(string reportType)
        {
            var renderType = RenderType.Pdf;
            switch (reportType.ToLower())
            {
                default:
                case "pdf":
                    renderType = RenderType.Pdf;
                    break;
                case "word":
                    renderType = RenderType.Word;
                    break;
                case "excel":
                    renderType = RenderType.Excel;
                    break;
            }

            return renderType;
        }

    }
}
