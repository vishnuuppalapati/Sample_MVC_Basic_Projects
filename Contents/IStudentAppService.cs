using RDLCReports.Data.StudentsTable;

namespace RDLCReports.Contents
{
    public interface IStudentAppService
    {
        Task<List<GetAllDto>> GetAllListAsync();
    }
}
