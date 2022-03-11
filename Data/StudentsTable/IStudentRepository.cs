namespace RDLCReports.Data.StudentsTable
{
    public interface IStudentRepository
    {
        Task<List<GetAllDto>> GetAll();
        byte[] GenerateReportAsync(string reportName);
    }
}
