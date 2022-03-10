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
    }
}
