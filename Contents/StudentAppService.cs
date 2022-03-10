using RDLCReports.Data.StudentsTable;

namespace RDLCReports.Contents
{
    public class StudentAppService : IStudentAppService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentAppService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<List<GetAllDto>> GetAllListAsync()
        {
            var result = await _studentRepository.GetAll();
            return result;
        }
    }
}
